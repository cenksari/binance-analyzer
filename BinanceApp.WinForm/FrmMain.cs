namespace BinanceApp.WinForm
{
	using Models;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Threading.Tasks;
	using System.Windows.Forms;

	public partial class FrmMain : Form
	{
		Settings settings = null;

		public FrmMain()
		{
			InitializeComponent();

			settings = new Settings();

			if (settings.loaded)
			{
				TxtSymbol.Text = settings.symbol;

				Start();

				Resize += FrmMain_Resize;
			}
		}

		private void Start()
		{
			Timer timer = new Timer();
			timer.Interval = (Convert.ToInt32(settings.interval) * 60000);
			timer.Tick += new EventHandler(Timer_Tick);
			timer.Start();

			var t = Task.Factory.StartNew(() => GetLatestPrices());
		}

		private void Timer_Tick(Object o, EventArgs e)
		{
			var t = Task.Factory.StartNew(() => GetLatestPrices());
		}

		private async Task GetLatestPrices()
		{
			if (string.IsNullOrEmpty(settings.apiKey) && string.IsNullOrEmpty(settings.apiSecret))
			{
				SetText("Lütfen Binance apiKey ve apiSecret parametrelerini giriniz.");
			}
			else
			{
				ApiCaller apiCaller = new ApiCaller();

				RestRequest request = new RestRequest
				{
					Method = "GET",
					Endpoint = "api/v1/ticker/allPrices",
					Parameters = null
				};

				RestResponse response = await apiCaller.GetEndpoint(request);

				if (response.Status)
				{
					List<Price> prices = new List<Price>();

					JArray pricesJson = JArray.Parse(response.Response);

					foreach (var item in pricesJson.Children())
					{
						prices.Add
						(
							new Price
							{
								symbol = item["symbol"].ToString(),
								price = Convert.ToDecimal(item["price"])
							}
						);
					}

					foreach (Price item in prices)
					{
						if (item.symbol.Substring(item.symbol.Length - 3, 3) == "BTC")
						{
							await Tools.AddLatestPrice(settings.connectionString, item.symbol, item.price);
						}
					}

					SetText($"{DateTime.Now} - Fiyatlar alındı ve kaydedildi.");
				}
				else
				{
					SetText($"{DateTime.Now} - Binance API cevap vermiyor. Lütfen tekrar deneyiniz.");
				}
			}
		}

		private async Task Analyze()
		{
			string symbol = TxtSymbol.Text.Trim();

			if (string.IsNullOrEmpty(symbol))
			{
				SetText("Lütfen hesaplanacak sembolü giriniz.");
			}
			else
			{
				symbol = TxtSymbol.Text.Replace(" ", string.Empty).Trim();

				TxtSymbol.Text = symbol;

				List<Change> changes = await Tools.GetLatestPrices(settings.connectionString, symbol);

				if (changes == null)
				{
					SetText("Seçtiğiniz sembol için bir veri bulunamadı ya da değişim kurları veritabanı boş.");
				}
				else
				{
					List<ChangeRate> changeRates = await Logic.Analyze(changes, symbol);

					if (changeRates == null)
					{
						SetText("Analiz yapılamadı.");
					}
					else
					{
						string Text = "";

						foreach (ChangeRate item in changeRates)
						{
							Text = $"{item.symbol} için fiyat değişimi hesaplandı :" + Environment.NewLine;
							Text += $"İlk fiyat : {item.firstPrice}" + Environment.NewLine;
							Text += $"Son fiyat : {item.lastPrice}" + Environment.NewLine;
							Text += $"Değişim oranı : {item.changeRate}" + Environment.NewLine;
							Text += $"Değişen fiyat : {item.priceChange}" + Environment.NewLine;
							Text += $"İlk bakılan tarih : {item.firstDate}" + Environment.NewLine;
							Text += $"Son bakılan tarih : {item.lastDate}";

							SetText(Text);
						}
					}
				}
			}
		}


		delegate void SetTextCallback(string text);
		private void SetText(string text)
		{
			if (TxtLog.InvokeRequired)
			{
				SetTextCallback d = new SetTextCallback(SetText);
				Invoke(d, new object[] { text });
			}
			else
			{
				TxtLog.Text += text + Environment.NewLine + Environment.NewLine;

				TxtLog.SelectionStart = TxtLog.Text.Length;
				TxtLog.ScrollToCaret();
			}
		}

		private async void BtnAnalyze_Click(object sender, EventArgs e)
		{
			await Analyze();
		}

		private void MnuClearConsole_Click(object sender, EventArgs e)
		{
			TxtLog.Text = string.Empty;
		}

		private void MnuGetPrices_Click(object sender, EventArgs e)
		{
			var t = Task.Factory.StartNew(() => GetLatestPrices());
		}

		private void MnuAnalyze_Click(object sender, EventArgs e)
		{
			BtnAnalyze.PerformClick();
		}

		private void MnuExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void MnuProgramSettings_Click(object sender, EventArgs e)
		{
			FrmSettings settingsForm = new FrmSettings();
			settingsForm.ShowDialog();
		}

		private void MnuAbout_Click(object sender, EventArgs e)
		{
			MessageBox.Show($"Binance v.{settings.version}", "Binance");
		}

		private void FrmMain_Resize(object sender, EventArgs e)
		{
			TxtLog.Width = ActiveForm.Width - 40;
			TxtLog.Height = ActiveForm.Height - 159;

			TxtSymbol.Width = ActiveForm.Width - 220;
		}
	}
}
namespace BinanceApp.WinForm
{
	using Models;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Text;
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

			Task.Factory.StartNew(() => GetLatestPrices());
		}

		private void Timer_Tick(Object o, EventArgs e)
		{
			Task.Factory.StartNew(() => GetLatestPrices());
		}

		private async Task GetLatestPrices()
		{
			if (string.IsNullOrEmpty(settings.apiKey) && string.IsNullOrEmpty(settings.apiSecret))
				SetText("Lütfen Binance apiKey ve apiSecret parametrelerini giriniz.");
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
							await Tools.AddLatestPrice(settings.connectionString, item.symbol, item.price);
					}

					SetText($"{DateTime.Now} - Fiyatlar alındı ve kaydedildi.");
				}
				else
					SetText($"{DateTime.Now} - Binance API cevap vermiyor. Lütfen tekrar deneyiniz.");
			}
		}

		private async Task Analyze()
		{
			string symbol = TxtSymbol.Text.Trim();

			if (string.IsNullOrEmpty(symbol))
				SetText("Lütfen hesaplanacak sembolü giriniz.");
			else
			{
				symbol = TxtSymbol.Text.Replace(" ", string.Empty).Trim();

				TxtSymbol.Text = symbol;

				List<Change> changes = await Tools.GetLatestPrices(settings.connectionString, symbol);

				if (changes == null)
					SetText("Seçtiğiniz sembol için bir veri bulunamadı ya da değişim kurları veritabanı boş.");
				else
				{
					List<ChangeRate> changeRates = await Logic.Analyze(changes, symbol);

					if (changeRates == null)
						SetText("Analiz yapılamadı.");
					else
					{
						StringBuilder text = null;

						foreach (ChangeRate item in changeRates)
						{
							text = new StringBuilder();

							text.AppendFormat("{0} için fiyat değişimi hesaplandı", item.symbol);
							text.AppendLine("");
							text.AppendFormat("İlk fiyat : {0}", item.firstPrice.ToString());
							text.AppendLine("");
							text.AppendFormat("Son fiyat : {0}", item.lastPrice.ToString());
							text.AppendLine("");
							text.AppendFormat("Değişim oranı : {0}", item.changeRate);
							text.AppendLine("");
							text.AppendFormat("Değişen fiyat : {0}", item.priceChange.ToString());
							text.AppendLine("");
							text.AppendFormat("İlk bakılan tarih : {0}", item.firstDate.ToString());
							text.AppendLine("");
							text.AppendFormat("Son bakılan tarih: {0}", item.lastDate.ToString());

							SetText(text.ToString());
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
			Task.Factory.StartNew(() => GetLatestPrices());
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
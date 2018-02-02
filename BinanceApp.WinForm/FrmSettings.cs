namespace BinanceApp.WinForm
{
	using Models;
	using System.Windows.Forms;

	public partial class FrmSettings : Form
	{
		public FrmSettings()
		{
			InitializeComponent();

			Settings settings = new Settings();

			if (settings.loaded)
			{
				TxtApiKey.Text = settings.apiKey;
				TxtApiSecret.Text = settings.apiSecret;
				TxtSymbol.Text = settings.symbol;
				TxtInterval.Text = settings.interval;
				TxtDbAddress.Text = settings.dbAddress;
				TxtDbName.Text = settings.dbName;
				TxtDbUsername.Text = settings.dbUsername;
				TxtDbPassword.Text = settings.dbPassword;
			}
		}

		private void BtnCancel_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		private void BtnSave_Click(object sender, System.EventArgs e)
		{
			string apiKey = TxtApiKey.Text;
			string apiSecret = TxtApiSecret.Text;
			string symbol = TxtSymbol.Text;
			string interval = TxtInterval.Text;
			string dbAddress = TxtDbAddress.Text;
			string dbName = TxtDbName.Text;
			string dbUsername = TxtDbUsername.Text;
			string dbPassword = TxtDbPassword.Text;

			Settings settings = new Settings();

			if (settings.loaded)
			{
				SettingParameters settingParameters = new SettingParameters();
				settingParameters.version = "1.0";
				settingParameters.apiKey = apiKey;
				settingParameters.apiSecret = apiSecret;
				settingParameters.symbol = symbol;
				settingParameters.interval = interval;
				settingParameters.dbAddress = dbAddress;
				settingParameters.dbName = dbName;
				settingParameters.dbUsername = dbUsername;
				settingParameters.dbPassword = dbPassword;

				settings.SetSettings(settingParameters);

				MessageBox.Show("Ayarlar başarıyla kaydedildi.", "Binance");

				Close();
			}			
		}
	}
}
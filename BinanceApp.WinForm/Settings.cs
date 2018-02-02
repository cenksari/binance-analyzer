namespace BinanceApp.WinForm
{
	using Models;
	using Newtonsoft.Json;
	using System.IO;
	using System.Windows.Forms;

	class Settings
	{
		public bool loaded { get; set; }
		public string version { get; set; }
		public string apiKey { get; set; }
		public string apiSecret { get; set; }
		public string interval { get; set; }
		public string symbol { get; set; }
		public string connectionString { get; set; }

		public string dbAddress { get; set; }
		public string dbName { get; set; }
		public string dbUsername { get; set; }
		public string dbPassword { get; set; }

		private string configurationFile = Path.Combine(Application.StartupPath, "settings.json");

		public Settings()
		{
			GetSettings();
		}

		private void GetSettings()
		{
			loaded = File.Exists(configurationFile) ? true : false;

			if (loaded)
			{
				using (StreamReader sr = new StreamReader(configurationFile))
				{
					string json = sr.ReadToEnd();

					SettingParameters settings = JsonConvert.DeserializeObject<SettingParameters>(json);

					version = settings.version;
					apiKey = settings.apiKey;
					apiSecret = settings.apiSecret;
					interval = settings.interval;
					symbol = settings.symbol;
					dbAddress = settings.dbAddress;
					dbName = settings.dbName;
					dbUsername = settings.dbUsername;
					dbPassword = settings.dbPassword;

					connectionString = $"server={dbAddress};database={dbName};uid={dbUsername};password={dbPassword};Max Pool Size=1000;";
				}
			}
			else
			{
				MessageBox.Show("Konfigürasyon dosyası bulunamadı. Program kapatılacak.", "Kritik hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Application.Exit();
			}
		}

		public void SetSettings(SettingParameters settings)
		{
			loaded = File.Exists(configurationFile) ? true : false;

			if (loaded)
			{
				string json = JsonConvert.SerializeObject(settings, Formatting.Indented);

				File.WriteAllText(configurationFile, json);

				version = settings.version;
				apiKey = settings.apiKey;
				apiSecret = settings.apiSecret;
				interval = settings.interval;
				symbol = settings.symbol;
				dbAddress = settings.dbAddress;
				dbName = settings.dbName;
				dbUsername = settings.dbUsername;
				dbPassword = settings.dbPassword;

				connectionString = $"server={dbAddress};database={dbName};uid={dbUsername};password={dbPassword};Max Pool Size=1000;";
			}
			else
			{
				MessageBox.Show("Konfigürasyon dosyası bulunamadı. Program kapatılacak.", "Kritik hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Application.Exit();
			}
		}
	}
}
namespace BinanceApp.WinForm.Models
{
	using System;

	public class Price
	{
		public string symbol { get; set; }
		public decimal price { get; set; }
	}

	public class Change
	{
		public string symbol { get; set; }
		public decimal price { get; set; }
		public DateTime latestDate { get; set; }
	}

	public class ChangeRate
	{
		public string symbol { get; set; }
		public DateTime firstDate { get; set; }
		public DateTime lastDate { get; set; }
		public decimal firstPrice { get; set; }
		public decimal lastPrice { get; set; }
		public decimal priceChange { get; set; }
		public string changeRate { get; set; }
	}

	public class SettingParameters
	{
		public string version { get; set; }
		public string apiKey { get; set; }
		public string apiSecret { get; set; }
		public string interval { get; set; }
		public string symbol { get; set; }
		public string dbAddress { get; set; }
		public string dbName { get; set; }
		public string dbUsername { get; set; }
		public string dbPassword { get; set; }
	}
}
namespace BinanceApp.WinForm
{
	using Models;
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Threading.Tasks;

	public class Logic
	{
		public static async Task<List<ChangeRate>> Analyze(List<Change> changes, string symbol)
		{
			await Task.FromResult(DateTime.Now);

			List<ChangeRate> returnedValue = null;

			if (changes != null)
			{
				returnedValue = new List<ChangeRate>();

				string[] symbols = symbol.Split(',');

				foreach(string sym in symbols)
				{
					var firstDate = (from v in changes
									 where v.symbol == sym
									 orderby v.latestDate ascending
									 select new
									 {
										 Symbol = v.symbol,
										 Price = v.price,
										 Checked = v.latestDate
									 }).FirstOrDefault();

					var lastDate = (from v in changes
									where v.symbol == sym
									orderby v.latestDate descending
									select new
									{
										Symbol = v.symbol,
										Price = v.price,
										Checked = v.latestDate
									}).FirstOrDefault();

					if (firstDate != null && lastDate != null)
					{
						decimal changeRate = 0;
						string changeValue = "";
						decimal priceChange = 0;
						decimal firstPrice = firstDate.Price;
						decimal lastPrice = lastDate.Price;

						priceChange = (lastPrice - firstPrice);

						changeRate = ((lastPrice / firstPrice) - 1) * 100;
						changeValue = Math.Round(changeRate, 2).ToString();

						returnedValue.Add
						(
							new ChangeRate
							{
								symbol = firstDate.Symbol,
								firstPrice = firstPrice,
								lastPrice = lastPrice,
								firstDate = firstDate.Checked,
								lastDate = lastDate.Checked,
								priceChange = priceChange,
								changeRate = changeValue
							}
						);
					}
				}
			}

			return returnedValue;
		}
	}
}
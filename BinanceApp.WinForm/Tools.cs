namespace BinanceApp.WinForm
{
	using Models;
	using System;
	using System.Collections.Generic;
	using System.Data;
	using System.Data.SqlClient;
	using System.Linq;
	using System.Threading.Tasks;

	public class Tools
	{
		public static async Task AddLatestPrice(string connectionString, string symbol, decimal price)
		{
			try
			{
				using (SqlConnection sqlConnection = new SqlConnection(connectionString))
				{
					using (SqlCommand sqlCommand = new SqlCommand("add_latest_price", sqlConnection))
					{
						sqlCommand.CommandType = CommandType.StoredProcedure;
						sqlCommand.Parameters.AddWithValue("symbol", symbol);
						sqlCommand.Parameters.AddWithValue("price", price);

						if (sqlConnection.State == ConnectionState.Closed || sqlConnection.State == ConnectionState.Broken)
							await sqlConnection.OpenAsync();

						await sqlCommand.ExecuteNonQueryAsync();
					}
				}
			}
			catch (Exception ex)
			{
				throw new OperationCanceledException(ex.Message);
			}
		}

		public static async Task<List<Change>> GetLatestPrices(string connectionString, string symbol)
		{
			List<Change> returnedValue = null;

			string[] symbols = symbol.Split(',');

			try
			{
				using (SqlConnection sqlConnection = new SqlConnection(connectionString))
				{
					using (SqlCommand sqlCommand = new SqlCommand("get_latest_prices", sqlConnection))
					{
						sqlCommand.CommandType = CommandType.StoredProcedure;
						sqlCommand.Parameters.AddWithValue("symbol", symbol);
						sqlCommand.Parameters.AddWithValue("topn", (symbols.Count() * 5));

						if (sqlConnection.State == ConnectionState.Closed || sqlConnection.State == ConnectionState.Broken)
							await sqlConnection.OpenAsync();

						using (SqlDataReader dr = await sqlCommand.ExecuteReaderAsync(CommandBehavior.CloseConnection))
						{
							if (dr.HasRows)
							{
								returnedValue = new List<Change>();

								while (await dr.ReadAsync())
								{
									returnedValue.Add
									(
										new Change
										{
											symbol = dr["symbol"].ToString(),
											price = Convert.ToDecimal(dr["price"]),
											latestDate = Convert.ToDateTime(dr["checked"])
										}
									);
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				throw new OperationCanceledException(ex.Message);
			}

			return returnedValue;
		}
	}
}
namespace BinanceApp.WinForm
{
	using RestSharp;
	using System.Threading;
	using System.Threading.Tasks;

	class Api
	{
		private string ApiUrl = "https://api.binance.com";
		private string ApiKey = string.Empty;
		private string ApiSecret = string.Empty; 

		public Api()
		{
			Settings settings = new Settings();

			ApiKey = settings.apiKey;
			ApiSecret = settings.apiSecret;
		}

		public async Task<string> GetApiEndpoint(string endpoint, string postData, Method method)
		{
			string returnedValue = string.Empty;

			var client = new RestClient($"{ApiUrl}");

			RestRequest request = null;

			if (method == Method.GET)
			{
				request = new RestRequest($"{endpoint}?{postData}", method);
			}
			else
			{

			}

			var cancellationTokenSource = new CancellationTokenSource();

			IRestResponse response = await client.ExecuteTaskAsync(request, cancellationTokenSource.Token);

			returnedValue = response.Content;

			return returnedValue;
		}
	}
}
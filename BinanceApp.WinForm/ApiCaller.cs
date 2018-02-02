namespace BinanceApp.WinForm
{
	using RestSharp;
	using System;
	using System.Collections.Generic;
	using System.Threading;
	using System.Threading.Tasks;

	class ApiCaller
	{
		private string ApiAddress = "https://api.binance.com";
		private string ApiKey = string.Empty;
		private string ApiSecret = string.Empty; 

		public ApiCaller()
		{
			Settings settings = new Settings();

			ApiKey = settings.apiKey;
			ApiSecret = settings.apiSecret;
		}

		public async Task<RestResponse> GetEndpoint(RestRequest apiRequest)
		{
			RestResponse returnedValue = new RestResponse();

			RestClient client = new RestClient();

			client.BaseUrl = new Uri(ApiAddress);

			RestSharp.RestRequest request = new RestSharp.RestRequest(apiRequest.Endpoint);

			request.Method = (apiRequest.Method == "POST") ? Method.POST : Method.GET;

			if (apiRequest.Parameters != null)
			{
				foreach (RestParameter parameter in apiRequest.Parameters)
				{
					request.AddParameter
					(
						parameter.Name,
						parameter.Value
					);
				}
			}

			var cancellationTokenSource = new CancellationTokenSource();

			var response = await client.ExecuteTaskAsync
			(
				request,
				cancellationTokenSource.Token
			);

			if (response.StatusCode == System.Net.HttpStatusCode.OK)
			{
				returnedValue.Status = true;
				returnedValue.Response = response.Content;
			}
			else
			{
				returnedValue.Status = false;
				returnedValue.Message = $"{response.StatusDescription} {response.ErrorMessage}";
				returnedValue.Response = response.Content;
				returnedValue.ErrorCode = response.StatusCode.ToString();
			}

			return returnedValue;
		}
	}

	public class RestResponse
	{
		public bool Status { get; set; }
		public string Message { get; set; }
		public string Response { get; set; }
		public string ErrorCode { get; set; }
	}

	public class RestRequest
	{
		public string Method { get; set; }
		public string Endpoint { get; set; }
		public List<RestParameter> Parameters { get; set; }
	}

	public class RestParameter
	{
		public string Name { get; set; }
		public string Value { get; set; }
	}
}
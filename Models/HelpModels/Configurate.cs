using System;
using System.Net.Http;

namespace HuntflowLib.Models.HelpModels
{
    public static class Configurate
    {
        public const string defaultBaseUrl = "https://api.huntflow.ru/v2/";

        public static HttpClient GetHttpClient(string accessToken, string baseUrl = null)
        {
            if (baseUrl == null)
                baseUrl = defaultBaseUrl;

            return ConfigurateHttpClient(accessToken, baseUrl);
        }

        public static HttpClient GetHttpClient(string accessToken, string accaundId, string baseUrl = null)
        {
            if (baseUrl == null)
                baseUrl = $"{defaultBaseUrl}accounts/{accaundId}/";

            return ConfigurateHttpClient(accessToken, baseUrl);
        }

        private static HttpClient ConfigurateHttpClient(string accessToken, string baseUrl)
        {
            HttpClient HttpClient = new HttpClient
            {
                BaseAddress = new Uri(baseUrl)
            };
            HttpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {accessToken}");

            return HttpClient;
        }
    }
}

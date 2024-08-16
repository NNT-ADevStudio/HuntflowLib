using System.Net.Http;

namespace HuntflowLib.Models.HelpModels
{
    public class Auth
    {
        public HttpClient HttpClient { get; private set; }
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public int? AccauntId { get; set; } = null;

        public Auth(string accessToken, string refreshToken)
        {
            AccessToken = accessToken;
            RefreshToken = refreshToken;
            HttpClient = Configurate.GetHttpClient(accessToken);
        }

        public Auth(string accessToken, string refreshToken, int accauntId)
        {
            AccessToken = accessToken;
            RefreshToken = refreshToken;
            AccauntId = accauntId;
            HttpClient = Configurate.GetHttpClient(accessToken, accauntId);
        }

        public HttpClient GenerateHttpClient()
        {
            if (AccauntId == null) return Configurate.GetHttpClient(AccessToken);
            return Configurate.GetHttpClient(AccessToken, (int)AccauntId);
        }
    }
}

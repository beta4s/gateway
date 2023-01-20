using System.Net.Http.Headers;

namespace b4s.Tools
{
    public class Http
    {

        public static HttpClient HeadersBasicAuth(string baseUrl, string clientId, string clientSecret)
        {
            HttpClientHandler handler = new HttpClientHandler() { UseDefaultCredentials = false };
            HttpClient client = new HttpClient(handler);
            try
            {
                client.BaseAddress = new Uri(baseUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/x-www-form-urlencoded"));
                client.DefaultRequestHeaders.Add("Authorization", "Basic " + Convert.ToBase64String(
                         System.Text.ASCIIEncoding.ASCII.GetBytes(
                            $"{clientId}:{clientSecret}")));
            }
            catch 
            {
                throw;
            }
            return client;
        }

    }

}
using System.Threading.Tasks;

namespace Common.HttpClient
{
    public class HttpClientFactory : IHttpClientFactory
    {
        public async Task<System.Net.Http.HttpClient> GetHttpClient()
        {
            return await Task.FromResult(new System.Net.Http.HttpClient());
        }
    }
}

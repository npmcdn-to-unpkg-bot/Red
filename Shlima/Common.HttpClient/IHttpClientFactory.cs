using System.Threading.Tasks;

namespace Common.HttpClient
{
    public interface IHttpClientFactory
    {
        Task<System.Net.Http.HttpClient> GetHttpClient();
    }
}

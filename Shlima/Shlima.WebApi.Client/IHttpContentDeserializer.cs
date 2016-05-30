using System.Net.Http;
using System.Threading.Tasks;

namespace Shlima.WebApi.Client
{
    public interface IHttpContentDeserializer<T>
    {
        Task<T> DeserializeAsync(HttpResponseMessage httpResponseMessage);
    }
}

using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Common.HttpClient
{
    public interface IExpectedStatusCodeHandler<T>
    {
        HttpStatusCode HttpStatusCode { get; }

        Task<T> Handle(HttpContent httpContent);
    }
}

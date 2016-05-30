using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Shlima.WebApi.Client
{
    public interface IUnexpectedStatusCodeHandler
    {
        Task<Exception> HandleAsync(HttpResponseMessage httpResponseMessage);
    }
}

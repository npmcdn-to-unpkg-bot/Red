using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Common.HttpClient
{
    public interface IUnexpectedStatusCodeHandler
    {
        Task<Exception> Handle(HttpStatusCode httpStatusCode, HttpContent httpContent);
    }
}

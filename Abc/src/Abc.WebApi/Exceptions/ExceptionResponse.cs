using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;

namespace Abc.WebApi.Exceptions
{
    public class ExceptionResponse : IHttpActionResult
    {
        private readonly HttpStatusCode _statusCode;

        private readonly string _message;

        private readonly HttpRequestMessage _request;

        public ExceptionResponse(HttpStatusCode statusCode, string message, HttpRequestMessage request)
        {
            _statusCode = statusCode;
            _message = message;
            _request = request;
        }

        public Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
        {
            var response = new HttpResponseMessage(_statusCode)
            {
                RequestMessage = _request,
                Content = new StringContent(_message)
            };
            return Task.FromResult(response);
        }
    }
}

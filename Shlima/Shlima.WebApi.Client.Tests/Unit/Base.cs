using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Moq;
using Moq.Protected;
using NUnit.Framework;

namespace Shlima.WebApi.Client.Tests.Unit
{
    [TestFixture]
    public class Base
    {
        protected HttpClient GetHttpClient(HttpStatusCode statusCode, string content)
        {
            return new HttpClient(GetHttpMessageHandler(statusCode, content))
            {
                BaseAddress = new Uri("http://anyvalidaddress.com")
            };
        }

        protected HttpMessageHandler GetHttpMessageHandler(HttpStatusCode statusCode, string content)
        {
            var mockHttpMessageHandler = new Mock<HttpMessageHandler>();
            mockHttpMessageHandler.Protected()
                .Setup<Task<HttpResponseMessage>>(
                    "SendAsync",
                    ItExpr.IsAny<HttpRequestMessage>(),
                    ItExpr.IsAny<CancellationToken>())
                .Returns(Task<HttpResponseMessage>.Factory.StartNew(() => new HttpResponseMessage()
                {
                    StatusCode = statusCode,
                    Content = content == null ? null : new StringContent(content),
                }));
            return mockHttpMessageHandler.Object;
        }
    }
}

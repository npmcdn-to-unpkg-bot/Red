using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Owin.Testing;
using NUnit.Framework;
using Owin;

namespace Shlima.WebApi.Client.IntegrationTests
{
    public class SampleTests
    {
        [Test]
        public void TestWithStartupClass()
        {
            using (var server = TestServer.Create<Startup>())
            {
                var result = server.HttpClient.GetAsync("/").Result.Content.ReadAsStringAsync().Result;
                Assert.That(result, Is.EqualTo("Hello world using OWIN TestServer"));
            }
        }

        public class Startup
        {
            public void Configuration(IAppBuilder appBuilder)
            {
                appBuilder.Run(async context =>
                {
                    await context.Response.WriteAsync("Hello world using OWIN TestServer");
                });
            }
        }

        [Test]
        public void TestWithInLineServer()
        {
            using (var server = TestServer.Create(app =>
            {
                app.Run(context => context.Response.WriteAsync("Hello world using OWIN TestServer"));
            }))
            {
                var result = server.HttpClient.GetAsync("/").Result.Content.ReadAsStringAsync().Result;
                Assert.That(result, Is.EqualTo("Hello world using OWIN TestServer"));
            }
        }

        [Test]
        public void Test()
        {
            using (var server = TestServer.Create(app =>
            {
                app.Run(async context =>
                {
                    if (context.Request.Headers.Get("Header1") == "HeaderValue1")
                    {
                        await context.Response.WriteAsync("Hello world using OWIN TestServer");
                    }
                    else
                    {
                        await context.Response.WriteAsync("Header missing");
                    }
                });
            }))
            {
                var httpClient = new HttpClient(new AddHeaderHttpHandler(server.Handler));
                var result = httpClient.GetAsync("http://localhost:1234/").Result.Content.ReadAsStringAsync().Result;
                Assert.That(result, Is.EqualTo("Hello world using OWIN TestServer"));
            }

        }

        public class AddHeaderHttpHandler : DelegatingHandler
        {
            public AddHeaderHttpHandler(HttpMessageHandler handler)
                : base(handler)
            {
            }

            protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, System.Threading.CancellationToken cancellationToken)
            {
                request.Headers.Add("Header1", "HeaderValue1");
                return await base.SendAsync(request, cancellationToken);
            }
        }
    }
}

using System;
using System.Net.Http;
using Microsoft.Owin.Hosting;
using NUnit.Framework;

namespace Api.Test.Acceptance.ValueApi
{
    public class Test
    {
        [Test]
        public void Test1()
        {
            const int port = 8086;
            using (WebApp.Start<Startup>("http://localhost:" + port))
            {
                var client = new HttpClient {BaseAddress = new Uri("http://localhost:" + port)};

                var response = client.GetAsync("/value/5").Result;
                var body = response.Content.ReadAsStringAsync().Result;

                Assert.That(body, Does.Contain("5"));
            }

        }
    }
}

using System;
using System.Net;
using System.Net.Http;
using Microsoft.Owin.Hosting;
using Newtonsoft.Json;
using NUnit.Framework;

namespace Shlima.WebApi.SelfHost
{
    public class UnitTests
    {
        [Test]
        public void Test1()
        {
            using (WebApp.Start<Startup>("http://localhost/1234"))
            {
                using (var httpClient = new HttpClient())
                {
                    using (var httpResponseMessage = httpClient.GetAsync("http://localhost/1234").Result)
                    {

                        //if (httpResponseMessage.StatusCode == HttpStatusCode.OK)
                        //{
                        //    using (var httpContent = httpResponseMessage.Content)
                        //    {
                        //        var contentAsString = httpContent.ReadAsStringAsync().Result;
                        //        var model = JsonConvert.DeserializeObject<Models.ShoppingList.List>(contentAsString);
                        //    }
                        //}
                        //throw new NotImplementedException();
                    }
                }
            }
        }
    }
}

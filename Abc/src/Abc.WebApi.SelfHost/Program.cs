using System;
using Microsoft.Owin.Hosting;
using System.Threading;

namespace Abc.WebApi.SelfHost
{
    class Program
    {
        static void Main()
        {
            var url = "http://*:5000";
            using (WebApp.Start<WebApi.Startup>(url))
            {
                Console.WriteLine("Service running on url:" + url);
                Thread.Sleep(Timeout.Infinite);
            }
        }
    }
}

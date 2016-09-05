using System;
using System.Threading;
using Microsoft.Owin.Hosting;

namespace Abc.TestClient.SelfHost
{
    class Program
    {
        static void Main()
        {
            var url = "http://*:5001";
            using (WebApp.Start<Startup>(url))
            {
                Console.WriteLine("Service running on url:" + url);
                Thread.Sleep(Timeout.Infinite);
            }
        }
    }
}

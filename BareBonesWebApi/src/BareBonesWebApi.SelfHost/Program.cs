using System;
using BareBonesWebApi.WebApi;
using Microsoft.Owin.Hosting;

namespace BareBonesWebApi.SelfHost
{
    class Program
    {
        static void Main()
        {
            using (WebApp.Start<Startup>("http://localhost:12345"))
            {
                Console.ReadLine();
            }
        }
    }
}

using Microsoft.Owin.Hosting;
using System;

namespace Shlima.WebApi.SelfHost
{
    public class Program
    {
        private static void Main()
        {
            using (WebApp.Start<Startup>("http://localhost/Shlima.WebApi/"))
            {
                Console.WriteLine("Press any key to stop the owin self host...");
                Console.ReadLine();
            }
        }
    }

}

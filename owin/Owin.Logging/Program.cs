using System;
using Microsoft.Owin.Hosting;

namespace Owin.Logging
{
    class Program
    {
        static void Main()
        {
            WebApp.Start<Startup>("http://localhost:8085");
            Console.WriteLine("Server Started; Press enter to Quit");
            Console.ReadLine();
        }
    }
}

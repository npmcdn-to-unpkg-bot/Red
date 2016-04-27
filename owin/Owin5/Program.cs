using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin;
using Microsoft.Owin.Hosting;
using Owin;

namespace Owin5
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

    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.Use(typeof(Middleware));
        }
    }

    public class Middleware : OwinMiddleware
    {
        public Middleware(OwinMiddleware next)
        : base(next)
        {
        }

        public override async Task Invoke(IOwinContext context)
        {
            Console.WriteLine("Begin Request");
            await context.Response.WriteAsync("<h1>Hello from My  Middleware</h1>");
            await Next.Invoke(context);

            Console.WriteLine("End Request");
        }
    }
}

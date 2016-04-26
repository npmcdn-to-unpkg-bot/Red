using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.IO;
using Owin;
using Microsoft.Owin.Hosting;

namespace Owin1
{
    using AppFunc = Func<IDictionary<string, object>, Task>;

    class Program
    {
        static void Main()
        {
            WebApp.Start<Startup>("http://localhost:8081");
            Console.WriteLine("Server Started; Press enter to Quit");
            Console.ReadLine();
        }
    }

    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var middleware = new Func<AppFunc, AppFunc>(MyMiddleWare);
            var otherMiddleware = new Func<AppFunc, AppFunc>(MyOtherMiddleWare);

            app.Use(middleware);
            app.Use(otherMiddleware);
        }

        public AppFunc MyMiddleWare(AppFunc next)
        {
            AppFunc appFunc = async environment =>
            {
                var response = environment["owin.ResponseBody"] as Stream;
                if (response != null)
                    using (var writer = new StreamWriter(response))
                    {
                        await writer.WriteAsync("<h1>Hello from My First.1 Middleware</h1>");
                    }
                await next.Invoke(environment);
            };
            return appFunc;
        }

        public AppFunc MyOtherMiddleWare(AppFunc next)
        {
            AppFunc appFunc = async environment =>
            {
                var response = environment["owin.ResponseBody"] as Stream;
                if (response != null)
                    using (var writer = new StreamWriter(response))
                    {
                        await writer.WriteAsync("<h1>Hello from My Second.1 Middleware</h1>");
                    }
                await next.Invoke(environment);
            };
            return appFunc;
        }
    }
}
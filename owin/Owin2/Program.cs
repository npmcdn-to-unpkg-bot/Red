using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Owin;
using Microsoft.Owin.Hosting;
using Microsoft.Owin;

namespace Owin2
{
    using AppFunc = Func<IDictionary<string, object>, Task>;

    class Program
    {
        static void Main()
        {
            WebApp.Start<Startup>("http://localhost:8082");
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
                IOwinContext context = new OwinContext(environment);
                await context.Response.WriteAsync("<h1>Hello from My First.2 Middleware</h1>");
                await next.Invoke(environment);
            };
            return appFunc;
        }

        public AppFunc MyOtherMiddleWare(AppFunc next)
        {
            AppFunc appFunc = async environment =>
            {
                IOwinContext context = new OwinContext(environment);
                await context.Response.WriteAsync("<h1>Hello from My Second.2 Middleware</h1>");
                await next.Invoke(environment);
            };
            return appFunc;
        }
    }
}
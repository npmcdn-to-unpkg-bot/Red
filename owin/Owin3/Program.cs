using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Owin;
using Microsoft.Owin.Hosting;
using Microsoft.Owin;

namespace Owin3
{
    using AppFunc = Func<IDictionary<string, object>, Task>;

    class Program
    {
        static void Main()
        {
            WebApp.Start<Startup>("http://localhost:8083");
            Console.WriteLine("Server Started; Press enter to Quit");
            Console.ReadLine();
        }
    }

    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.Use<MyMiddlewareComponent>();
            app.Use<MyOtherMiddlewareComponent>();
        }
    }

    public class MyMiddlewareComponent
    {
        readonly AppFunc _next;

        public MyMiddlewareComponent(AppFunc next)
        {
            _next = next;
        }

        public async Task Invoke(IDictionary<string, object> environment)
        {
            IOwinContext context = new OwinContext(environment);
            await context.Response.WriteAsync("<h1>Hello from My First.3 Middleware</h1>");
            await _next.Invoke(environment);
        }
    }

    public class MyOtherMiddlewareComponent
    {
        readonly AppFunc _next;

        public MyOtherMiddlewareComponent(AppFunc next)
        {
            _next = next;
        }

        public async Task Invoke(IDictionary<string, object> environment)
        {
            IOwinContext context = new OwinContext(environment);
            await context.Response.WriteAsync("<h1>Hello from My Second.3 Middleware</h1>");
            await _next.Invoke(environment);
        }
    }
}
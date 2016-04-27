using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Owin;
using Microsoft.Owin.Hosting;
using Owin;

namespace Owin4
{
    using AppFunc = Func<IDictionary<string, object>, Task>;

    public static class AppBuilderExtensions
    {
        public static void UseMyMiddleware(this IAppBuilder app, MyMiddlewareConfigOptions configOptions)
        {
            app.Use<MyMiddlewareComponent>(configOptions);
        }

        public static void UseMyOtherMiddleware(this IAppBuilder app)
        {
            app.Use<MyOtherMiddlewareComponent>();
        }
    }

    class Program
    {
        static void Main()
        {
            WebApp.Start<Startup>("http://localhost:8084");
            Console.WriteLine("Server Started; Press enter to Quit");
            Console.ReadLine();
        }
    }

    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var options = new MyMiddlewareConfigOptions("Greetings.4!", "John")
            {
                IncludeDate = true
            };

            app.UseMyMiddleware(options);
            app.UseMyOtherMiddleware();
        }
    }

    public class MyMiddlewareConfigOptions
    {
        string _greetingTextFormat = "<h1>{0} from {1}{2}</h1>";

        public MyMiddlewareConfigOptions(string greeting, string greeter)
        {
            GreetingText = greeting;
            Greeter = greeter;
            Date = DateTime.Now;
        }

        public string GreetingText { get; set; }

        public string Greeter { get; set; }

        public DateTime Date { get; set; }

        public bool IncludeDate { get; set; }

        public string GetGreeting()
        {
            string dateText = "";
            if (IncludeDate)
            {
                dateText = $" on {Date.ToShortDateString()}";
            }
            return string.Format(_greetingTextFormat, GreetingText, Greeter, dateText);
        }
    }

    public class MyMiddlewareComponent
    {
        readonly AppFunc _next;

        readonly MyMiddlewareConfigOptions _options;

        public MyMiddlewareComponent(AppFunc next, MyMiddlewareConfigOptions options)
        {
            _next = next;
            _options = options;
        }

        public async Task Invoke(IDictionary<string, object> environment)
        {
            IOwinContext context = new OwinContext(environment);

            await context.Response.WriteAsync(_options.GetGreeting());
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
            await context.Response.WriteAsync("<h1>Hello from My Second.4 Middleware</h1>");
            await _next.Invoke(environment);
        }
    }
}
using System;
using Microsoft.Owin;
using Owin;
using OWinApp02;

[assembly: OwinStartup(typeof(Startup))]

namespace OWinApp02
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseErrorPage();
            app.Run(context =>
            {
                if (context.Request.Path ==  new PathString("/fail"))
                {
                    throw new Exception("Random exception");
                }
                context.Response.ContentType = "text/plain";
                return context.Response.WriteAsync("Hello, world.");
            });
        }
    }
}

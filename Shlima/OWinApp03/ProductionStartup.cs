using System;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(OWinApp03.ProductionStartup))]

namespace OWinApp03
{
    public class ProductionStartup
    {
        public void Configuration(IAppBuilder app)
        {
            app.Run(context =>
            {
                string t = DateTime.Now.Millisecond.ToString();
                return context.Response.WriteAsync(t + " Production OWIN App");
            });
        }
    }
}

using System;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(OWinApp03.TestStartup))]

namespace OWinApp03
{
    public class TestStartup
    {
        public void Configuration(IAppBuilder app)
        {
            app.Run(context =>
            {
                string t = DateTime.Now.Millisecond.ToString();
                return context.Response.WriteAsync(t + " Test OWIN App");
            });
        }
    }
}

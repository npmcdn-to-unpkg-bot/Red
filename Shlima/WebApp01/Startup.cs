using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApp01.Startup))]
namespace WebApp01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

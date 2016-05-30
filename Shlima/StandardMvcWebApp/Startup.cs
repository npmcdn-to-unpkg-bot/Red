using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StandardMvcWebApp.Startup))]
namespace StandardMvcWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

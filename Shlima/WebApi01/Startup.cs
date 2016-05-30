using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(WebApi01.Startup))]

namespace WebApi01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

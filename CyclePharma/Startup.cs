using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CyclePharma.Startup))]
namespace CyclePharma
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

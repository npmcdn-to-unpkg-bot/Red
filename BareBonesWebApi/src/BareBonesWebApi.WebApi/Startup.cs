using System.Web.Http;
using Owin;

namespace BareBonesWebApi.WebApi
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();
            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute("Default", "{controller}", new { controller = "Status" });
            app.UseWebApi(config);
        }
    }
}

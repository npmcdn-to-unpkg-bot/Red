using System.Web.Http;
using Microsoft.Owin;
using Ninject;
using Owin;
using Shlima.WebApi;

[assembly: OwinStartup(typeof(Startup))]
namespace Shlima.WebApi
{
    public class Startup
    {
        public static IKernel Container { get; private set; }

        public void Configuration(IAppBuilder appBuilder)
        {
            var config = new HttpConfiguration();

            config.Routes.MapHttpRoute(
                "Default", 
                "{controller}/{id}", 
                new
                {
                    id = RouteParameter.Optional
                });

            Container = new StandardKernel();
            config.DependencyResolver = new NinjectDependencyResolver(Container);

            appBuilder.UseWebApi(config);
        }
    }
}
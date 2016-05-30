using System.Web.Http;
using Api;
using Microsoft.Owin;
using Ninject;
using Owin;
using Ninject.Extensions.Conventions;

[assembly: OwinStartup(typeof(Startup))]
namespace Api
{
    public class Startup
    {
        public static IKernel Container { get; private set; }

        public void Configuration(IAppBuilder appBuilder)
        {
            var config = new HttpConfiguration();

            config.Routes.MapHttpRoute(
                "Default", "{controller}/{id}", new { id = RouteParameter.Optional });

            Container = new StandardKernel();
            Container.Bind(x => x.FromThisAssembly().SelectAllClasses().BindAllInterfaces());
            config.DependencyResolver = new NinjectDependencyResolver(Container);

            appBuilder.UseWebApi(config);
        }
    }  
}
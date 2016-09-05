using System.Web.Http;
using System.Web.Http.ExceptionHandling;
using Abc.WebApi.Exceptions;
using Owin;

namespace Abc.WebApi
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();
            config.MapHttpAttributeRoutes();
            config.Services.Replace(typeof(IExceptionHandler), new GlobalExceptionHandler());
            app.UseWebApi(config);
        }
    }
}

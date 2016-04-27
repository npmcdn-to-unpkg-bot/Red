using System.Threading.Tasks;
using Microsoft.Owin;
using Microsoft.Owin.Logging;

namespace Owin.Logging
{
    public class MyOtherMiddlewareComponent : OwinMiddleware
    {
        private readonly ILogger _logger;

        public MyOtherMiddlewareComponent(OwinMiddleware next, IAppBuilder app)
            : base(next)
        {
            _logger = app.CreateLogger<MyMiddlewareComponent>();
        }

        public override async Task Invoke(IOwinContext context)
        {
            _logger.WriteVerbose("Writing message.");
            await context.Response.WriteAsync("<h1>Hello from My Second Middleware</h1>");
            _logger.WriteVerbose("Message written.");
        }
    }
}

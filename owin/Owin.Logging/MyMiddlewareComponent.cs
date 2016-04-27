using System.Threading.Tasks;
using Microsoft.Owin;
using Microsoft.Owin.Logging;

namespace Owin.Logging
{
    public class MyMiddlewareComponent : OwinMiddleware
    {
        private readonly ILogger _logger;

        readonly MyMiddlewareConfigOptions _options;

        public MyMiddlewareComponent(OwinMiddleware next, IAppBuilder app, MyMiddlewareConfigOptions options)
            : base(next)
        {
            _logger = app.CreateLogger<MyMiddlewareComponent>();
            _options = options;
        }

        public override async Task Invoke(IOwinContext context)
        {
            _logger.WriteVerbose("Writing greeting.");
            await context.Response.WriteAsync(_options.GetGreeting());
            _logger.WriteVerbose("Greeting written.");

            _logger.WriteVerbose("Calling next middleware component");
            await Next.Invoke(context);
            _logger.WriteVerbose("Next middleware component called.");
        }
    }
}

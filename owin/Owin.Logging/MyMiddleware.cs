using System.Threading.Tasks;
using Microsoft.Owin;
using Microsoft.Owin.Logging;

namespace Owin.Logging
{
    public class MyMiddleware : OwinMiddleware
    {
        private readonly ILogger _logger;

        readonly MyMiddlewareOptions _options;

        public MyMiddleware(OwinMiddleware next, IAppBuilder app, MyMiddlewareOptions options)
            : base(next)
        {
            _logger = app.CreateLogger<MyMiddleware>();
            _options = options;
        }

        public override Task Invoke(IOwinContext context)
        {
            _logger.WriteVerbose("Log message.");

            return context.Response.WriteAsync(_options.Message);
        }
    }
}

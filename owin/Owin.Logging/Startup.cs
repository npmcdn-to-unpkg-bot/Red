using Microsoft.Owin.Logging;

namespace Owin.Logging
{
    public class Startup
    {
        private ILogger _logger;

        public void Configuration(IAppBuilder app)
        {
            _logger = app.CreateLogger<Startup>();

            _logger.WriteError("Application starting.");

            var options = new MyMiddlewareOptions
            {
                Message = "Hello World"
            };

            app.Use<MyMiddleware>(app, options);

            _logger.WriteError("Application started.");
        }
    }
}
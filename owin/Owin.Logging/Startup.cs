using Microsoft.Owin.Logging;

namespace Owin.Logging
{
    public class Startup
    {
        private ILogger _logger;

        public void Configuration(IAppBuilder app)
        {
            _logger = app.CreateLogger<Startup>();

            var options = new MyMiddlewareConfigOptions("Hello World", "Richard")
            {
                IncludeDate = true
            };

            _logger.WriteVerbose("Configuring application.");
            app.Use<MyMiddlewareComponent>(app, options);
            app.Use<MyOtherMiddlewareComponent>(app);
            _logger.WriteVerbose("Application configured.");
        }
    }
}
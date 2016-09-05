using System;
using System.Diagnostics.CodeAnalysis;
using Coypu;
using Coypu.Drivers;
using Coypu.Drivers.Selenium;
using TechTalk.SpecFlow;

namespace WebTests.Specs.Steps
{
    [Binding]
    public class Step
    {
        [Then(@"I can navigate to google")]
        [SuppressMessage("ReSharper", "InconsistentNaming")]
        public void ICanNavigateToGoogle()
        {
            

            var session = new BrowserSession(new SessionConfiguration
            {
                Driver = typeof(SeleniumWebDriver),
                Browser = Browser.Chrome,
                AppHost = "localhost",
                Port = 8093,
                SSL = false,
                Timeout = TimeSpan.FromSeconds(5),
                RetryInterval = TimeSpan.FromSeconds(0.1)
            });
            session.Visit(".well-known/openid-configuration");
            session.Dispose();

        }
    }
}

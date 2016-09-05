using System;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using Coypu;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using CTM.UITestChassis.Support;

namespace Specflow_Test_Project1
{
    [Binding]
    public class Hooks
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
            var runAllAgainstSauceLabs = Environment.GetEnvironmentVariable("RunAgainstSauceLabs") != null;
            var runSelectedAgainstSauceLabs = ScenarioContext.Current.ScenarioInfo.Tags.Any(t => t.Equals("saucelabs"));
            var mobileOnlyTest = ScenarioContext.Current.ScenarioInfo.Tags.Any(t => t.Equals("mobileonly"));

            if (runAllAgainstSauceLabs || runSelectedAgainstSauceLabs)
            {
                BrowserSessionFactory.StartBrowserInstanceFromConfig();
            }
            else
            {
                var mobileRun = Environment.GetEnvironmentVariable("MobileRun") ?? (mobileOnlyTest ? "true" : null);
                BrowserSessionFactory.StartBrowserInstanceForLocalRun(string.IsNullOrEmpty(mobileRun) ? "desktop" : "mobile");
            }
        }

        [AfterScenario]
        public void AfterScenario()
        {
            var runAllAgainstSauceLabs = Environment.GetEnvironmentVariable("RunAgainstSauceLabs") != null;
            var runSelectedAgainstSauceLabs = ScenarioContext.Current.ScenarioInfo.Tags.Any(t => t.Equals("saucelabs"));
            var browserSession = ScenarioContext.Current["_browserSession"] as BrowserSession;

            var remoteDriver = browserSession.Native as CustomRemoteWebDriver;
            if (remoteDriver != null)
            {
                var remoteJobId = remoteDriver.GetSessionId();
                var testPassed = ScenarioContext.Current.TestError == null;
                SauceLabsManager.UpdateJobStatus(remoteJobId, testPassed);
            }

            // Take screenshots for failing tests when not running against SauceLabs
            var driver = browserSession.Native as ChromeDriver;
            if (driver != null && !runSelectedAgainstSauceLabs && !runAllAgainstSauceLabs)
            {
                if (ScenarioContext.Current.TestError != null)
                {
                    var screenshotDriver = driver as ITakesScreenshot;
                    if (screenshotDriver != null)
                    {
                        if (!Directory.Exists("FailingScreenshot"))
                            Directory.CreateDirectory("FailingScreenshot");

                        var screenShot = driver.GetScreenshot();
                        screenShot.SaveAsFile("FailingScreenshot\\" + ScenarioContext.Current.ScenarioInfo.Title + ".png", ImageFormat.Png);
                    }
                }
            }

            browserSession.Dispose();
        }
    }
}

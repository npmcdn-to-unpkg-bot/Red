using NUnit.Framework;
using Specflow_Test_Project1.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Specflow_Test_Project1.StepDefinitions
{
    [Binding]
    public sealed class CommonSteps
    {
        private readonly SiteLandingPage _siteLandingPage;
        private readonly CompareMeerkatsPage _compareMeerkatsPage;

        public CommonSteps()
        {
            _siteLandingPage = new SiteLandingPage();
            _compareMeerkatsPage = new CompareMeerkatsPage();
        }

        [Given(@"I visit the comparethemeerkat site")]
        public void GivenIVisitTheComparetheMeerkatSite()
        {
            _siteLandingPage.Visit();
        }

        [When(@"I select the Compare Meerkats menu link")]
        public void WhenISelectTheCompareMeerkatsMenuLink()
        {
            _siteLandingPage.CompareMeerkatsMenuLink.Click();
        }

        [Then(@"I am taken to the Compare Meerkats page")]
        public void ThenIAmTakenToTheCompareMeerkatsPage()
        {
            Assert.That(_compareMeerkatsPage.IsLoaded());
        }
    }
}

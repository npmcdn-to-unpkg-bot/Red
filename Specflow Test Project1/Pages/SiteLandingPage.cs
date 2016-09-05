using CTM.UITestChassis.Elements;
using CTM.UITestChassis.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Specflow_Test_Project1.Pages
{
    public class SiteLandingPage : Page
    {
        public Link CompareMeerkatsMenuLink;

        public SiteLandingPage()
        {
            CompareMeerkatsMenuLink = new Link(BrowserSession, "compare-meerkats");
        }

        public void Visit()
        {
            BrowserSession.Visit("/");
            BrowserSession.WaitUntil(() => CompareMeerkatsMenuLink.IsPresent());
        }
    }
}

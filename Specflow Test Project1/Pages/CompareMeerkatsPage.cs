using CTM.UITestChassis.Elements;
using Specflow_Test_Project1.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Specflow_Test_Project1.Pages
{
    public class CompareMeerkatsPage : Page
    {
        public CompareMaBobPanel CompareMaBob;

        public CompareMeerkatsPage()
        {
            CompareMaBob = new CompareMaBobPanel(BrowserSession, "div.comparemabobPanel", SelectorType.Css);
        }

        public bool IsLoaded()
        {
            return CompareMaBob.IsPresent();
        }
    }
}

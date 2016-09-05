using Coypu;
using CTM.UITestChassis.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Specflow_Test_Project1.Elements
{
    public class CompareMaBobPanel : BaseElement
    {
        public CompareMaBobPanel(BrowserSession session, string elementText, SelectorType type)
            : base(session, elementText, type)
        {
        }
    }
}

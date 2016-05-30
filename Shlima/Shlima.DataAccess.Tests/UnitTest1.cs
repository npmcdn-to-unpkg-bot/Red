using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Shlima.DataAccess.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            using (var context = new Shlima.DataAccess.Context())
            {
                var count = context.ShoppingLists.Count();
            }
        }
    }
}

using CashBoardAutomation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CashBoardTests
{
    [TestClass]
    public class HomePageTests : CashBoardTest
    {
        [TestMethod]
        public void UserCanNavigateToHomepage()
        {
            Assert.IsTrue(HomePage.IsAt, "Failed to navigate");
        }

    }
}

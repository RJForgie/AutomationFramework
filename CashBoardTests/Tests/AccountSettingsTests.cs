using CashBoardAutomation;
using CashBoardAutomation.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CashBoardTests 
{
    [TestClass]
    public class AccountSettingsTests : CashBoardTest
    {
        [TestMethod]
        public void UserCanNavigateToAccountSettingsPage()
        {
            AccountSettingsPage.GoTo();
            Assert.IsTrue(AccountSettingsPage.IsAt, "Failed to navigate");
        }
    }
}

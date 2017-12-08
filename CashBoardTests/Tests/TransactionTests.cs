using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CashBoardAutomation;

namespace CashBoardTests
{
    [TestClass]
    public class TransactionTests : CashBoardTest
    {
        [TestMethod]
        public void UserCanNavigateToAllTransactionsPage()
        {
            AllTransactionsPage.GoTo();
            Assert.IsTrue(AllTransactionsPage.IsAt, "Failed to navigate");
        }
    }
}

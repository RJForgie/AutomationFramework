using CashBoardAutomation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CashBoardTests
{
    [TestClass]
    public class CreateTransactionTests : CashBoardTest
    {

        [TestMethod]
        public void UserCanNavigateToNewTransactionPage()
        {
            HomePage.GoTo();
            NewTransactionPage.GoTo();
            Assert.IsTrue(NewTransactionPage.IsAt, "Failed to navigate");
        }

        [TestMethod]
        public void UserCanCreateTransaction()
        {
            NewTransactionPage.GoTo();
            NewTransactionPage.CreateTransaction(13.58m).Submit();
            Assert.IsTrue(ConfirmationPage.IsAt, "Failed to create transaction");

            //Cleanup
            ConfirmationPage.ReturnToAllTransactions();
            AllTransactionsPage.DeleteLastTransaction();
        }

        [TestMethod]
        public void NewTransactionShowsUp()
        {
            AllTransactionsPage.GoTo();
            AllTransactionsPage.StoreTransactionCount();
            NewTransactionPage.GoTo();
            NewTransactionPage.CreateTransaction(15.44m).Submit();
            ConfirmationPage.ReturnToAllTransactions();

            Assert.AreEqual(AllTransactionsPage.PrevTransactionCount + 1, AllTransactionsPage.CurrentTransactionCount, "Incorrect transaction count");

            //Cleanup
            AllTransactionsPage.DeleteLastTransaction();
        }
    }
}

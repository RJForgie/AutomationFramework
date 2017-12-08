using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashBoardAutomation
{
    public class NewTransactionPage
    {
        public static bool IsAt
        {
            get
            {
                var h2s = Driver.Instance.FindElements(By.TagName("h2"));
                if (h2s.Count > 0)
                    return h2s[0].Text == "Enter new transaction details";
                return false;
            }
        }

        public static void GoTo()
        {
            var navNewTransaction = Driver.Instance.FindElement(By.XPath("//*[@id='secondnav']/li[3]/a"));
            navNewTransaction.Click();
        }

        public static CreateTransactionCommand CreateTransaction(decimal value)
        {
            return new CreateTransactionCommand(value);
        }
    }

    public class CreateTransactionCommand
    {
        private readonly decimal value;

        public CreateTransactionCommand(decimal value)
        {
            this.value = value;
        }

        public void Submit()
        {
            Driver.Instance.FindElement(By.Id("value-field")).SendKeys((value.ToString()));
            Driver.Instance.FindElement(By.ClassName("button")).Click();
        }
    }
}

using CashBoardAutomation.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashBoardAutomation
{
    public class AllTransactionsPage     
    {
        private static int lastCount;

        public static int PrevTransactionCount
        {
            get { return lastCount; }
        }

        public static int CurrentTransactionCount {
            get { return GetTransactionCount(); }
        }
        public static bool IsAt
        {
            get
            {
                var h2s = Driver.Instance.FindElements(By.TagName("h2"));
                if (h2s.Count > 0)
                    return h2s[0].Text == "All transactions";
                return false;
            }
        }


        public static void GoTo()
        {
            LeftNavigation.AllTransactions.Select();
        }

        public static void StoreTransactionCount()
        {
            lastCount = GetTransactionCount();
            
        }

        private static int GetTransactionCount()
        {
            var lastCount = Driver.Instance.FindElements(By.CssSelector("tr")).Count;
            return lastCount;
        }

        public static void DeleteLastTransaction()
        {
            System.Threading.Thread.Sleep(2000);
            var lastTransactionIndex = CurrentTransactionCount;
            var tableCell = Driver.Instance.FindElement(By.CssSelector($".newtable tr:nth-child({lastTransactionIndex}) td:nth-child(7) .button"));
            Actions actions = new Actions(Driver.Instance);
            actions.MoveToElement(tableCell);
            System.Threading.Thread.Sleep(2000);
            tableCell.Click();
        }
    }
}

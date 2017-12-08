using CashBoardAutomation.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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
            //var tableRow = Driver.Instance.FindElement(By.XPath($"(//*[class='newtable'])[{CurrentTransactionCount}]"));
            //var tableCell = tableRow.FindElement(By.XPath("//td[]:)"));
            //*[@id="main-content"]/div/table/tbody/tr[18]/td[7]
            var lastTransactionIndex = CurrentTransactionCount;
            var tableCell = Driver.Instance.FindElement(By.CssSelector("//.newtable tbody tr:nth-child(1) td:nth-child(7)"));
            tableCell.FindElement(By.ClassName("input#button")).Click();
            

        }
    }
}

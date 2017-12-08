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
    }
}

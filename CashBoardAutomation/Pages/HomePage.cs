using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashBoardAutomation
{
    public class HomePage
    {
        public static bool IsAt
        {
            get
            {
                var h2s = Driver.Instance.FindElements(By.TagName("h2"));
                if (h2s.Count > 0)
                    return h2s[0].Text == "Welcome to MoneyCashBoard";
                return false;
            }
        }

        public static void GoTo()
        {
           Driver.Instance.Navigate().GoToUrl("https://ruby-money-cash-board.herokuapp.com/");
        }
    }
}

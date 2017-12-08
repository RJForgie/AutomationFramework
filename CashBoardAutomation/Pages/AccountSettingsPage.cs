using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashBoardAutomation.Pages
{
    public class AccountSettingsPage
    {
        public static bool IsAt
        {
            get
            {
                var h2s = Driver.Instance.FindElements(By.TagName("h2"));
                if (h2s.Count > 0)
                    return h2s[0].Text == "Budget settings";
                return false;
            }
        }

        public static void GoTo()
        {
            LeftNavigation.AccountSettings.Select();
        }
    }
}

using System;

namespace CashBoardAutomation.Pages
{
    internal class LeftNavigation
    {

        public class AccountSettings
        {
            public static void Select()
            {
                MenuSelector.Select(4);
            }
        }

        public class AllTransactions
        {
            public static void Select()
            {
                MenuSelector.Select(2);
            }
        }
    }
}

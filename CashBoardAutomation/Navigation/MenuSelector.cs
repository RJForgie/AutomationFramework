using OpenQA.Selenium;

namespace CashBoardAutomation.Pages
{
    internal class MenuSelector
    {
        public static void Select(int menuId)
        {
            Driver.Instance.FindElement(By.XPath($"//*[@id='secondnav']/li[{menuId}]/a")).Click();
        }
    }
}

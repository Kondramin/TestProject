using OpenQA.Selenium;
using System.Threading;

namespace TestProject1.PageObjects.Bookingcom
{
    public class CashChangePageObject
    {
        private readonly IWebDriver _webDriver;

        private readonly By _EuroCashButton = By.XPath("//div[@class='bui-traveller-header__currency']");


        public CashChangePageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public MainPageObject SwichToEuroCash()
        {
            Thread.Sleep(1000);
            _webDriver.FindElement(_EuroCashButton).Click();

            return new MainPageObject(_webDriver);
        }
    }
}

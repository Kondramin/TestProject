using OpenQA.Selenium;
using System.Threading;

namespace TestProject1.PageObjects.Bookingcom
{
    public class ChangeLanguagePageObject
    {
        private readonly IWebDriver _webDriver;

        private readonly By _ruLanguageButton = By.XPath("//a[@data-lang='ru']");

        public ChangeLanguagePageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public MainPageObject ClichOnRuLanguageButton()
        {
            Thread.Sleep(1000);
            _webDriver.FindElement(_ruLanguageButton).Click();

            return new MainPageObject(_webDriver);
        }
    }
}

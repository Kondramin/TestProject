using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.PageObjects.Bookingcom
{
    public class ManageAccountPageObject
    {
        private readonly IWebDriver _webDriver;

        private readonly By _accountSettingsHeader = By.XPath("//*[@id='root']/div/div/div[1]/div/div/nav/div/div[1]");

        public ManageAccountPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public string GetHeaderAccountSettings()
        {
            var result = _webDriver.FindElement(_accountSettingsHeader).Text;

            return result;
        }
    }
}

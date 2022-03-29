using OpenQA.Selenium;
using System;
using System.Threading;

namespace TestProject1.PageObjects.Bookingcom
{
    public class MainPageObject
    {
        private readonly IWebDriver _webDriver;

        private readonly By _pageMeta = By.XPath("//html[@lang]");
        private readonly By _changeLanguageButton = By.XPath("//button[@data-modal-id='language-selection']");
        private readonly By _cashValueButton = By.XPath("//span[@aria-hidden='true']");

        private readonly By _cityFilterField = By.XPath("//input[@type='search']");
        private readonly By _firstDataFilterField = By.XPath("//span[@class='sb-date-field__icon sb-date-field__icon-btn bk-svg-wrapper calendar-restructure-sb']");
        private readonly By _lastDataFilterField = By.XPath("//input[@type='search']");


        public MainPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }


        public string GetPageLaguage()
        {
            var meta = _webDriver.FindElement(_pageMeta).Text;

            if (meta.Contains("is English")) return "English";

            if (meta.Contains("is Russian")) return "Russian";

            return "language unknown";
        }

        public ChangeLanguagePageObject PushChangeLanguageButton()
        {
            _webDriver.FindElement(_changeLanguageButton).Click();

            return new ChangeLanguagePageObject(_webDriver);
        }

        public string GetCashValue()
        {
            return _webDriver.FindElement(_cashValueButton).Text;
        }

        public CashChangePageObject PushCashValueButton()
        {
            _webDriver.FindElement(_cashValueButton).Click();

            return new CashChangePageObject(_webDriver);
        }

        public void InpudCityInFilterField(string city)
        {
            _webDriver.FindElement(_cityFilterField).SendKeys(city);
        }

        public void InputFistDataInFilter(DateTime firstData)
        {
            //TODO: A.K. Continue from there

            _webDriver.FindElement(_firstDataFilterField).SendKeys(firstData.ToString());
        }


    }
}

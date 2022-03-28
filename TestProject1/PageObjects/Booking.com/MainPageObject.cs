using OpenQA.Selenium;

namespace TestProject1.PageObjects.Bookingcom
{
    public class MainPageObject
    {
        private readonly IWebDriver _webDriver;

        private readonly By _pageMeta = By.XPath("//html[@lang]");
        private readonly By _changeLanguageButton = By.XPath("//button[@data-modal-id='language-selection']");
        private readonly By _cashValueButton = By.XPath("//span[@aria-hidden='true']");


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
    }
}

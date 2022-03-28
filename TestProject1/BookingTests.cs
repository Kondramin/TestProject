using NUnit.Framework;
using OpenQA.Selenium;
using TestProject1.DataForTests;
using TestProject1.PageObjects.Bookingcom;

namespace TestProject1
{
    public class Tests
    {
        private IWebDriver _webDriver;

        


        [SetUp]
        public void Setup()
        {
            _webDriver = new OpenQA.Selenium.Chrome.ChromeDriver();
            _webDriver.Navigate().GoToUrl(BookingTestData.Url);
            _webDriver.Manage().Window.Maximize();

        }

        
        [Test]
        public void ChangelanguageTest()
        {
            var mainPage = new MainPageObject(_webDriver);

            var defaultLaguage = mainPage.GetPageLaguage();
            
            mainPage
                .PushChangeLanguageButton()
                .ClichOnRuLanguageButton();

            var swichedLanguage = mainPage.GetPageLaguage();

            Assert.AreNotEqual(defaultLaguage, swichedLanguage);
        }

        [Test]
        public void ChangeCashValue()
        {
            var mainPage = new MainPageObject(_webDriver);

            var defaultCashValue = mainPage.GetCashValue();

            mainPage
                .PushCashValueButton()
                .SwichToEuroCash();

            var swichedCashValue = mainPage.GetCashValue();


            Assert.AreNotEqual(defaultCashValue, swichedCashValue);
        }

        [TearDown]
        public void TearDown()
        {
            _webDriver.Quit();
        }
    }
}
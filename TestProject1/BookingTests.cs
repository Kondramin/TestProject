using NUnit.Framework;
using OpenQA.Selenium;
using TestProject1.DataForTests;
using TestProject1.PageObjects.Bookingcom;

namespace TestProject1
{
        /*
         * Test to check can't be implemented because for it realization need
         * email where need to get a link to SingIn on Booking
         */
    public class Tests
    {
        private IWebDriver _webDriver;
        
        private MainPageObject _mainPageObject;
        
        


        [SetUp]
        public void Setup()
        {
            _webDriver = new OpenQA.Selenium.Chrome.ChromeDriver();
            _webDriver.Navigate().GoToUrl(BookingTestData.Url);
            _webDriver.Manage().Window.Maximize();

            _mainPageObject = new MainPageObject(_webDriver);
        }

        [Test]
        public void ChangelanguageTest()
        {
            var defaultLaguage = _mainPageObject.GetPageLaguage();

            _mainPageObject
                .PushChangeLanguageButton()
                .ClichOnRuLanguageButton();

            var swichedLanguage = _mainPageObject.GetPageLaguage();

            Assert.AreNotEqual(defaultLaguage, swichedLanguage);
        }

        [Test]
        public void ChangeCashValue()
        {

            var defaultCashValue = _mainPageObject.GetCashValue();

            _mainPageObject
                .PushCashValueButton()
                .SwichToEuroCash();

            var swichedCashValue = _mainPageObject.GetCashValue();


            Assert.AreNotEqual(defaultCashValue, swichedCashValue);
        }

        [Test]
        public void FiltestTest()
        {

        }

        [TearDown]
        public void TearDown()
        {
            _webDriver.Quit();
        }
    }
}
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace SeleniumAdvanced
{
    [TestFixture]
    public class CareersMenuTests
    {
        private IWebDriver _driver { get; set; }
        private const string EpamHomePageUrl = "https://www.epam.com/";
        private CookieHelper _cookieHelper { get; set; }

        [SetUp]
        public void SetupBrowser()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(40);
            _driver.Navigate().GoToUrl(EpamHomePageUrl);
            _cookieHelper = new CookieHelper(_driver);
            _cookieHelper.AcceptCookies();
        }

        [Test]
        public void VerifyThatjobListingsPageIsOpened()
        {
            // Step 1: Hover on Careers button
            var careersButton = _driver.FindElement(By.XPath("//*[@href='/careers' and contains(@class, 'top-navigation__item-link')]"));
            Actions action = new Actions(_driver);
            action.MoveToElement(careersButton).Perform();

            // Step 2: Click "Join Our Team" link
            _driver.FindElement(By.XPath("//a[contains(@class, 'top-navigation__main-link') and @href='/careers/job-listings']")).Click();

            // Step 3: Check that the correct URL is opened
            Assert.AreEqual("https://www.epam.com/careers/job-listings", _driver.Url);

        }


        [TearDown]
        public void TearDown()
        {
            _driver.Close();
            _driver.Quit();
        }

    }
}


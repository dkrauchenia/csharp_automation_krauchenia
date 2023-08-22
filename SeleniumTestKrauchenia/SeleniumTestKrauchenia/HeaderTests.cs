using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTestKrauchenia
{
    [TestFixture]
    public class HeaderTests
    {
        private IWebDriver _driver { get; set; }
        private const string _epamHomePageUrl = "https://www.epam.com/";
        public CookieHelper _cookieHelper { get; set; }

        [SetUp]
        public void SetupBrowser()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);
            _driver.Navigate().GoToUrl(_epamHomePageUrl);
            _cookieHelper = new CookieHelper(_driver);
            _cookieHelper.AcceptCookies();
        }

        [TearDown]
        public void CloseBrowser()
        {
            _driver.Quit();
        }

        [Test]
        public void HeaderElementIsPresent()
        {
            IWebElement headerElement = _driver.FindElement(By.ClassName("header__content"));

            Assert.IsNotNull(headerElement, "Header should be present on the page");
        }
    }
}

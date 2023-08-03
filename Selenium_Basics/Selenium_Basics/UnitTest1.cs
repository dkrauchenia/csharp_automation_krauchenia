using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium_Basics
{
    public class EpamTests
    {
        private IWebDriver driver { get; set; }
        private const string EpamHomePageUrl = "https://www.epam.com/";
        private const string EpamHowWeDoItUrl = "https://www.epam.com/how-we-do-it";
        private const string EpamOurWorkUrl = "https://www.epam.com/our-work";

        [SetUp]
        public void SetupBrowser()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }


        [Test]
        public void TestEpamHomePage()
        {
            //Step 1. Navigate to Epam homepage
            driver.Navigate().GoToUrl(EpamHomePageUrl);
            Thread.Sleep(5000);

            //Step 2. Check that the correct page is opened
            Assert.AreEqual(EpamHomePageUrl, driver.Url);
        }

        [Test]
        public void TestEpamHowWeDoItPage()
        {
            //Step 1. Navigate to Epam How We Do It page
            driver.Navigate().GoToUrl(EpamHowWeDoItUrl);
            Thread.Sleep(5000);

            //Step 2.Navigate to Epam Our Work page
            driver.Navigate().GoToUrl(EpamOurWorkUrl);
            Thread.Sleep(5000);

            //Step 3.Reload the page
            driver.Navigate().Refresh();
            Thread.Sleep(5000);

            //Step 4. Go back to the previous page (How We Do It)
            driver.Navigate().Back();
            Thread.Sleep(5000);

            //Step 5. Check that the correct page (How We Do It) is opened
            Assert.AreEqual(EpamHowWeDoItUrl, driver.Url);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
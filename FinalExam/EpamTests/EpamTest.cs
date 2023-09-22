using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedTests
{
    public class EpamTest
    {
        private IWebDriver _driver;
        private const string _baseUrl = "https://www.epam.com/";

        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }

        [Test]
        public void VerifyThatLearnMoreButtonIsPresentOnCareersPage()
        {
            _driver.Navigate().GoToUrl(_baseUrl);

            IWebElement careersLink = _driver.FindElement(By.XPath("//a[contains(@href, '/careers')]"));
            careersLink.Click();

            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            wait.Until(driver => ((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").Equals("complete"));

            IWebElement learnMoreButton = _driver.FindElement(By.XPath("//a[@class='button-ui-23 btn-focusable' and contains(@href, 'epam-launches-ukraine-assistance-fund')]"));

            Assert.That(learnMoreButton.Displayed, Is.True, "The 'Learn More' button is not displayed");
        }

    }
}

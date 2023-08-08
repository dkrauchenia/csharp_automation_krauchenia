using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;

namespace Selenium_Basics
{
    public class EpamHeaderPanelTest
    {
        private IWebDriver _driver { get; set; }
        private const string EpamHomePageUrl = "https://www.epam.com/";
        


        [SetUp]
        public void SetupBrowser()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(20);
        }

        [Test]
        public void VerifyThatAvailableLocationsArePresent()
        {
            // Step 1. Go to the EPAM home page
            _driver.Navigate().GoToUrl(EpamHomePageUrl);
            AcceptCookiePolicyIfPresent();

            // Step 2. Click on the "Careers" button
            var careersButton = _driver.FindElement(By.XPath("//*[@href='/careers' and contains(@class, 'top-navigation__item-link')]"));
            careersButton.Click();

            // Step 3. Click "Find Your Dream Job" link
            var findJobButton = _driver.FindElement(By.LinkText("Find Your Dream Job"));

            Actions action = new Actions(_driver);
            action.MoveToElement(findJobButton).Build().Perform();
            findJobButton.Click();

            // Step 4. Scroll down to the tabs and verify three tabs: "Americas", "EMEA", and "APAC" are present in Our Locations section
            var tabsContainer = _driver.FindElement(By.ClassName("js-tabs-controls"));
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            var americasTab = tabsContainer.FindElement(By.XPath(".//a[text()='AMERICAS']"));
            var emeaTab = tabsContainer.FindElement(By.XPath(".//a[text()='EMEA']"));
            var apacTab = tabsContainer.FindElement(By.XPath(".//a[text()='APAC']"));

            Assert.IsTrue(americasTab.Displayed, "Location is not displayed");
            Assert.IsTrue(emeaTab.Displayed, "Location is not displayed");
            Assert.IsTrue(apacTab.Displayed, "Location is not displayed");
        }

        private void AcceptCookiePolicyIfPresent()
        {

            var acceptButton = _driver.FindElement(By.Id("onetrust-accept-btn-handler"));

            if (acceptButton.Displayed && acceptButton.Enabled)
            {
                acceptButton.Click();
            }
            
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Close();
            _driver.Quit();
        }
    }
}




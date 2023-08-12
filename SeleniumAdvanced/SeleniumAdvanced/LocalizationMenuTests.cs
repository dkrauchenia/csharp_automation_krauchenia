using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAdvanced
{
    public class LocalizationMenuTests
    {
        private IWebDriver _driver { get; set; }
        private const string EpamHomePageUrl = "https://www.epam.com/";
        private WebDriverWait _waiter { get; set; }
        private CookieHelper _cookieHelper { get; set; }

        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl(EpamHomePageUrl);
            _waiter = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));

            _cookieHelper = new CookieHelper(_driver);
            _cookieHelper.AcceptCookies();
        }

        [Test]
        public void TestLocalizationDropdown()
        {
            
            // Step 1. Click on Localizations button on the header panel
            var localizationButton = _driver.FindElement(By.XPath("//button[@class='location-selector__button']"));
            
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)_driver;
            jsExecutor.ExecuteScript("arguments[0].click();", localizationButton);

            var languagePanel = _waiter.Until(driver => driver.FindElement(By.CssSelector(".location-selector__panel")));

            //Step 2. Verify that Verify that actual languages correspond to the expected languages

            // Expected languages list
            List<string> expectedLanguages = new List<string>
            {
                "Global (English)",
                "Hungary (English)",
                "СНГ (Русский)",
                "Česká Republika (Čeština)",
                "India (English)",
                "Україна (Українська)",
                "Czech Republic (English)",
                "日本 (日本語)",
                "中国 (中文)",
                "DACH (Deutsch)",
                "Polska (Polski)"
            };

            // Retreiving actual languages
            IReadOnlyList<IWebElement> languageElements = languagePanel.FindElements(By.CssSelector(".location-selector__item"));
            List<string> actualLanguages = new List<string>();
            foreach (var element in languageElements)
            {
                actualLanguages.Add(element.Text.Trim());
            }

            // Comparing expected and actual languages
            Assert.AreEqual(expectedLanguages, actualLanguages);
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Close();
            _driver.Quit();
        }

    }
}

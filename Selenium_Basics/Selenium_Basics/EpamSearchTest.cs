using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Basics
{
    public class EpamSearchTest
    {
        private IWebDriver _driver { get; set; }
        private const string EpamHomePageUrl = "https://www.epam.com/";



        [SetUp]
        public void SetupBrowser()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(20);
            _driver.Navigate().GoToUrl(EpamHomePageUrl);
            AcceptCookiePolicyIfPresent();
        }

        [Test]
        public void VerifyThatSearchResultsCorrespondToSearchCriteria()
        {

            // Step 1. Click on the Search button in the Header
            var searchButton = _driver.FindElement(By.XPath("//span[contains(@class,'dark-iconheader-search__search-icon')]"));
            searchButton.Click();

            // Step 2. Type word "Automation" in the Search input field
            string WordToSearch = "Automation";
            var searchInput = _driver.FindElement(By.Id("new_form_search"));
            searchInput.SendKeys(WordToSearch);

            // Step 3. Click on the 'Find' button
            var findButton = _driver.FindElement(By.XPath("//*[@class='bth-text-layer']"));
            findButton.Click();
            

            // Step 4. Check that the search page is opened with the correct URL
            Assert.AreEqual($"https://www.epam.com/search?q={WordToSearch}", _driver.Url);

            // Step 5. Verify that Search Results correspond to search criteria
            for (int i = 1; i <= 5; i++)
            {
                string articleXpath = $"//article[@class='search-results__item'][{i}]//a[contains(@class,'search-results__title-link')]";
                string articleText = _driver.FindElement(By.XPath(articleXpath)).Text;
                Assert.That(articleText.Contains(WordToSearch), $"Article {i} does not contain the search word.");
            }

        }

        [Test]
        public void VerifyThatSearchedArticleContainsKeyWords()
        {
            
            // Step 1. Click on the Search button in the Header
            var searchButton = _driver.FindElement(By.XPath("//span[contains(@class,'dark-iconheader-search__search-icon')]"));
            searchButton.Click();

            // Step 2. Type word "Automation" in the Search input field
            List<string> searchWords = new List<string> { "Business", "Analysis" };
            string searchTerm = string.Join(" ", searchWords);
            var searchInput = _driver.FindElement(By.Id("new_form_search"));
            searchInput.SendKeys(searchTerm);

            // Step 3. Click on the 'Find' button
            var findButton = _driver.FindElement(By.XPath("//*[@class='bth-text-layer']"));
            findButton.Click();

            // Step 4. Check that the search page is opened with the correct URL
            string urlTerm = string.Join("+", searchWords);
            Assert.AreEqual($"https://www.epam.com/search?q={urlTerm}", _driver.Url);

            // Step 5. Open the first search result and verify that the title is equal to the title of the first article on the search results page
            var searchResultTitle = _driver.FindElement(By.XPath("//article[@class='search-results__item']//a[contains(@class,'search-results__title-link')]")).Text;

            var searchResultLink = _driver.FindElement(By.ClassName("search-results__title-link"));
            searchResultLink.Click();

            var pageTitle = _driver.FindElement(By.XPath("//div[@class='header_and_download']")).Text;

            Assert.AreEqual(searchResultTitle, pageTitle, "The Titles are different!");
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Close();
            _driver.Quit();
        }

        private void AcceptCookiePolicyIfPresent()
        {

            var acceptButton = _driver.FindElement(By.Id("onetrust-accept-btn-handler"));

            if (acceptButton.Displayed && acceptButton.Enabled)
            {
                acceptButton.Click();
            }

        }
    }
}

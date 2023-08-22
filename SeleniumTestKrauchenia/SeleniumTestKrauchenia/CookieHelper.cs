using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestKrauchenia
{
    public class CookieHelper
    {
        private IWebDriver _driver;

        public CookieHelper(IWebDriver driver)
        {
            _driver = driver;
        }

        public void AcceptCookies()
        {
            var acceptButton = _driver.FindElement(By.Id("onetrust-accept-btn-handler"));
            acceptButton.Click();

        }
    }
}

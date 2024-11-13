using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Utilities
{
    public class WebUtilities
    {
        public IWebDriver Driver { get; set; }

        public WebUtilities(IWebDriver driver)
        {
            Driver = driver;
        }

        public void NavigateToUrl(string url)
        {
            Driver.Navigate().GoToUrl(url);
        }

        public void MaximizeWindow()
        {
            Driver.Manage().Window.Maximize();
        }

        public void WaitForElement(By locator, int timeoutInSeconds = 10)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(timeoutInSeconds));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));
        }
    }
}

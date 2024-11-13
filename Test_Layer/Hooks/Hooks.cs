using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace Test_Layer.Hooks
{
    [Binding]
    public class Hooks
    {
        private IWebDriver _driver;

        [BeforeScenario]
        public void BeforeScenario()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _driver.Quit();
        }
    }
}
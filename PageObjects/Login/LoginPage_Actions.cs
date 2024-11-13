using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
namespace PageObjects.Login
{
    public partial class LoginPage
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
        }

        public void EnterUsername(string username)
        {
            _driver.FindElement(_username).SendKeys(username);
        }

        public void EnterPassword(string password)
        {
            _driver.FindElement(_password).SendKeys(password);
        }

        public void ClickLoginButton()
        {
            _driver.FindElement(_loginButton).Click();
        }
    }
}

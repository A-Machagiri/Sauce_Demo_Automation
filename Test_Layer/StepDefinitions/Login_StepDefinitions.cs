using OpenQA.Selenium;
using TechTalk.SpecFlow;
using PageObjects.Login;

namespace Test_Layer.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        private IWebDriver _driver;
        private LoginPage _loginPage;

        public LoginStepDefinitions(IWebDriver driver)
        {
            _driver = driver;
            _loginPage = new LoginPage(_driver);
        }

        [Given(@"I am on the login page")]
        public void GivenIAmOnTheLoginPage()
        {
            _driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }

        [When(@"I enter valid credentials")]
        public void WhenIEnterValidCredentials()
        {
            _loginPage.EnterUsername("standard_user");
            _loginPage.EnterPassword("secret_sauce");
            _loginPage.ClickLoginButton();
        }

        [When(@"I enter invalid credentials")]
        public void WhenIEnterInvalidCredentials()
        {
            _loginPage.EnterUsername("invalid_user");
            _loginPage.EnterPassword("invalid_password");
            _loginPage.ClickLoginButton();
        }

        [When(@"I enter credentials for a locked-out user")]
        public void WhenIEnterCredentialsForALockedOutUser()
        {
            _loginPage.EnterUsername("locked_out_user");
            _loginPage.EnterPassword("secret_sauce");
            _loginPage.ClickLoginButton();
        }

        [Then(@"I should be redirected to the inventory page")]
        public void ThenIShouldBeRedirectedToTheInventoryPage()
        {
            // Assert page URL or page title
        }

        [Then(@"I should see an error message")]
        public void ThenIShouldSeeAnErrorMessage()
        {
            // Assert error message visibility
        }

        [Then(@"I should see a lockout message")]
        public void ThenIShouldSeeALockoutMessage()
        {
            // Assert lockout message visibility
        }
    }
}
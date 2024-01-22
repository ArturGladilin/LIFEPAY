using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LIFEPAY.PageObjectModels;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;


namespace LIFEPAY.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        private readonly IWebDriver driver;
        private WebDriverWait wait;
        private PageObjectModels.LoginPage loginPage;

        public LoginStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Given(@"the user is on the Login page")]
        public void GivenTheUserIsOnTheLoginPage()
        {
            driver.Url = PageObjectModels.LoginPage.Url;
            loginPage = new LoginPage(driver);
        }

        [Then(@"the page title should be Log in")]
        public void ThenThePageTitleShouldBeLogIn()
        {
            
            loginPage.loginTitleText.Equals(loginPage.loginTitle);
        }

        [When(@"the user enters '(.*)' in the phone field")]
        public void WhenTheUserTryToEntersPhone(string phone)
        {
            loginPage.EnterPhone(phone);
        }

        [When(@"the user enters '(.*)' in the password field")]
        public void WhenTheUserTryToEntersPassword(string password)
        {
            loginPage.EnterPassword(password);
        }

        [When(@"the user clicks on the log in button")]
        public void WhenTheUserClicksOnTheLogInButton()
        {
            loginPage.SubmitButtonClick();
        }
        /*
        [Then(@"the user should get a success message")]
        public void ThenShouldASuccesMessage()
        {
            loginPage.youEnteredText.Equals(loginPage.youEntered);
        }
        */

        [Then(@"the page title should be greeted according to the time")]
        public void ThenThePageGreetingsShow()
        {
            int currentHour = DateTime.Now.Hour;
            if (currentHour >= 6 && currentHour < 12)
            {
                Assert.That(loginPage.greetingText, Is.EqualTo("Доброе утро! 👋🏻"));
            }
            else if (currentHour >= 12 && currentHour < 18)
            {
                Assert.That(loginPage.greetingText, Is.EqualTo("Добрый день! 👋🏻"));
            }
            else
            {
                Assert.That(loginPage.greetingText, Is.EqualTo("Добрый вечер! 👋🏻"));
            }

        }
        
        [When(@"the user clicks on the reset password button")]
        public void WhenTheUserClicksOnTheResetButton()
        {
            loginPage.ResetPassButtonClick();
        }

        [Then(@"the user is on reset password page")]
        public void ThenShouldALinkToTheResetPass()
        {
            string currentURL = driver.Url;
            LoginPage.recoveryUrl.Equals(currentURL);
        }

        [When(@"the user clicks on the sign-up button")]
        public void WhenTheUserClicksOnSignUpButton()
        {
            loginPage.SignUpButtonClick();
        }

        [Then(@"the user is on sign-up page")]
        public void ThenShouldALinkToTheSignUp()
        {
            string currentURL = driver.Url;
            LoginPage.signUpUrl.Equals(currentURL);
        }

        [Then(@"the user should get error message about space charachters")]
        public void ThenShouldAErrorMessageAboutSpaces()
        {
            loginPage.valueCannotBeginOrEndWithASpaceText.Equals(loginPage.valueCannotBeginOrEndWithASpace);
        }

        [Then(@"the user should get error message incorrect phone")]
        public void ThenShouldAErrorMessageAboutIncorrectPhone()
        {
            loginPage.correctPhoneText.Equals(loginPage.correctPhone);
        }

        [Then(@"the user should get error message about not registered namber")]
        public void ThenShouldAErrorMessageAboutNotRegisteredNamber()
        {
            Thread.Sleep(3000);
            loginPage.notRegisteredNamberText.Equals(loginPage.notRegisteredNamber);
        }

        [Then(@"the user should get error message about number must be at least six characters")]
        public void ThenShouldAErrorMessageAboutNumberMustabeAtLeastSixCharacters()
        {
            loginPage.valueMustabeAtLeastSixCharactersText.Equals(loginPage.valueMustabeAtLeastSixCharacters);
        }

        [Then(@"the user should get error message about required field password")]
        public void ThenShouldAErrorMessageAboutRequiredFieldPassword()
        {
            loginPage.requiredFieldPasswordText.Equals(loginPage.requiredFieldPassword);
        }

        [Then(@"the user should get error message about required field phone")]
        public void ThenShouldAErrorMessageAboutRequiredFieldPhone()
        {
            loginPage.requiredFieldPhoneText.Equals(loginPage.requiredFieldPhone);
        }
    }
}

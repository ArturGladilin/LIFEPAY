using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIFEPAY.PageObjectModels
{
    public class LoginPage
    {
        private readonly IWebDriver driver;
        private readonly By phoneField = By.XPath("//input[@type='tel']");
        private readonly By passwordField = By.XPath("//input[@type='password']");
        private readonly By submitButton = By.XPath("/html/body/app-root/app-auth/div/div/div[3]/div[2]/div[2]/app-login/div/div[2]/form/div[3]/lp-ui-button");
        private readonly By passwordReset = By.XPath("//a[@id='restore-pass']");
        private readonly By createNewAcc = By.XPath("//a[@id='signin-lk']");

        public const string Url = "https://my.life-pos.ru/auth/login";
        public const string recoveryUrl = "https://my.life-pos.ru/auth/recovery";
        public const string signUpUrl = "https://my.life-pos.ru/auth/sign-up";

        //public string youEnteredText => driver.FindElement(By.XPath("//allertafterenterlocator")).Text;
        //public string youEntered = "Приветствие при входе в кабинет";
        public string greetingText => driver.FindElement(By.XPath("/html/body/app-root/app-auth/div/div/div[3]/div[2]/div[2]/app-login/div/div[1]/h2")).Text;
        public string loginTitleText => driver.FindElement(By.XPath("//h2[contains(text(),'Зайдите в личный кабинет')]")).Text;
        public string loginTitle= "Зайдите в личный кабинет";
        public string correctPhoneText => driver.FindElement(By.XPath("//small[@class='caption-medium text-danger ng-star-inserted']")).Text;
        public string correctPhone = "Введите телефон в формате +7(911)111-11-11";
        public string notRegisteredNamberText => driver.FindElement(By.XPath("//small[@class='caption-medium text-danger ng-star-inserted']")).Text;
        public string notRegisteredNamber = "Номер не зарегистрирован";
        public string valueCannotBeginOrEndWithASpaceText => driver.FindElement(By.XPath("//small[contains(text(),'Значение не может начинаться и заканчиваться пробе')]")).Text;
        public string valueCannotBeginOrEndWithASpace = "Значение не может начинаться и заканчиваться пробелом";
        public string valueMustabeAtLeastSixCharactersText => driver.FindElement(By.XPath("//small[contains(text(),'Значение должно быть не менее 6 знаков')]")).Text;
        public string valueMustabeAtLeastSixCharacters = "Значение должно быть не менее 6 знаков";
        public string requiredFieldPhoneText => driver.FindElement(By.XPath("//lp-ui-layout-column[1]//div[1]//lp-ui-input[1]//div[1]//div[2]//small[1]")).Text;
        public string requiredFieldPhone= "Обязательно для заполнения";
        public string requiredFieldPasswordText => driver.FindElement(By.XPath("//lp-ui-layout-column[1]//div[1]//lp-ui-input[1]//div[1]//div[2]//small[1]")).Text;
        public string requiredFieldPassword = "Обязательно для заполнения";
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public LoginPage EnterPhone(string phone)
        {
            driver.FindElement(phoneField).SendKeys(phone);
            return this;
        }

        public LoginPage EnterPassword(string password)
        {
            driver.FindElement(passwordField).SendKeys(password);
            return this;
        }

        public LoginPage SubmitButtonClick()
        {
            driver.FindElement(submitButton).Click();
            return this;
        }

        public LoginPage ResetPassButtonClick()
        {
            driver.FindElement(passwordReset).Click();
            return this;
        }

        public LoginPage SignUpButtonClick()
        {
            driver.FindElement(createNewAcc).Click();
            return this;
        }
    }
}
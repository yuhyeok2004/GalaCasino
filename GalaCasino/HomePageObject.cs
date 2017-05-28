using AventStack.ExtentReports;
using NUnit;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace GalaCasino
{
    class HomePageObject : Program
    {
            AssistFunctions assistFunc = new AssistFunctions();
        public HomePageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.ClassName, Using = "1btn_action_login")]
        public IWebElement loginButtonHeader { get; set; }

        [FindsBy(How = How.Id, Using = "userName")]
        public IWebElement userNameField { get; set; }

        [FindsBy(How = How.Id, Using = "password")]
        public IWebElement passwordField { get; set; }

        [FindsBy(How = How.ClassName, Using = "fn-login-btn")]
        public IWebElement loginSubmitButton { get; set; }

        [FindsBy(How = How.ClassName, Using = "btn_action_logout")]
        public IWebElement logoutButtonHeader { get; set; }

        [FindsBy(How = How.ClassName, Using = "btn_action_myaccount")]
        public IWebElement myAccountButtonHeader { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".portlet-title-level .js-replacer-inline")]
        public IWebElement myAccountWelcome { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".field_name_username .error-tooltip")]
        public IWebElement usernameFieldError { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".field_name_password .error-tooltip")]
        public IWebElement passwordFieldError { get; set; }



        public void LoginGood(ExtentTest reporter)
        {
            SetMethods.GoToURL(ExcelLib.ReadData(1, "Galacasino.com"), reporter);
            loginButtonHeader.ClickButton(reporter);
            userNameField.EnterText(ExcelLib.ReadData(1, "userName"), reporter);
            passwordField.EnterText(ExcelLib.ReadData(1, "password"), reporter);
            loginSubmitButton.ClickButton(reporter);
            myAccountButtonHeader.ClickButton(reporter);
            myAccountWelcome.VerifyTextIdentical(ExcelLib.ReadData(1, "user_in2906161_Name"), reporter);
        }

        public void LoginMissingCredentials(ExtentTest reporter)
        {
            SetMethods.GoToURL(ExcelLib.ReadData(1, "Galacasino.com"), reporter);
            loginButtonHeader.ClickButton(reporter);
            loginSubmitButton.ClickButton(reporter);
            usernameFieldError.VerifyTextIdentical(ExcelLib.ReadData(1, "fieldRequired"), reporter);
            passwordFieldError.VerifyTextIdentical(ExcelLib.ReadData(1, "fieldRequired"), reporter);

        }
    }
}

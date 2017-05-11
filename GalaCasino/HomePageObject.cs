﻿using NUnit;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace GalaCasino
{
    class HomePageObject
    {
        public HomePageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.ClassName, Using = "btn_action_login")]
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

        public void LoginGood()
        {
            loginButtonHeader.ClickButton();
            userNameField.EnterText(ExcelLib.ReadData(1, "userName"));
            passwordField.EnterText(ExcelLib.ReadData(1, "password"));
            loginSubmitButton.ClickButton();
            myAccountButtonHeader.ClickButton();
            myAccountWelcome.VerifyTextIdentical(ExcelLib.ReadData(1, "user_in2906161_Name"));
        }
    }
}
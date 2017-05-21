﻿using NUnit;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace GalaCasino
{
    class RapidAPIHPO : Program
    {
        public RapidAPIHPO()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = ".header .profile")]
        public IWebElement loginButtonHeader { get; set; }

        [FindsBy(How = How.Id, Using = "login-email")]
        public IWebElement emailField { get; set; }

        [FindsBy(How = How.Id, Using = "login-password")]
        public IWebElement passwordField { get; set; }

        [FindsBy(How = How.ClassName, Using = "login-button")]
        public IWebElement loginSubmitButton { get; set; }

        [FindsBy(How = How.ClassName, Using = "login-error")]
        public IWebElement loginFailed { get; set; }

        public void LoginGood()
        {
            PropertiesCollection.driver.Navigate().GoToUrl("https://rapidapi.com/");
            loginButtonHeader.ClickButton(test);
            emailField.EnterText("test@test.com");
            passwordField.EnterText("test");
            loginSubmitButton.ClickButton(test);
            loginFailed.VerifyTextIdentical("Incorrect email or password.");
        }
    }
}
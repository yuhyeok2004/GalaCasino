//using AventStack.ExtentReports;
//using NUnit;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Support.PageObjects;
//using System;

//namespace GalaCasino
//{
//    class TestPageObject : Program
//    {
//        AssistFunctions assistFunc = new AssistFunctions();
//        public TestPageObject()
//        {
//            PageFactory.InitElements(PropertiesCollection.driver, this);
//        }

//        [FindsBy(How = How.ClassName, Using = "1btn_action_login")]
//        public IWebElement loginButtonHeader { get; set; }

//        [FindsBy(How = How.Id, Using = "userName")]
//        public IWebElement userNameField { get; set; }

//        [FindsBy(How = How.Id, Using = "password")]
//        public IWebElement passwordField { get; set; }

//        [FindsBy(How = How.ClassName, Using = "fn-login-btn")]
//        public IWebElement loginSubmitButton { get; set; }

//        [FindsBy(How = How.ClassName, Using = "btn_action_logout")]
//        public IWebElement logoutButtonHeader { get; set; }

//        [FindsBy(How = How.ClassName, Using = "btn_action_myaccount")]
//        public IWebElement myAccountButtonHeader { get; set; }

//        [FindsBy(How = How.CssSelector, Using = ".portlet-title-level .js-replacer-inline")]
//        public IWebElement myAccountWelcome { get; set; }

//        public void LoginGood1(ExtentTest reporter)
//        {
//            SetMethods.GoToURL(ExcelLib.ReadData(1, "Galacasino.com"), reporter);
//            loginButtonHeader.ClickButton(reporter);
//            userNameField.EnterText(ExcelLib.ReadData(1, "userName"), reporter);
//            passwordField.EnterText(ExcelLib.ReadData(1, "password"), reporter);
//            loginSubmitButton.ClickButton(reporter);
//            myAccountButtonHeader.ClickButton(reporter);
//            myAccountWelcome.VerifyTextIdentical(ExcelLib.ReadData(1, "user_in2906161_Name"), reporter);
//        }
//    }
//}

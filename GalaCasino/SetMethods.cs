using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Reflection;

namespace GalaCasino
{
    public static class SetMethods
    {
        public static void EnterText(this IWebElement element, string value, ExtentTest reporter)
        {
            AssistFunctions assistFunc = new AssistFunctions();
                try
                {
                    System.Threading.Thread.Sleep(2000);
                    new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(4)).Until(ExpectedConditions.ElementToBeClickable(element));
                    element.SendKeys(value);
                }
                catch (Exception e)
                {
                    assistFunc.ChangeReporterStatusToFail(reporter, e);
                }
        }

        public static void ClickButton(this IWebElement element, ExtentTest reporter)
        {
            AssistFunctions assistFunc = new AssistFunctions();
                try
                {
                    System.Threading.Thread.Sleep(2000);
                    new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(4)).Until(ExpectedConditions.ElementToBeClickable(element));
                    element.Click();
                }
                catch (Exception e)
                {
                    assistFunc.ChangeReporterStatusToFail(reporter, e);
                }
        }

        public static void IsElementExist(this IWebElement element, ExtentTest reporter)
        {
            AssistFunctions assistFunc = new AssistFunctions();
                try
                {
                    System.Threading.Thread.Sleep(2000);
                    new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(4)).Until(ExpectedConditions.ElementToBeClickable(element));
                }
                catch (Exception e)
                {
                    assistFunc.ChangeReporterStatusToFail(reporter, e);
                }
        }
        public static void GoToURL(string URL, ExtentTest reporter)
        {
            AssistFunctions assistFunc = new AssistFunctions();
            try
            {
                System.Threading.Thread.Sleep(2000);
                PropertiesCollection.driver.Navigate().GoToUrl(URL);
            }
            catch (Exception e)
            {
                assistFunc.ChangeReporterStatusToFail(reporter, e);
            }
        }
    }
}

using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;
using System;

namespace GalaCasino
{
    public static class SetMethods
    {
        public static void EnterText(this IWebElement element, string value)
        {
            System.Threading.Thread.Sleep(2000);
            new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(30)).Until(ExpectedConditions.ElementToBeClickable(element));
            element.SendKeys(value);
        }

        public static void ClickButton(this IWebElement element, ExtentTest test)
        {
            //try
            //{
                System.Threading.Thread.Sleep(2000);
                new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(4)).Until(ExpectedConditions.ElementToBeClickable(element));
                element.Click();
            //}
            //catch (Exception e)
            //{
            //    PropertiesCollection.driver.TakeScreenshot().SaveAsFile(@"C:\\Error", ScreenshotImageFormat.Jpeg);
            //    test.Log(Status.Info, "ScreenShot - " + test.AddScreenCaptureFromPath(@"C:\\Error.jpeg"));
            //}
        }

        public static void IsElementExist(this IWebElement element)
        {
            System.Threading.Thread.Sleep(2000);
            new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(30)).Until(ExpectedConditions.ElementToBeClickable(element));
        }
    }
}

using AventStack.ExtentReports;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Reflection;

namespace GalaCasino
{
    public static class GetMethods
    {
        public static void VerifyTextContaining(this IWebElement element, string value, ExtentTest reporter)
        {
            try
            {
                System.Threading.Thread.Sleep(2000);
                new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(4)).Until(ExpectedConditions.ElementToBeClickable(element));
                Assert.That(element.Text, Does.Contain(value));
            }
            catch (WebDriverTimeoutException e)
            {
                if (reporter.Status == Status.Pass)
                {
                    reporter.Fail(e);
                    PropertiesCollection.driver.TakeScreenshot().SaveAsFile(@"C:\Users\Tzahi.Ben\Documents\Visual Studio 2015\Projects\GalaCasino\GalaCasino\Reports\Error.jpeg", ScreenshotImageFormat.Jpeg);
                }
            }
            catch (TargetInvocationException e)
            {
                if (reporter.Status == Status.Pass)
                {
                    reporter.Fail(e);
                    PropertiesCollection.driver.TakeScreenshot().SaveAsFile(@"C:\Users\Tzahi.Ben\Documents\Visual Studio 2015\Projects\GalaCasino\GalaCasino\Reports\Error.jpeg", ScreenshotImageFormat.Jpeg);
                }
                }
        }

        public static void VerifyTextIdentical(this IWebElement element, string value, ExtentTest reporter)
        {
            try
            {
                System.Threading.Thread.Sleep(2000);
                new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(4)).Until(ExpectedConditions.ElementToBeClickable(element));
                Assert.That(element.Text, Is.EqualTo(value));
            }
            catch (WebDriverTimeoutException e)
            {
                if (reporter.Status == Status.Pass)
                {
                    reporter.Fail(e);
                    PropertiesCollection.driver.TakeScreenshot().SaveAsFile(@"C:\Users\Tzahi.Ben\Documents\Visual Studio 2015\Projects\GalaCasino\GalaCasino\Reports\Error.jpeg", ScreenshotImageFormat.Jpeg);
                }
            }
            catch (TargetInvocationException e)
            {
                if (reporter.Status == Status.Pass)
                {
                    reporter.Fail(e);
                    PropertiesCollection.driver.TakeScreenshot().SaveAsFile(@"C:\Users\Tzahi.Ben\Documents\Visual Studio 2015\Projects\GalaCasino\GalaCasino\Reports\Error.jpeg", ScreenshotImageFormat.Jpeg);
                }
            }
        }
    }
}

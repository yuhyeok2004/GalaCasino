using AventStack.ExtentReports;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace GalaCasino
{
    public static class GetMethods
    {
        public static void VerifyTextContaining(this IWebElement element, string value, ExtentTest reporter)
        {
            AssistFunctions assistFunc = new AssistFunctions();
                try
                {
                    System.Threading.Thread.Sleep(2000);
                    new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(4)).Until(ExpectedConditions.ElementToBeClickable(element));
                    Assert.That(element.Text, Does.Contain(value));
                }
                catch (Exception e)
                {
                    assistFunc.ChangeReporterStatusToFail(reporter, e);
                }
        }

        public static void VerifyTextIdentical(this IWebElement element, string value, ExtentTest reporter)
        {
            AssistFunctions assistFunc = new AssistFunctions();
                try
                {
                    System.Threading.Thread.Sleep(2000);
                    new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(4)).Until(ExpectedConditions.ElementToBeClickable(element));
                    Assert.That(element.Text, Is.EqualTo(value));
                }
                catch (Exception e)
                {
                    assistFunc.ChangeReporterStatusToFail(reporter, e);
                }
        }
    }
}

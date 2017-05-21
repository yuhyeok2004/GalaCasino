using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace GalaCasino
{
    public static class GetMethods
    {
        public static void VerifyTextIdentical(this IWebElement element, string value)
        {
            System.Threading.Thread.Sleep(2000);
            new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(30)).Until(ExpectedConditions.ElementToBeClickable(element));
            Assert.That(element.Text, Is.EqualTo(value));
        }
    }
}

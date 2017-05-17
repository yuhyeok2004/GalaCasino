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
            try
            {
                new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(30)).Until(ExpectedConditions.ElementToBeClickable(element));
            }
            catch(WebDriverTimeoutException noSuchElement)
            {
                Console.WriteLine(noSuchElement.Message);
            }

            try
            {
                Assert.That(element.Text, Is.EqualTo(value));
            }
            catch (AssertionException textOnPageNotAsExpected)
            {
                Console.WriteLine(textOnPageNotAsExpected.Message);
            }
        }


    }
}

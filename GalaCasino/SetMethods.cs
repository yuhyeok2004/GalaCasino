using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace GalaCasino
{
    public static class SetMethods
    {
        public static void EnterText(this IWebElement element, string value)
        {
            System.Threading.Thread.Sleep(2000);
            try
            {
                new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(30)).Until(ExpectedConditions.ElementToBeClickable(element));
            }
            catch (WebDriverTimeoutException noSuchElement)
            {
                Console.WriteLine(noSuchElement.Message);
            }

            try
            {
                element.SendKeys(value);
            }
            catch(InvalidOperationException unableToSendKeys)
            {
                Console.WriteLine(unableToSendKeys.Message);
            }
        }

        public static void ClickButton(this IWebElement element)
        {
            System.Threading.Thread.Sleep(2000);
            try
            {
                new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(4)).Until(ExpectedConditions.ElementToBeClickable(element));
                element.Click();
            }
            catch (WebDriverTimeoutException noSuchElement)
            {
                Console.WriteLine(noSuchElement.Message);
            }
            catch (NoSuchElementException noSuchElement)
            {
                Console.WriteLine(noSuchElement.Message);
            }
            catch (Exception)
            {
            }
        }

        public static void IsElementExist(this IWebElement element)
        {
            System.Threading.Thread.Sleep(2000);
            try
            {
                new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(30)).Until(ExpectedConditions.ElementToBeClickable(element));
            }
            catch (WebDriverTimeoutException noSuchElement)
            {
                Console.WriteLine(noSuchElement.Message);
            }
        }
    }
}

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
            try
            {
                new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(30)).Until(ExpectedConditions.ElementToBeClickable(element));
            }
            catch (WebDriverTimeoutException noSuchElement)
            {
                Console.WriteLine(noSuchElement.Message);
                Console.WriteLine(element + " does not exist on page");
            }

            try
            {
                element.SendKeys(value);
            }
            catch(InvalidOperationException unableToSendKeys)
            {
                Console.WriteLine(unableToSendKeys.Message);
                Console.WriteLine("Unable to send keys " + value + " to " + element);
            }
        }

        public static void ClickButton(this IWebElement element)
        {
            try
            {
                new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(30)).Until(ExpectedConditions.ElementToBeClickable(element));
            }
            catch (WebDriverTimeoutException noSuchElement)
            {
                Console.WriteLine(noSuchElement.Message);
                Console.WriteLine(element + " does not exist on page");
            }

            try
            {
                element.Click();
            }
            catch (NoSuchElementException noSuchElement)
            {
                Console.WriteLine(noSuchElement.Message);
                Console.WriteLine("Unable to click on " + element);
            }
        }

        public static void IsElementExist(this IWebElement element)
        {
            try
            {
                new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(30)).Until(ExpectedConditions.ElementToBeClickable(element));
            }
            catch (WebDriverTimeoutException noSuchElement)
            {
                Console.WriteLine(noSuchElement.Message);
                Console.WriteLine(element + " does not exist on page");
            }
        }
    }
}

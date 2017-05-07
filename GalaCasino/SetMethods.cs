using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace GalaCasino
{
    class SetMethods
    {
        public static void EnterText(string element, string value, PropertyType elementType)
        {
            if (elementType == PropertyType.Id)
                new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(30000)).Until(ExpectedConditions.ElementToBeClickable(By.Id(element))).SendKeys(value);
            if (elementType == PropertyType.ClassName)
                new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(30000)).Until(ExpectedConditions.ElementToBeClickable(By.ClassName(element))).SendKeys(value);
        }

        public static void ClickButton(string element, PropertyType elementType)
        {
            if (elementType == PropertyType.Id)
                new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(30000)).Until(ExpectedConditions.ElementToBeClickable(By.ClassName(element))).Click();
            if (elementType == PropertyType.ClassName)
                new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(30000)).Until(ExpectedConditions.ElementToBeClickable(By.ClassName(element))).Click();
        }
    }
}

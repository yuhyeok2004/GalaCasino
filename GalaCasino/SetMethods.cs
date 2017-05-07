using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace GalaCasino
{
    class SetMethods
    {
        public static void EnterText(string element, string value, PropertyType elementType)
        {
<<<<<<< HEAD
            if (elementType == "Id")
                new WebDriverWait(driver, TimeSpan.FromSeconds(30000)).Until(ExpectedConditions.ElementToBeClickable(By.Id(element))).SendKeys(value);
            if (elementType == "ClassName")
                new WebDriverWait(driver, TimeSpan.FromSeconds(30000)).Until(ExpectedConditions.ElementToBeClickable(By.ClassName(element))).SendKeys(value);
=======
            if (elementType == PropertyType.Id)
                new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(30000)).Until(ExpectedConditions.ElementToBeClickable(By.Id(element))).SendKeys(value);
            if (elementType == PropertyType.ClassName)
                new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(30000)).Until(ExpectedConditions.ElementToBeClickable(By.ClassName(element))).SendKeys(value);
>>>>>>> 79b42b8883ba8860e94f66042d6616da09b0afc0
        }

        public static void ClickButton(string element, PropertyType elementType)
        {
<<<<<<< HEAD
            if (elementType == "Id")
                new WebDriverWait(driver, TimeSpan.FromSeconds(30000)).Until(ExpectedConditions.ElementToBeClickable(By.Id(element))).Click();
            if (elementType == "ClassName")
                new WebDriverWait(driver, TimeSpan.FromSeconds(30000)).Until(ExpectedConditions.ElementToBeClickable(By.ClassName(element))).Click();
=======
            if (elementType == PropertyType.Id)
                new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(30000)).Until(ExpectedConditions.ElementToBeClickable(By.ClassName(element))).Click();
            if (elementType == PropertyType.ClassName)
                new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(30000)).Until(ExpectedConditions.ElementToBeClickable(By.ClassName(element))).Click();
>>>>>>> 79b42b8883ba8860e94f66042d6616da09b0afc0
        }
    }
}

using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace NUnit
{
    class SetMethods
    {
        public static void EnterText(IWebDriver driver, string element, string value, string elementType)
        {
            if (elementType == "Id")
                new WebDriverWait(driver, TimeSpan.FromSeconds(30000)).Until(ExpectedConditions.ElementToBeClickable(By.Id(element))).SendKeys(value);
            if (elementType == "ClassName")
                new WebDriverWait(driver, TimeSpan.FromSeconds(30000)).Until(ExpectedConditions.ElementToBeClickable(By.ClassName(element))).SendKeys(value);
        }

        public static void ClickButton(IWebDriver driver, string element, string elementType)
        {
            if (elementType == "Id")
                new WebDriverWait(driver, TimeSpan.FromSeconds(30000)).Until(ExpectedConditions.ElementToBeClickable(By.Id(element))).Click();
            if (elementType == "ClassName")
                new WebDriverWait(driver, TimeSpan.FromSeconds(30000)).Until(ExpectedConditions.ElementToBeClickable(By.ClassName(element))).Click();
        }
    }
}

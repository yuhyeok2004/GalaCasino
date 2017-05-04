using NUnit;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace GalaCasino
{
    public class Base
    {
        [SetUp]
        public void Initialize()
        {
            PropertiesCollection.driver = new ChromeDriver();
            PropertiesCollection.driver.Manage().Window.Maximize();
            PropertiesCollection.driver.Navigate().GoToUrl("https://www.galacasino.com/");
            ExcelLib.PopulateInCollection(@"C:\Users\Tzahi.Ben\Documents\NUnit\Data.xlsx");
        }

        [TearDown]
        public void CleanUp()
        {
            PropertiesCollection.driver.Quit();
        }
    }
}

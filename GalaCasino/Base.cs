using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace GalaCasino
{
    public class Base
    {
        protected IWebDriver driver;

        [SetUp]
        public void Initialize()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.galacasino.com/");
            //ExcelLib.PopulateInCollection(@"C:\Users\Tzahi.Ben\Documents\NUnit\Data.xlsx");
        }

        [TearDown]
        public void CleanUp()
        {
            driver.Close();
        }
    }
}

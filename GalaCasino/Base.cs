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
<<<<<<< HEAD
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.galacasino.com/");
            ExcelLib.PopulateInCollection(@"C:\Users\Tzahi.Ben\Documents\NUnit\Data.xlsx");
=======
            PropertiesCollection.driver = new ChromeDriver();
            PropertiesCollection.driver.Manage().Window.Maximize();
            PropertiesCollection.driver.Navigate().GoToUrl("https://www.galacasino.com/");
            //ExcelLib.PopulateInCollection(@"C:\Users\Tzahi.Ben\Documents\NUnit\Data.xlsx");
>>>>>>> 79b42b8883ba8860e94f66042d6616da09b0afc0
        }

        [TearDown]
        public void CleanUp()
        {
            PropertiesCollection.driver.Quit();
        }
    }
}

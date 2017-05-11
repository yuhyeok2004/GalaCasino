using NUnit;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace GalaCasino
{
    [TestFixture]
    public class Program
    {
        static void Main(string[] args)
        {
        }

        [SetUp]
        public void Initialize()
        {
            PropertiesCollection.driver = new ChromeDriver();
            PropertiesCollection.driver.Manage().Window.Maximize();
            PropertiesCollection.driver.Navigate().GoToUrl("https://www.galacasino.com/");
            ExcelLib.PopulateInCollection(@"C:\Users\Tzahi.Ben\Documents\NUnit\Data.xlsx");
        }

        [Test]
        public void LoginGoodTest()
        {
            HomePageObject page = new HomePageObject();
            page.LoginGood();
        }

        [TearDown]
        public void CleanUp()
        {
            PropertiesCollection.driver.Quit();
            AssistFunctions assistFunc = new AssistFunctions();
            assistFunc.killProcess("ChromeDriver");
        }
    }
}

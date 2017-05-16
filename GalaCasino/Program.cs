using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;

namespace GalaCasino
{
    [TestFixture]
    public class Program
    {

        public ExtentReports extent;
        public ExtentTest test;

        static void Main(string[] args)
        {
        }

        [SetUp]
        public void Initialize()
        {
            var pth = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            var actulPath = pth.Substring(0, pth.LastIndexOf("bin"));
            var projectPath = new Uri(actulPath).LocalPath;
            
            var fileName = this.GetType().ToString() + ".html";
            var htmlReporter = new ExtentHtmlReporter(projectPath + fileName);

            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);

            PropertiesCollection.driver = new ChromeDriver();
            PropertiesCollection.driver.Manage().Window.Maximize();
            PropertiesCollection.driver.Navigate().GoToUrl("https://www.galacasino.com/");
            ExcelLib.PopulateInCollection(@"C:\Users\Tzahi.Ben\Documents\NUnit\Data.xlsx");
        }

        [Test]
        public void LoginGoodTest()
        {
            test = extent.CreateTest("test");
            HomePageObject page = new HomePageObject();
            page.LoginGood();
            test.Pass("Hi");
        }

        [TearDown]
        public void CleanUp()
        {
            PropertiesCollection.driver.Quit();
            AssistFunctions assistFunc = new AssistFunctions();
            assistFunc.killProcess("ChromeDriver");
            extent.Flush();
        }
    }
}

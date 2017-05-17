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

        [OneTimeSetUp]
        public void StartReport()
        {
            var pth = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            var actulPath = pth.Substring(0, pth.LastIndexOf("bin"));
            var projectPath = new Uri(actulPath).LocalPath;

            var fileName = GetType().ToString() + ".html";
            var htmlReporter = new ExtentHtmlReporter(projectPath + fileName);

            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);

            extent.AddSystemInfo("Environment", "Prod");
            extent.AddSystemInfo("Tester", "Test");

            PropertiesCollection.driver = new ChromeDriver();
        }

        [SetUp]
        public void Initialize()
        {
            PropertiesCollection.driver.Manage().Window.Maximize();
            PropertiesCollection.driver.Navigate().GoToUrl("https://www.galacasino.com/");
            ExcelLib.PopulateInCollection(@"C:\Users\Tzahi.Ben\Documents\NUnit\Data.xlsx");
        }

        [Test]
        public void LoginGoodTest()
        {
            test = extent.CreateTest("LoginGoodTest");
            HomePageObject page = new HomePageObject();
            page.LoginGood();
        }

        [Test]
        public void LoginGoodTest1()
        {
            test = extent.CreateTest("LoginGoodTest1");
            HomePageObject page = new HomePageObject();
            page.LoginGood();
        }

        [TearDown]
        public void CleanUp()
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var errormessage = TestContext.CurrentContext.Result.Message;

            if(status == NUnit.Framework.Interfaces.TestStatus.Failed)
            {
                test.Log(Status.Fail, status + errormessage);
            }
        }
        
        [OneTimeTearDown]
        public void EndReport()
        {
            extent.Flush();

            PropertiesCollection.driver.Quit();
            AssistFunctions assistFunc = new AssistFunctions();
            assistFunc.killProcess("ChromeDriver");
        }
    }
}

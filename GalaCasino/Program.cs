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

            ExcelLib.PopulateInCollection(@"C:\Users\Tzahi.Ben\Documents\NUnit\Data.xlsx");
        }

        [SetUp]
        public void Initialize()
        {
            PropertiesCollection.driver = new ChromeDriver();
            PropertiesCollection.driver.Manage().Window.Maximize();
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

            PropertiesCollection.driver.Quit();
            AssistFunctions assistFunc = new AssistFunctions();
            assistFunc.killProcess("ChromeDriver");
        }
        
        [OneTimeTearDown]
        public void EndReport()
        {
            extent.Flush();
        }
    }
}

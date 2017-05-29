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
        public ExtentTest reporter;

        static void Main(string[] args)
        {
        }

        [OneTimeSetUp]
        public void StartReport()
        {

            AssistFunctions assistFunc = new AssistFunctions();
            var projectPath = assistFunc.Path();
            var fileName = GetType().ToString() + ".html";
            var htmlReporter = new ExtentHtmlReporter(projectPath + fileName);

            extent = new ExtentReports();
            assistFunc.Extent(extent, htmlReporter);

            ExcelLib.PopulateInCollection(@"C:\Users\Tzahi.Ben\Documents\Visual Studio 2015\Projects\GalaCasino\GalaCasino\Data.xlsx");
        }

        [SetUp]
        public void Initialize()
        {
        }

        [TearDown]
        public void CleanUp()
        {
        }
        
        [OneTimeTearDown]
        public void EndReport()
        {
            AssistFunctions assistFunc = new AssistFunctions();
            extent.Flush();
            assistFunc.killProcess("ChromeDriver");
        }
    }
}

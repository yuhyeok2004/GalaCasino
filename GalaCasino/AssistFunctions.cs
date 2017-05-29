using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using System;
using System.Diagnostics;
using System.Threading;

namespace GalaCasino
{
    class AssistFunctions : Program
    {
        public void killProcess(string processName)
        {
            Process[] pname = Process.GetProcessesByName(processName);
           
            for (int a = pname.Length; a > 0; a--)
            {
                pname[a-1].Kill();
            }
        }

        public void ChangeReporterStatusToFail(ExtentTest reporter, Exception e)
        {
            reporter.Fail(e);
            TakeScreenshot(reporter);
            Thread.CurrentThread.Abort();
        }

        public void TakeScreenshot(ExtentTest reporter)
        {
            string timeStamp = DateTime.Now.ToString("HH-mm-ss dd-MM-yyyy");
            string screenshotPath = (ExcelLib.ReadData(1, "screenshotPath")) + timeStamp + ".jpeg";
            PropertiesCollection.driver.TakeScreenshot().SaveAsFile(screenshotPath, ScreenshotImageFormat.Jpeg);
            reporter.AddScreenCaptureFromPath(screenshotPath);
        }

        public void Browser(BrowserType type)
        {
            if (type == BrowserType.Chrome)
                PropertiesCollection.driver = new ChromeDriver();
            //if(type == BrowserType.Firefox)
                //PropertiesCollection.driver = new FirefoxDriver();
        }

        public string ProjectPath()
        {
            var pth = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            var actulPath = pth.Substring(0, pth.LastIndexOf("bin"));
            var projectPath = new Uri(actulPath).LocalPath;

            return projectPath;
        }

        public ExtentHtmlReporter HTMLReporter()
        {
            ExtentHtmlReporter htmlReporter;
            var projectPath = ProjectPath();
            var fileName = "GalaCasino test report.html";
            htmlReporter = new ExtentHtmlReporter(projectPath + fileName);

            return htmlReporter;
        }

        public void Extent(ExtentReports extent)
        {
            extent.AddSystemInfo("Environment", "Prod");
            extent.AddSystemInfo("Tester", "Test");

            ExtentHtmlReporter htmlReporter = HTMLReporter();

            extent.AttachReporter(htmlReporter);
        }
    }
}

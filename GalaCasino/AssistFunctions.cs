using AventStack.ExtentReports;
using NUnit;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using System;
using System.Diagnostics;

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
            if (reporter.Status == Status.Pass)
            {
                reporter.Fail(e);
                TakeScreenshot(reporter);
            }
        }

        public void TakeScreenshot(ExtentTest reporter)
        {
            string timeStamp = DateTime.Now.ToString("HH-mm-ss dd-MM-yyyy");
            string screenshotPath = (ExcelLib.ReadData(1, "screenshotPath")) + timeStamp + ".jpeg";
            PropertiesCollection.driver.TakeScreenshot().SaveAsFile(screenshotPath, ScreenshotImageFormat.Jpeg);
            reporter.AddScreenCaptureFromPath(screenshotPath);
        }
    }
}

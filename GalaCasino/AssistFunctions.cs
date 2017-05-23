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
                TakeScreenshot();
            }
        }

        public void TakeScreenshot()
        {
            string timeStamp = DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss");
            string screenshotName = @"C:\Users\Tzahi.Ben\Documents\Visual Studio 2015\Projects\GalaCasino\GalaCasino\Reports\" + timeStamp + ".jpeg";
            PropertiesCollection.driver.TakeScreenshot().SaveAsFile(screenshotName, ScreenshotImageFormat.Jpeg);
            reporter.AddScreenCaptureFromPath(@"C:\Users\Tzahi.Ben\Documents\Visual Studio 2015\Projects\GalaCasino\GalaCasino\Reports\", "asd");
        }
    }
}

using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
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

        public void TestStatus(ExtentTest reporter)
        {
            if (reporter.Status == Status.Fail)
            {
                reporter.Log(Status.Fail, "Login, Good-Flow: failed");
                reporter.AddScreenCaptureFromPath(@"C:\Users\Tzahi.Ben\Documents\Visual Studio 2015\Projects\GalaCasino\GalaCasino\Reports\Error.jpeg");
            }
            else
                reporter.Log(Status.Pass, "Login, Good-Flow: ");
        }
    }
}

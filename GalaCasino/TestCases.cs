using NUnit.Framework;
using System;

namespace GalaCasino
{
    class TestCases : Program
    {
        AssistFunctions assistFunc = new AssistFunctions();

        [Test]
        public void LoginGoodFlow()
        {
            foreach (BrowserType browser in Enum.GetValues(typeof(BrowserType)))
            {
                assistFunc.Browser(browser);
                PropertiesCollection.driver.Manage().Window.Maximize();
                reporter = extent.CreateTest("Login, Good-Flow - " + browser);
                HomePageObject page = new HomePageObject();
                page.LoginGood(reporter);
                PropertiesCollection.driver.Quit();
            }
        }

        [Test]
        public void LoginMissingCredentials()
        {
            foreach (BrowserType browser in Enum.GetValues(typeof(BrowserType)))
            {
                assistFunc.Browser(browser);
                PropertiesCollection.driver.Manage().Window.Maximize();
                reporter = extent.CreateTest("Login, Missing Credentials - " + browser);
                HomePageObject page = new HomePageObject();
                page.LoginMissingCredentials(reporter);
                PropertiesCollection.driver.Quit();
            }
        }
    }
}

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
            assistFunc.Browser(BrowserType.Chrome);
            PropertiesCollection.driver.Manage().Window.Maximize();
            reporter = extent.CreateTest("Login, Good-Flow");
            HomePageObject page = new HomePageObject();
            page.LoginGood(reporter);
        }

        [Test]
        public void LoginMissingCredentials()
        {
            assistFunc.Browser(BrowserType.Firefox);
            PropertiesCollection.driver.Manage().Window.Maximize();
            reporter = extent.CreateTest("Login, Missing Credentials");
            HomePageObject page = new HomePageObject();
            page.LoginMissingCredentials(reporter);
        }
    }
}

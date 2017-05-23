using NUnit.Framework;
using System;

namespace GalaCasino
{
    class LoginGoodFlow : Program
    {
        [Test]
        public void LoginGoodFlowTC()
        {
            reporter = extent.CreateTest("Login, Good-Flow");
            HomePageObject page = new HomePageObject();
            page.LoginGood(reporter);
        }
    }
}

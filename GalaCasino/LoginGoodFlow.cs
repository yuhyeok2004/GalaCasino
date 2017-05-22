using NUnit.Framework;

namespace GalaCasino
{
    class LoginGoodFlow : Program
    {
        [Test]
        public void LoginGoodFlowTC()
        {
            System.Threading.Thread.Sleep(2000);
            reporter = extent.CreateTest("Login, Good-Flow");
            HomePageObject page = new HomePageObject();
            page.LoginGood(reporter);
        }
    }
}

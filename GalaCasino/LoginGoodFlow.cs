using NUnit.Framework;

namespace GalaCasino
{
    class LoginGoodFlow : Program
    {
        [Test]
        public void LoginGoodFlowTC()
        {
            System.Threading.Thread.Sleep(2000);
            test = extent.CreateTest("Login: Good-Flow TC");
            HomePageObject page = new HomePageObject();
            page.LoginGood();
        }
    }
}

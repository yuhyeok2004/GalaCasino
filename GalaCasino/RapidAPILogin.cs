using NUnit.Framework;

namespace GalaCasino
{
    class RapidAPILogin : Program
    {
        [Test]
        public void RapidAPILoginTC()
        {
            System.Threading.Thread.Sleep(2000);
            test = extent.CreateTest("Login: Good-Flow TC");
            RapidAPIHPO page = new RapidAPIHPO();
            page.LoginGood();
        }
    }
}

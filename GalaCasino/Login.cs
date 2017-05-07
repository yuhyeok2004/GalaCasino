using NUnit;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaCasino
{
    [TestFixture]
    public class Login : Base
    {
        [Test]
        public void LoginGood()
        {
            SetMethods.ClickButton(driver, "btn_action_login", "ClassName");
            SetMethods.EnterText(driver, "a", "a", "a");
        }
    }
}

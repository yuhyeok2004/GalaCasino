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
    public class Login
    {
        [Test]
        public void LoginGood()
        {
            SetMethods.ClickButton("btn_action_login", PropertyType.ClassName);
            SetMethods.EnterText("a", "a", PropertyType.ClassName);
        }
    }
}

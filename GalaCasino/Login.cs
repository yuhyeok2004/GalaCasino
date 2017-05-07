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
<<<<<<< HEAD
            SetMethods.ClickButton(driver, "btn_action_login", "ClassName");
            SetMethods.EnterText(driver, "a", "a", "a");
=======
            //driver.Url = "https://google.com";
            SetMethods.ClickButton("btn_action_login", PropertyType.ClassName);
            //SetMethods.EnterText("a", "a", "a");
>>>>>>> 79b42b8883ba8860e94f66042d6616da09b0afc0
        }
    }
}

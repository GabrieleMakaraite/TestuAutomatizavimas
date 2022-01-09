using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestuAutomatizavimas.Test
{
    public class AlertTest : BaseTest
    {
        [Test]
        public static void TestAlert()
        {
            _alertPage.NavigateToDefaultPage().ClickAlertButton().AcceptAlert();
        }
    }
}

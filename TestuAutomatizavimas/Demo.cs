using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestuAutomatizavimas
{
    public class Demo
    {
        [Test]

        public static void TestIf4IsEven()
        {
            int leftover = 4 % 2;
            Assert.AreEqual(0, leftover, "4 is not even");
        }

        [Test]

        public static void TestNowIs19()
        {
            DateTime CurrentTime = DateTime.Now;
            Assert.IsTrue(CurrentTime.Hour.Equals(19), "Dabar ne 19 valanda");
        }

        [Test]
        public static void TestIf995IsEven()
        {
            int leftover = 995 % 3;
            Assert.AreEqual(2, leftover, "995 is even");
        }

        [Test]
        public static void TestNowIsMonday()
        {
            DayOfWeek Monday = DateTime.Now.DayOfWeek;
            Assert.IsTrue(Monday.Equals(Monday), "Today is not Monday");
        }

        [Test]
        public static void TestWait5Seconds()
        {
            Thread.Sleep(5000);
        }

    }
}

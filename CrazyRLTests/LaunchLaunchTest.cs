using Microsoft.VisualStudio.TestTools.UnitTesting;
using CrazyRL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyRL.Tests
{
    [TestClass()]
    public class LaunchLaunchTest
    {
        [TestMethod()]
        public void EqualstestIfTwoEqualsObjectAreAssumedToBeEqual()
        {
            Launch launchFirst = new Launch();
            Launch launchSecond = new Launch();
            Assert.AreEqual(launchFirst, launchSecond);
            launchFirst.name = "Test1";
            launchSecond.name = "Test1";
            launchFirst.launchProvider = "Bristol";
            launchSecond.launchProvider = "Bristol";
            launchFirst.rocketFullName = "Test1";
            launchSecond.rocketFullName = "Test1";
            Assert.IsTrue(launchFirst.Equals(launchFirst));
            Assert.IsTrue(launchSecond.Equals(launchSecond));
            Assert.IsTrue(launchFirst.Equals(launchSecond));

            launchFirst.locationGoogleMapsUrl = "url";
            Assert.IsFalse(launchFirst.Equals(launchSecond));
            Assert.AreNotEqual(launchFirst, launchSecond);
        }

        [TestMethod()]
        public void CloneTest()
        {
            Launch launch = new Launch();

            launch.LaunchId = -1;
            launch.name = "A";
            launch.windowStart = DateTime.Now;
            launch.windowEnd = DateTime.Now;
            launch.launchProvider = "B";
            launch.rocketFullName = "C";
            launch.location = "D";
            launch.locationGoogleMapsUrl = "E";
            launch.favourite = false;

            Launch clonedLaunch = new Launch();
            clonedLaunch.Clone(launch);

            if(launch != clonedLaunch) Assert.Fail();
        }
    }
}
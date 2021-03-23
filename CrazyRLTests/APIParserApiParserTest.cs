using Microsoft.VisualStudio.TestTools.UnitTesting;
using CrazyRL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace CrazyRL.Tests
{
    [TestClass()]
    public class APIParserApiParserTest
    {
        private string apiResponse = null;

        [TestMethod()]
        [DataRow("{invalid json response}")]
        [ExpectedException(typeof(InvalidOperationException))]
        public void testIfThrowsExceptionIfResponseHaveInproperFormat(string invalid)
        {
            var parser = new APIParser();
            parser.parseLaunchRequest(invalid);
        }

        [TestMethod()]
        public void testIfLaunchRequestCreateProperLaunchObjectInList()
        {
            apiResponse = File.ReadAllText("ApiTypicalResponse.txt");
            if (apiResponse == null) throw new AssertFailedException();
            var parser = new APIParser();
            var launchList = parser.parseLaunchRequest(apiResponse);

            Launch launch = new Launch();
            launch.name = "Vostok-K | Sputnik 10";
            launch.status = "Success";
            launch.windowStart = "1961-03-25T05:54:00Z";
            launch.windowEnd = "1961-03-25T05:54:00Z";
            launch.launchProvider = "Strategic Missile Troops";
            launch.rocketFullName = "Vostok-K";
            launch.location = "Baikonur Cosmodrome, Republic of Kazakhstan";
            launch.locationGoogleMapsUrl = "https://www.google.com/maps/place/45Â°55'12.0\"N+63Â°20'31.2\"E";

            Assert.IsTrue(launchList.Contains(launch));

        }
    }
}
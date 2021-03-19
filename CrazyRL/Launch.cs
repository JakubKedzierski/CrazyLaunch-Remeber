using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyRL
{
    public class Launch
    {

        public String name { get; set; }
        public String status { get; set; }
        public String windowStart { get; set; }
        public String windowEnd { get; set; }
        public String launchProvider { get; set; }
        public String rocketFullName { get; set; }
        public String location { get; set; }
        public String locationGoogleMapsUrl { get; set; }

        public override string ToString()
        {
            return "name: " + name + "\nstatus: " + status + "\nwindow starts: " + windowStart +
                "\nwindow ends: " + windowEnd + "\nlaunch provider: " + launchProvider + "\nrocket full name: " +
                rocketFullName + "\nlocation: " + location + "\nGoogle Maps Url: " + locationGoogleMapsUrl +"\n";
        }
    }
}

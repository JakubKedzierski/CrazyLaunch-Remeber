using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyRL
{   
    /// <summary>
    /// Domain class representing rocket launch.
    /// </summary>
    public class Launch
    {

        public int LaunchId { get; set; }
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
            return "launch Id: " + LaunchId + "\nname: " + name + "\nstatus: " + status + "\nwindow starts: " + windowStart +
                "\nwindow ends: " + windowEnd + "\nlaunch provider: " + launchProvider + "\nrocket full name: " +
                rocketFullName + "\nlocation: " + location + "\nGoogle Maps Url: " + locationGoogleMapsUrl +"\n";
        }

        /// <summary>
        /// Metoda porównująca, czy dwa loty są tożsame.
        /// </summary>
        /// <param name="obj"></param> 
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Launch launch = (Launch)obj;
            if (LaunchId != launch.LaunchId) return false;
            if (string.Compare(launch.name,name) != 0) return false ;
            if (string.Compare(launch.status, status) != 0) return false;
            if (string.Compare(launch.windowStart, windowStart) != 0) return false;
            if (string.Compare(launch.windowEnd, windowEnd) != 0) return false;
            if (string.Compare(launch.launchProvider, launchProvider) != 0) return false;
            if (string.Compare(launch.rocketFullName, rocketFullName) != 0) return false;
            if (string.Compare(launch.location, location) != 0) return false;
            if (string.Compare(launch.locationGoogleMapsUrl, locationGoogleMapsUrl) != 0) return false;

            return true;
        }

        /// <summary>
        /// Metoda potrzebna do zniwelowania warninga powstałego po przeciążeniu Equals.
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode() { return LaunchId; }

        /// <summary>
        /// Metoda zwracająca krótki zestaw informacji - sp. do wyświetlenia na liście.
        /// </summary>
        public string[] ShortData
        {
            get { return new string[] { this.LaunchId.ToString(), this.name, this.rocketFullName, this.windowStart }; }
        }
    }
}

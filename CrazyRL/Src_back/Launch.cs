using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyRL
{   
    /// <summary>
    /// Klasa reprezentująca każdy pojedynczy start.
    /// </summary>
    public class Launch
    {

        public int LaunchId { get; set; }
        public String name { get; set; }
        public String status { get; set; }
        public DateTime windowStart { get; set; }
        public DateTime windowEnd { get; set; }
        public String launchProvider { get; set; }
        public String rocketFullName { get; set; }
        public String location { get; set; }
        public String locationGoogleMapsUrl { get; set; }
        public bool favourite { get; set; }

        /************************************************************************************************************************/
        public override string ToString()
        {
            return "launch Id: " + LaunchId + "\nname: " + name + "\nstatus: " + status + "\nwindow starts: " + windowStart +
                "\nwindow ends: " + windowEnd + "\nlaunch provider: " + launchProvider + "\nrocket full name: " +
                rocketFullName + "\nlocation: " + location + "\nGoogle Maps Url: " + locationGoogleMapsUrl +"\n";
        }

        /************************************************************************************************************************/

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
            if (string.Compare(launch.name,name) != 0) return false ;
            if (string.Compare(launch.status, status) != 0) return false;
            if (!launch.windowStart.Equals(windowStart)) return false;
            if (!launch.windowEnd.Equals(windowEnd)) return false;
            if (string.Compare(launch.launchProvider, launchProvider) != 0) return false;
            if (string.Compare(launch.rocketFullName, rocketFullName) != 0) return false;
            if (string.Compare(launch.location, location) != 0) return false;
            if (string.Compare(launch.locationGoogleMapsUrl, locationGoogleMapsUrl) != 0) return false;

            return true;
        }

        /************************************************************************************************************************/

        /// <summary>
        /// Metoda potrzebna do zniwelowania warninga powstałego po przeciążeniu Equals.
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode() { return LaunchId; }

        /// <summary>
        /// Przeciążenie operatora porównania obiektów klasy Launch.
        /// </summary>
        /// <param name="obj1">Obiekt porównywalny</param>
        /// <param name="obj2">Obiekt porównywany</param>
        /// <returns></returns>
        public static bool operator ==(Launch obj1, Launch obj2) => obj1.Equals(obj2);

        /// <summary>
        /// Przeciążenie operatora różności obiektów klasy Launch.
        /// </summary>
        /// <param name="obj1">Obiekt porównywalny</param>
        /// <param name="obj2">Obiekt porównywany</param>
        /// <returns></returns>
        public static bool operator !=(Launch obj1, Launch obj2) => !obj1.Equals(obj2);

        /************************************************************************************************************************/

        /// <summary>
        /// Metoda zwracająca krótki zestaw informacji - sp. do wyświetlenia na liście.
        /// </summary>
        public string[] ShortData
        {
            get { return new string[] { this.LaunchId.ToString(), this.name, this.rocketFullName, this.windowStart.ToString() }; }
        }

        /************************************************************************************************************************/

        /// <summary>
        /// Metoda służąca do przepisania zawartości jednego startu do drugiego.
        /// </summary>
        /// <param name="launch"></param>
        public void Clone(Launch launch)
        {
            LaunchId                = launch.LaunchId;
            name                    = launch.name;
            windowStart             = launch.windowStart;
            windowEnd               = launch.windowEnd;
            launchProvider          = launch.launchProvider;
            rocketFullName          = launch.rocketFullName;
            location                = launch.location;
            locationGoogleMapsUrl   = launch.locationGoogleMapsUrl;
            favourite               = launch.favourite;
        }


    }
}

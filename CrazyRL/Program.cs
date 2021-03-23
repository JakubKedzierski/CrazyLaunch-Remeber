using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrazyRL
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        //[STAThread]
        static void Main()
        {
            APIParser api = new APIParser();
            api.getApiResponse();
            var launches = api.parseLaunchRequest();

            using (var context = new LaunchContext())
            {

                
                foreach(var launch in launches) {
                    context.launches.Add(launch);
                }
                context.SaveChanges();
                
                foreach (var launch in context.launches)
                {
                    Console.WriteLine(launch);
                }
                
                //var launch = new Launch() { location = "Zanzibar" };
                //context.launches.Add(launch);
                //context.SaveChanges();
            }

            /*
                foreach (var stuff in launches)
                {
                    Console.WriteLine(stuff);
                }
            */

           /*
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
           */    
    }
    }
}

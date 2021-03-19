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
            
            foreach(var stuff in api.parseLaunchRequest())
            {
                Console.WriteLine(stuff);
            }


           /*
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
           */    
    }
    }
}

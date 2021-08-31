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
        /// Funkcja main programu. Odpowiedzialna jedynie za uruchomienie okna programu.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ViewController viewCtrl = new ViewController();
            Application.Run(viewCtrl);
        }
    }
}

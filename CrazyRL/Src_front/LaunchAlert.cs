using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrazyRL
{

    /// <summary>
    /// Klasa odpowiedzialna za wyskakujące powiadomienia dotyczące zbliżających się startów, które zostały dodane do ulubionych.
    /// </summary>
    public partial class LaunchAlert : Form
    {

        /// <summary>
        /// Domyślny konstruktor.
        /// </summary>
        public LaunchAlert()
        {
            InitializeComponent();
            launchDetail.AutoSize = true;
            launchDetail.TextAlign = ContentAlignment.TopCenter;
            
        }

        /************************************************************************************************************************/

        /// <summary>
        /// Metoda zadządzająca pokazaniem powiadomienia z odpowiednią wiadomością.
        /// </summary>
        /// <param name="msg">Wiadomość ukazująca się w okienku powiadomienia u góry - najczęściej nazwa lotu.</param>
        public void showAlert(String msg)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width  ,
                                            Screen.PrimaryScreen.WorkingArea.Height - this.Height - 2);
            this.launchDetail.Text = msg;
            this.Show();
            this.WindowState = FormWindowState.Normal;

        }

        /************************************************************************************************************************/

        /// <summary>
        /// Krótka metoda zamykająca okno powiadomienia po naciśnięciu przycisku.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e) => this.Close();
    }
}

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
    public partial class LaunchAlert : Form
    {
        public LaunchAlert()
        {
            InitializeComponent();
            launchDetail.AutoSize = true;
            launchDetail.TextAlign = ContentAlignment.TopCenter;
            
        }

        public void showAlert(String msg)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width  ,
                                            Screen.PrimaryScreen.WorkingArea.Height - this.Height - 2);
            this.launchDetail.Text = msg;
            this.Show();
            this.WindowState = FormWindowState.Normal;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        
        }
    }
}

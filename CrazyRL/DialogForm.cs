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
    public partial class DialogForm : MetroFramework.Forms.MetroForm
    {

        public Launch editedLaunch = new Launch();

        public DialogForm()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            editedLaunch.name                   = nameTextBox.Text;
            editedLaunch.status                 = statusTextBox.Text;
            editedLaunch.rocketFullName         = rocketTextBox.Text;
            editedLaunch.launchProvider         = launchProviderTextBox.Text;
            editedLaunch.location               = locationTextBox.Text;
            editedLaunch.locationGoogleMapsUrl  = gmapsUrlTextBox.Text;

            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

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

        /// <summary>
        /// Konstruktor klasy dotyczącej okna dialogowego.
        /// </summary>
        public DialogForm()
        {
            InitializeComponent();
        }

        /************************************************************************************************************************/

        /// <summary>
        /// Metoda obsługująca przerwanie związane z kliknięciem przycisku okej.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void okButton_Click(object sender, EventArgs e)
        {
            editedLaunch.name                   = nameTextBox.Text;
            editedLaunch.status                 = statusTextBox.Text;
            editedLaunch.rocketFullName         = rocketTextBox.Text;
            editedLaunch.launchProvider         = launchProviderTextBox.Text;
            editedLaunch.location               = locationTextBox.Text;
            editedLaunch.locationGoogleMapsUrl  = gmapsUrlTextBox.Text;
            editedLaunch.windowStart            = wStartTimePicker.Value;
            editedLaunch.windowEnd              = wEndTimePicker.Value;

            this.DialogResult = DialogResult.OK;
            Close();
        }

        /************************************************************************************************************************/

        /// <summary>
        /// Metoda obsługująca przerwanie związane z kliknięciem przycisku anuluj.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        /************************************************************************************************************************/

        /// <summary>
        /// Metoda związana z edycją startu - wczytuje dane do edycji przy otwieraniu okna.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DialogForm_Load(object sender, EventArgs e)
        {
            wStartTimePicker.CustomFormat = "dddd, dd MMM yyyy,   HH:mm";
            wEndTimePicker.CustomFormat = "dddd, dd MMM yyyy,   HH:mm";

            nameTextBox.Text            = editedLaunch.name;
            statusTextBox.Text          = editedLaunch.status;
            rocketTextBox.Text          = editedLaunch.rocketFullName;
            launchProviderTextBox.Text  = editedLaunch.launchProvider;
            locationTextBox.Text        = editedLaunch.location;
            gmapsUrlTextBox.Text        = editedLaunch.locationGoogleMapsUrl;

            try // Na wypadek braku ustawionej daty
            {
                wStartTimePicker.Value = editedLaunch.windowStart;
                wEndTimePicker.Value = editedLaunch.windowEnd;
            }
            catch
            {
                wStartTimePicker.Value = DateTime.Now;
                wEndTimePicker.Value = DateTime.Now;
            }
            
        }

     
    }
}

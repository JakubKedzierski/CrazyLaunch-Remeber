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
    /// Klasa zarządzająca oknem programu. Część odpowiedzialna za przerwania pochodzące od działań wykonanych na elementach interfejsu użytkownika.
    /// </summary>
    public partial class ViewController : MetroFramework.Forms.MetroForm
    {

        private APIParser api = new APIParser();

        public ViewController()
        {
            InitializeComponent();
        }

        private void updateFromWebButton_Click(object sender, EventArgs e)
        {

            updateFromWebButton.Enabled = false;
            this.Enabled = false;
            this.UseWaitCursor = true;

            api.getApiResponse();
            var launches = api.parseLaunchRequest();

            updateProgressBar.Value = 50;

            using (var context = new LaunchContext())
            {

                foreach (var launch in launches)
                {
                    context.launches.Add(launch);
                }
                context.SaveChanges();

                updateProgressBar.Value = 75;
            }

            this.ListReload(allLaunchesList);
            updateProgressBar.Value = 100;
            
            this.UseWaitCursor = false;
            this.Enabled = true;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Launch launch = new Launch();

            launch.name = "abc";
            launch.rocketFullName = "gef";
            launch.windowStart = "pqr";

            using (var context = new LaunchContext())
            {
                context.launches.Add(launch);
                context.SaveChanges();
            }

            this.ListReload(allLaunchesList);
        }

        private void editButton_Click(object sender, EventArgs e)
        {

        }

        private void removeButton_Click(object sender, EventArgs e)
        {

            

        }

        private void exportButton_Click(object sender, EventArgs e)
        {

        }

        private void importButton_Click(object sender, EventArgs e)
        {

        }

        private void allLaunchesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void ViewController_Load(object sender, EventArgs e)
        {

            this.ListInit(allLaunchesList);
            this.ListReload(allLaunchesList);
        }
    }
}

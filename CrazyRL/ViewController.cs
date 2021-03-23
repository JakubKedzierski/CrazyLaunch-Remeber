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
    public partial class ViewController : MetroFramework.Forms.MetroForm
    {

        protected APIParser api = new APIParser();

        public ViewController()
        {
            InitializeComponent();

            allLaunchesList.View = View.Details;
            allLaunchesList.Columns.Add("Name");
            allLaunchesList.Columns.Add("Rocket");
            allLaunchesList.Columns.Add("Windows start time");
            allLaunchesList.GridLines = true;
        }

        private void updateFromWebButton_Click(object sender, EventArgs e)
        {

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

                foreach (var launch in context.launches)
                {
                    Console.WriteLine(launch);
                }

                //var launch = new Launch() { location = "Zanzibar" };
                //context.launches.Add(launch);
                //context.SaveChanges();

                //allLaunchesList.add context.launches.ToList();
            }

           /*
               foreach (var stuff in launches)
               {
                   Console.WriteLine(stuff);
               }
           */





            updateProgressBar.Value = 100;
            
            this.UseWaitCursor = false;
            this.Enabled = true;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            allLaunchesList.Items.Add(new ListViewItem(new string[] { "John dsfsfsdfs ", "1", "kupa"}));
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
    }
}

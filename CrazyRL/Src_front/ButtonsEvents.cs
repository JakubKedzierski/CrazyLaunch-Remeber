using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrazyRL
{
    partial class ViewController
    {
        /* PODSTAWOWE PRZYCISKI: */

        /// <summary>
        /// Obsługa przerwania po naciśnięciu przycisku "update from web" - Pobiera poprzez APIParser odpowiednie dane i wczytuje je do bazy danych
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

                bool alreadyExist;
                foreach (var launchInApi in launches)
                {
                    alreadyExist = false;
                    foreach (Launch launchInDataBase in context.launches.ToArray())
                    {
                        if (launchInDataBase == launchInApi) alreadyExist = true;
                    }

                    if (!alreadyExist) context.launches.Add(launchInApi);
                }
                context.SaveChanges();

                updateProgressBar.Value = 75;
            }

            this.ListReload();
            updateProgressBar.Value = 100;

            this.UseWaitCursor = false;
            this.Enabled = true;
        }

        /************************************************************************************************************************/

        /// <summary>
        /// Obsługa przerwania po kliknięciu przycisku "Add launch" - dodawanie nowego lotu do bazy, potem aktualizacja listy.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addButton_Click(object sender, EventArgs e)
        {
            addButton.Enabled = false;
            Launch launch = new Launch();

            DialogForm dialogForm = new DialogForm();
            if (dialogForm.ShowDialog() == DialogResult.OK)
            {
                launch = dialogForm.editedLaunch;

                using (var context = new LaunchContext())
                {
                    context.launches.Add(launch);
                    context.SaveChanges();
                }
            }
            this.ListReload();
            addButton.Enabled = true;
        }

        /************************************************************************************************************************/

        /// <summary>
        /// Obsługa przerwania po kliknięciu przycisku "Edit launch" - edycja wybranego lotu, zapisanie zmian w bazie i aktualizacja listy.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editButton_Click(object sender, EventArgs e)
        {

            DialogForm dialogForm = new DialogForm();
            dialogForm.editedLaunch = activeLaunch;

            if (dialogForm.ShowDialog() == DialogResult.OK) activeLaunch = dialogForm.editedLaunch;
            else return;

            using (var context = new LaunchContext())
            {
                Launch launch = context.launches.Find(activeLaunch.LaunchId);
                launch.getData(activeLaunch);

                context.SaveChanges();
            }

            this.ListReload();
        }

        /************************************************************************************************************************/

        /// <summary>
        /// Obsługa przerwania po kliknięciu przycisku "Remove launch" - usunięcie wybranego lotu, zapisanie zmian w bazie i aktualizacja listy.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeButton_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure?", "Remove launches", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result != DialogResult.OK) return;

            using (var context = new LaunchContext())
            {

                foreach (ListViewItem item in activeList.SelectedItems)
                {

                    Launch launchToRemove = context.launches.Find(int.Parse(item.Text));
                    context.launches.Remove(launchToRemove);

                }
                context.SaveChanges();
            }
            this.ListReload();
        }

        /************************************************************************************************************************/

        /// <summary>
        /// Obsługa przerwania po kliknięciu przycisku "Export" - eksport danych do pliku.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exportButton_Click(object sender, EventArgs e)
        {

        }

        /************************************************************************************************************************/

        /// <summary>
        /// Obsługa przerwania po kliknięciu przycisku "Import" - import danych z pliku do bazy, aktualizacja listy.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void importButton_Click(object sender, EventArgs e)
        {

        }


    }
}

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

        /// <summary>
        /// Obiekt paresra do api uruchamiany z metod klasy ViewController.
        /// </summary>
        private APIParser api = new APIParser();

        /// <summary>
        /// Domyślny konstruktor.
        /// </summary>
        public ViewController()
        {
            InitializeComponent();
        }

        /************************************************************************************************************************/

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

            this.ListReload(allLaunchesList);
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
            this.ListReload(allLaunchesList);
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
            Launch launchToEdit = new Launch();

            using (var context = new LaunchContext())
            {

                foreach (ListViewItem item in allLaunchesList.SelectedItems)
                {

                    launchToEdit = context.launches.Find(int.Parse(item.Text));

                }
                context.SaveChanges();
            }

            DialogForm dialogForm = new DialogForm();
            dialogForm.editedLaunch = launchToEdit;
            if (dialogForm.ShowDialog() == DialogResult.OK) launchToEdit = dialogForm.editedLaunch;
            else return;

            using (var context = new LaunchContext())
            {
                Launch launchToRemove = context.launches.Find(launchToEdit.LaunchId);
                context.launches.Remove(launchToRemove);

                context.launches.Add(launchToEdit);
                context.SaveChanges();
            }

            this.ListReload(allLaunchesList);
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
            if (result == DialogResult.OK)
            {

                using (var context = new LaunchContext())
                {

                    foreach (ListViewItem item in allLaunchesList.SelectedItems)
                    {

                        Launch launchToRemove = context.launches.Find(int.Parse(item.Text));
                        context.launches.Remove(launchToRemove);

                    }
                    context.SaveChanges();
                }
                this.ListReload(allLaunchesList);
                this.ListCheckButtons(allLaunchesList);
            }

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

        /************************************************************************************************************************/

        /// <summary>
        /// Ta metoda wykonuje się od razu po włączeniu okna, powoduje ona dodanie nagłówków do list oraz aktualizację ich zawartości z bazy danych.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewController_Load(object sender, EventArgs e)
        {

            this.ListInit(allLaunchesList);
            this.ListReload(allLaunchesList);
        }

        /************************************************************************************************************************/

        /// <summary>
        /// Przerwanie związane z aktualizacją listy dostępnych przycisków i wyświetleniem szczegółów
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void allLaunchesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = allLaunchesList.SelectedItems;
            if (selected.Count == 1)
            {
                this.tableOfDetails.Visible = true;
                this.padLocationMap.Visible = true;

                using (var context = new LaunchContext())
                {

                    ListViewItem item = selected[0];
                    Launch launch = context.launches.Find(int.Parse(item.Text));

                    launchNameDetail.Text = launch.name;
                    rocketFullLabelDetail.Text = launch.rocketFullName;
                    statusLabelDetail.Text = launch.status;
                    launchProviderLabelDetail.Text = launch.launchProvider;
                    launchPadLocDetail.Text = launch.location;
                    windowStartDetail.Text = launch.windowStart.ToString();
                    windowEndDetail.Text = launch.windowEnd.ToString();
                    this.padLocationMap.Navigate("https://www.google.com/maps/place/" + launch.location);
                    var browser = padLocationMap.ActiveXInstance as SHDocVw.WebBrowser;
                    browser.ExecWB(SHDocVw.OLECMDID.OLECMDID_OPTICAL_ZOOM, SHDocVw.OLECMDEXECOPT.OLECMDEXECOPT_DODEFAULT,40, IntPtr.Zero);
                }
                
            }
            else
            {
                this.tableOfDetails.Visible = false;
                this.padLocationMap.Visible = false;
            }
            this.ListCheckButtons(allLaunchesList);
        }

        /************************************************************************************************************************/

        /// <summary>
        /// Metoda obsługująca przerwanie występujące po wciśnięciu przycisku.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewController_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && removeButton.Enabled) removeButton_Click(sender, e);
            if (e.KeyCode == Keys.Return && editButton.Enabled) editButton_Click(sender, e);
        }

    }
}

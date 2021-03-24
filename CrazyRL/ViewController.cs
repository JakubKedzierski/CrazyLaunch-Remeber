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
                        if (launchInDataBase.name == launchInApi.name)
                        {
                            alreadyExist = true;
                        }
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

        /// <summary>
        /// Obsługa przerwania po kliknięciu przycisku "Add launch" - dodawanie nowego lotu do bazy, potem aktualizacja listy.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Obsługa przerwania po kliknięciu przycisku "Edit launch" - edycja wybranego lotu, zapisanie zmian w bazie i aktualizacja listy.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editButton_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Obsługa przerwania po kliknięciu przycisku "Remove launch" - usunięcie wybranego lotu, zapisanie zmian w bazie i aktualizacja listy.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeButton_Click(object sender, EventArgs e)
        {

            using (var context = new LaunchContext())
            {

                foreach (ListViewItem item in allLaunchesList.Items)
                {
                    if (item.Selected)
                    {


                        foreach (Launch launch in context.launches.ToArray())
                        {
                            if (launch.LaunchId.ToString() == item.Text)
                            {
                                context.launches.Remove(launch);
                            }
                        }
                    }
                }
                context.SaveChanges();
            }
            this.ListReload(allLaunchesList);

        }

        /// <summary>
        /// Obsługa przerwania po kliknięciu przycisku "Export" - eksport danych do pliku.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exportButton_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Obsługa przerwania po kliknięciu przycisku "Import" - import danych z pliku do bazy, aktualizacja listy.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void importButton_Click(object sender, EventArgs e)
        {

        }

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
    }
}

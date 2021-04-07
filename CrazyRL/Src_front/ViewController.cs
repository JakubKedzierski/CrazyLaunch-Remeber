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
        /// Obiekt przechowujący aktualnie wybrany start.
        /// </summary>
        private Launch activeLaunch = new Launch();

        /// <summary>
        /// Obiekt przechowujący aktualnie aktywną listę.
        /// </summary>
        private ListView activeList = new ListView();

        /// <summary>
        /// Domyślny konstruktor.
        /// </summary>
        public ViewController()
        {
            InitializeComponent();
            StartNotifyTimer();
        }        

        /************************************************************************************************************************/

        /// <summary>
        /// Ta metoda wykonuje się od razu po włączeniu okna, powoduje ona dodanie nagłówków do list oraz aktualizację ich zawartości z bazy danych.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewController_Load(object sender, EventArgs e)
        {
            activeList = favLaunchesList;
            ListReload();
            activeList = allLaunchesList;
            ListReload();
            StartTimer();
        }

        /************************************************************************************************************************/
        /************************************************************************************************************************/
        /************************************************************************************************************************/
        /* LISTY I ZAKŁADKI: */

        /// <summary>
        /// Metoda obsługująca przerwanie po zmianie karty z listami (pomiędzy listą wszystkich lotów, a listą ulubionych).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabsControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            activeList = tabsControl.SelectedIndex == 1 ? allLaunchesList : favLaunchesList;
            ListReload();
        }

        /************************************************************************************************************************/

        /// <summary>
        /// Przerwanie związane z aktualizacją zaznaczonych lotów na liście wszystkich lotów.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void allLaunchesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowSelecterLaunchDetails();
            ListCheckButtons();
        }

        /************************************************************************************************************************/

        /// <summary>
        /// Przerwanie związane z aktualizacją zaznaczonych lotów na liście ulubionych lotów.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void favLaunchesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowSelecterLaunchDetails();
            ListCheckButtons();
        }

        /************************************************************************************************************************/
        /************************************************************************************************************************/
        /************************************************************************************************************************/
        /* POZOSTAŁE ELEMENTY: */

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

        /************************************************************************************************************************/

        /// <summary>
        /// Krótka metoda odpowiadająca za przekierowanie na stronę internetową po kliknięciu linku.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void locationLink_Click(object sender, EventArgs e) => System.Diagnostics.Process.Start(activeLaunch.locationGoogleMapsUrl);

        /************************************************************************************************************************/

        /// <summary>
        /// Metoda odpowiedzialna za dodawanie startu do ulubionych lub usuwanie go stamtąd.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void favCheckBox_Click(object sender, EventArgs e)
        {
            using (var context = new LaunchContext())
            {
                Launch launch = context.launches.Find(activeLaunch.LaunchId);
                launch.favourite = !launch.favourite;
                context.SaveChanges();
                favLaunchesList.Items.Add(new ListViewItem(launch.ShortData));
                
            }
            if (tabsControl.SelectedIndex == 0) ListReload();
        }

    }
}

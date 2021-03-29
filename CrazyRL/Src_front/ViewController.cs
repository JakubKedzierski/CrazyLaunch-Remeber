﻿using System;
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

            DialogForm dialogForm = new DialogForm();
            dialogForm.editedLaunch = activeLaunch;

            if (dialogForm.ShowDialog() == DialogResult.OK) activeLaunch = dialogForm.editedLaunch;
            else return;

            using (var context = new LaunchContext())
            {
                Launch launchToRemove = context.launches.Find(activeLaunch.LaunchId);
                context.launches.Remove(launchToRemove);

                context.launches.Add(activeLaunch);
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
            if (result != DialogResult.OK) return;

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
            this.ListCheckButtons();
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
            this.ListReload(allLaunchesList);
            this.StartTimer();
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
                using (var context = new LaunchContext())
                {

                    ListViewItem item = selected[0];
                    activeLaunch = context.launches.Find(int.Parse(item.Text));

                    launchNameDetail.Text = activeLaunch.name;
                    rocketFullLabelDetail.Text = activeLaunch.rocketFullName;
                    statusLabelDetail.Text = activeLaunch.status;
                    launchProviderLabelDetail.Text = activeLaunch.launchProvider;
                    launchPadLocDetail.Text = activeLaunch.location;
                    windowStartDetail.Text = activeLaunch.windowStart.ToString();
                    windowEndDetail.Text = activeLaunch.windowEnd.ToString();

                    if (activeLaunch.favourite) favCheckBox.Checked = true;
                    else favCheckBox.Checked = false;
                }

            }

            this.ListCheckButtons();
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

        /************************************************************************************************************************/

        private void tabsControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabsControl.SelectedIndex == 1)
            {
                this.ListReload(allLaunchesList);
            }
            else this.ListReload(favLaunchesList, true);

            this.ListCheckButtons();
        }

        /************************************************************************************************************************/

        private void locationLink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(activeLaunch.locationGoogleMapsUrl);
        }

        /************************************************************************************************************************/

        private void favCheckBox_Click(object sender, EventArgs e)
        {
            using (var context = new LaunchContext())
            {
                Launch launch = context.launches.Find(activeLaunch.LaunchId);
                launch.favourite = !launch.favourite;

                context.SaveChanges();
            }
        }
    }
}

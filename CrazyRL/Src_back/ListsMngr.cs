using System;
using System.Windows.Forms;
using System.Linq;


namespace CrazyRL
{

    /// <summary>
    /// Klasa zarządzająca oknem programu. Część posiadająca metody związane z obsługą list interfejsu użytkownika.
    /// </summary>
    partial class ViewController
    {

        /// <summary>
        /// Przeładowanie (odświerzenie) na nowo wierszy w liście.
        /// </summary>
        private void ListReload()
        {
            bool favOnly = false;
            if (activeList == favLaunchesList) favOnly = true;

            activeList.Items.Clear();

            using (var context = new LaunchContext())
            {
                foreach (Launch launch in context.launches.ToArray())
                {
                    if (favOnly && !launch.favourite) continue;
                    activeList.Items.Add(new ListViewItem(launch.ShortData));

                }
            }

            if (activeList.Items.Count > 0) activeList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            else activeList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            activeList.Columns[0].Width = 0;
            
            ListCheckButtons();
        }

        /************************************************************************************************************************/

        /// <summary>
        /// Aktywacja i dezaktywacja przycisków add oraz edit.
        /// </summary>
        private void ListCheckButtons()
        {
            int nofItems = activeList.SelectedItems.Count;

            if (nofItems == 1)
            {
                removeButton.Enabled = true;
                editButton.Enabled = true;
                detailsBox.Visible = true;
            }
            else if(nofItems < 1)
            {
                removeButton.Enabled = false;
                editButton.Enabled = false;
                detailsBox.Visible = false;
            }
            else
            {
                editButton.Enabled = false;
                detailsBox.Visible = false;
            }
            
        }

        /************************************************************************************************************************/

        /// <summary>
        /// Metoda pokazująca szczegóły startu zaznaczonego na aktywnej liście.
        /// </summary>
        private void ShowSelecterLaunchDetails()
        {
            var selected = activeList.SelectedItems;
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
        }


    }
}
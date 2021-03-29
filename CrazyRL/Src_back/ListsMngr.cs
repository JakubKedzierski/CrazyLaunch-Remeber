using System;
using System.Windows.Forms;
using System.Linq;


namespace CrazyRL
{

    /// <summary>
    /// Klasa zarządzająca oknem programu. Część posiadająca metody związane z obsługą list interfejsu użytkownika.
    /// </summary>
    public partial class ViewController
    {

        /// <summary>
        /// Przeładowanie (odświerzenie) na nowo wierszy w liście.
        /// </summary>
        private void ListReload(ListView listV)
        {
            listV.Items.Clear();

            using (var context = new LaunchContext())
            {
                foreach (Launch launch in context.launches.ToArray())
                {
                    listV.Items.Add(new ListViewItem(launch.ShortData));
                }

                if (listV.Items.Count > 0) listV.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                else listV.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                listV.Columns[0].Width = 0;
            }
        }

        /************************************************************************************************************************/

        /// <summary>
        /// Aktywacja i dezaktywacja przycisków add oraz edit.
        /// </summary>
        /// <param name="listV">Lista, na podstawie której odświeżać przyciski</param>
        private void ListCheckButtons()
        {
            int nofItems = -1;
            if (tabsControl.SelectedIndex == 1)
            {
                nofItems = allLaunchesList.SelectedItems.Count;
                favouriteButton.Text = "Add to favourites";
            }
            else
            {
                nofItems = favLaunchesList.SelectedItems.Count;
                favouriteButton.Text = "Remove from favourites";
            }

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


    }
}
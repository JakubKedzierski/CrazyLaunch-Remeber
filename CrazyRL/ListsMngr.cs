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
        /// Inicjalizacja listy - dodanie nagłówków (kolumn).
        /// </summary>
        /// <param name="listV">Lista do zainicjalizowania</param>
        private void ListInit(ListView listV)
        {
            listV.View = View.Details;
            listV.Columns.Add("Id");
            listV.Columns.Add("Name");
            listV.Columns.Add("Rocket");
            listV.Columns.Add("Window start time");
            listV.GridLines = true;
        }

        /************************************************************************************************************************/

        /// <summary>
        /// Przeładowanie (odświerzenie) na nowo wierszy w liście.
        /// </summary>
        /// <param name="listV">Lista do przeładowania</param>
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
            }
        }

        /************************************************************************************************************************/

        /// <summary>
        /// Aktywacja i dezaktywacja przycisków add oraz edit.
        /// </summary>
        /// <param name="listV">Lista, na podstawie której odświeżać przyciski</param>
        private void ListCheckButtons(ListView listV)
        {
            int nofItems = allLaunchesList.SelectedItems.Count;

            if (nofItems < 1)
            {
                removeButton.Enabled = false;
                editButton.Enabled = false;
            }
            else
            {
                removeButton.Enabled = true;
                if (nofItems > 1) editButton.Enabled = false;
                else editButton.Enabled = true;
            }
        }


    }
}
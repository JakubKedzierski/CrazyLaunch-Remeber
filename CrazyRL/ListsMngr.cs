using System;
using System.Windows.Forms;
using System.Linq;


namespace CrazyRL
{
    public partial class ViewController
    {

        private void ListInit(ListView listV)
        {
            listV.View = View.Details;
            listV.Columns.Add("Id");
            listV.Columns.Add("Name");
            listV.Columns.Add("Rocket");
            listV.Columns.Add("Window start time");
            listV.GridLines = true;
        }

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

    }
}
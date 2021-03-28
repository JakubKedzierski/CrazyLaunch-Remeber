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
    public partial class MapForm : MetroFramework.Forms.MetroForm
    {
        public string url { get; set; }

        public MapForm()
        {
            InitializeComponent();
        }

        public bool run()
        {
            if (string.IsNullOrEmpty(url)) return false;

            padLocationMap.Navigate(this.url);
            var browser = padLocationMap.ActiveXInstance as SHDocVw.WebBrowser;
            browser.ExecWB(SHDocVw.OLECMDID.OLECMDID_OPTICAL_ZOOM, SHDocVw.OLECMDEXECOPT.OLECMDEXECOPT_DODEFAULT, 40, IntPtr.Zero);

            return true;
        }

        private void MapForm_Load(object sender, EventArgs e)
        {
            run();
        }
    }
}

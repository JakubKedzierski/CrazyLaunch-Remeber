using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace CrazyRL
{
    partial class ViewController
    {

        public void StartTimer()
        {
            System.Timers.Timer launchTimer = new System.Timers.Timer(1000);

            launchTimer.Elapsed += OnTimedEvent;
            launchTimer.AutoReset = true;
            launchTimer.Enabled = true;
        }
        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            string newLabel = (DateTime.Now).ToString();

            Action timerUpdate = () => timeLeftLabel.Text = newLabel;
            Invoke(new Action(timerUpdate));
        }
    }
}

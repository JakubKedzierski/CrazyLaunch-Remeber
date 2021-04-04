using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace CrazyRL
{

    /// <summary>
    /// Fragment klasy ViewController odpowiedzialny za obsługę timerów programowych.
    /// </summary>
    partial class ViewController
    {

        /// <summary>
        /// Lista startów, o których powiadomienie już zostało pokazane.
        /// </summary>
        private List<Launch> alreadyNotyfied = new List<Launch>();

        /************************************************************************************************************************/

        /// <summary>
        /// Włączenie timera odświeżającego odliczanie czasu do startu.
        /// </summary>
        public void StartTimer()
        {
            System.Timers.Timer launchTimer = new System.Timers.Timer(250);

            launchTimer.Elapsed += OnTimedEvent;
            launchTimer.AutoReset = true;
            launchTimer.Enabled = true;
        }

        /************************************************************************************************************************/

        /// <summary>
        /// Przerwanie pochodzące od timera. Celem jego jest aktualizacja czasu pozostałego do startu, dla startu, którego szczegóły są aktualnie wyświetlone.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            string newLabel;

            if (Math.Abs((DateTime.Now - activeLaunch.windowStart).Days) > 365)
            {
                newLabel = (DateTime.Now.Subtract(activeLaunch.windowStart).Days / 365).ToString() + " years";
            }
            else if (Math.Abs((DateTime.Now - activeLaunch.windowStart).Days) > 7)
            {
                newLabel = DateTime.Now.Subtract(activeLaunch.windowStart).Days.ToString() + " days";
            }
            else
            {
                newLabel = DateTime.Now.Subtract(activeLaunch.windowStart).ToString();
                newLabel = newLabel.Substring(0, newLabel.Length - 8);
            }

            Action timerUpdate = () => timeLeftLabel.Text = newLabel;
            Invoke(new Action(timerUpdate));
        }

        /************************************************************************************************************************/

        /// <summary>
        /// Włączenie timera wyświetlającego powiadomienia o ulubionych startach.
        /// </summary>
        public void StartNotifyTimer()
        {
            System.Timers.Timer launchTimer = new System.Timers.Timer(8 * 1000);

            launchTimer.Elapsed += NotifyCheckInTimer;
            launchTimer.AutoReset = true;
            launchTimer.Enabled = true;
        }

        /************************************************************************************************************************/

        /// <summary>
        /// Przerwanie pochodzące od timera. Celem jego jest wyświetlenie powiadomienia o ulubionych startach,
        /// do których pozostało mniej niż 15 minut.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        private void NotifyCheckInTimer(Object source, ElapsedEventArgs e)
        {

            Action timerUpdate = () => {
                using (var context = new LaunchContext())
                {
                    String msg = "";
                    bool notify = false;
                    foreach (ListViewItem launchItem in favLaunchesList.Items)
                    {
                        Launch launch = context.launches.Find(int.Parse(launchItem.Text));
                        var timeToStart = DateTime.Now.Subtract(launch.windowStart).Days;
                        if(timeToStart >= -1 && timeToStart < 1)
                        {
                            timeToStart = DateTime.Now.Subtract(launch.windowStart).Minutes;
                            
                            if (timeToStart >= -15 && !alreadyNotyfied.Contains(launch))
                            {
                                if (timeToStart <= 0)
                                {
                                    notify = true;
                                    alreadyNotyfied.Add(launch);
                                    msg = launch.name;
                                    break;
                                }
                            }
                        }

                    }

                    if (notify == true)
                    {
                        LaunchAlert alert = new LaunchAlert();
                        alert.showAlert(msg);
                    }
                }
            };
            Invoke(new Action(timerUpdate));

        }

    }
}

using DigitalClock.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace DigitalClock.ViewModels
{
    public class TimeViewModel
    {
        private Timer timer;

        private TimeModel timeModel;

        public TimeModel Time
        {
            get { return this.timeModel; }
        }

        public TimeViewModel()
        {
            this.timeModel = new TimeModel();

            this.timer = new Timer();

            this.timer.Interval = 1000;

            this.timer.Elapsed += this.onTimerElapsed;

            this.timer.Start();
        }

        private void onTimerElapsed(object sender, ElapsedEventArgs eventArgs)
        {
            this.timeModel.UpdateDateTime();
        }
    }
}

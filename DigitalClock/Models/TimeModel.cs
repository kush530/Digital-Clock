using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalClock.Models
{
    public class TimeModel : INotifyPropertyChanged
    {
        private string dateTimeFormat = "T";

        private string dateFormat = "M/d/yy";

        private string dateToDisplay = string.Empty;

        private string dateTimeToDisplay = string.Empty;

        private DateTime currentDateTime;

        public event PropertyChangedEventHandler PropertyChanged;

        public TimeModel()
        {
            this.UpdateDateTime();
        }

        public string DateTimeToDisplay
        {
            get
            {
                return this.dateTimeToDisplay;
            }

            private set 
            {
                this.dateTimeToDisplay = value;
                this.RaisePropertyChanged("DateTimeToDisplay");
            }
        }

        public string DateToDisplay
        {
            get
            {
                return this.dateToDisplay;
            }

            private set
            {
                this.dateToDisplay = value;
                this.RaisePropertyChanged("DateToDisplay");
            }
        }

        public void UpdateDateTime()
        {
            this.currentDateTime = DateTime.Now;

            this.DateToDisplay = this.currentDateTime.ToString(this.dateFormat);
            this.DateTimeToDisplay = this.currentDateTime.ToString(this.dateTimeFormat);
        }

        private void RaisePropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if(handler == null)
            {
                return;
            }

            handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

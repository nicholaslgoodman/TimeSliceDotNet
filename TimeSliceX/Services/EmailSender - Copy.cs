using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;

namespace TimeSliceX.Services
{
    // https://stackoverflow.com/questions/1493203/alarm-clock-application-in-net Coincoin
    public class AlarmClock
    {
        private Timer timer;
        private DateTime alarmTime;
        private bool enabled;
        private EventHandler alarmEvent;

        public AlarmClock(DateTime alarmTime)
        {
            this.alarmTime = alarmTime;

            timer = new Timer();
            timer.Elapsed += timer_Elapsed;
            timer.Interval = 1000;
            timer.Start();

            enabled = true;
        }

        void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (enabled && DateTime.Now > alarmTime)
            {
                enabled = false;
                OnAlarm();
                timer.Stop();
            }
        }

        protected virtual void OnAlarm()
        {
            if (alarmEvent != null)
                alarmEvent(this, EventArgs.Empty);
        }


        public event EventHandler Alarm
        {
            add { alarmEvent += value; }
            remove { alarmEvent -= value; }
        }
    }
}
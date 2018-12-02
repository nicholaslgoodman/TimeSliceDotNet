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
        public void runTimer(int span)
        {
            Timer aTimer = new Timer(span);

            aTimer.Elapsed += new ElapsedEventHandler(RunEvent);
            aTimer.Interval = 1000;
            aTimer.Enabled = true;
        }

        //This method will get called every second until the timer stops or the program exits.
        public void RunEvent(object source, ElapsedEventArgs e)
        {
            Console.WriteLine("RunEvent() called at " + DateTime.Now.ToLongTimeString());
        }
    }
}
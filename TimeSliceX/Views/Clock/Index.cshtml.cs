using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TimeSliceX.Services;

namespace TimeSliceX.Views
{
    public class ClockModel : PageModel
    {
        private TimeSpan ElapsedTime;
        public void OnGet(int span)
        {
            var sw = new Stopwatch();
            sw.Start();

            
            using (var task = Task.Delay(2000))
            {
                ElapsedTime = new TimeSpan(sw.ElapsedMilliseconds);
                ViewData["ElapsedTime"] = ElapsedTime.Milliseconds.ToString();
                task.Wait();
            }
            sw.Stop();

        }
    }
}
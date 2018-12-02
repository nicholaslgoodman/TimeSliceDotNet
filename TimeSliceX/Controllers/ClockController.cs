using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TimeSliceX.Models;
using TimeSliceX.Services;

namespace TimeSliceX.Controllers
{
    public class ClockController : Controller
    {

        public IActionResult Index()
        {
            var sw = new Stopwatch();
            sw.Start();
            var ElapsedTime = new TimeSpan(sw.ElapsedMilliseconds);

            using (var task = Task.Delay(2000))
            {                
                task.Wait();
                ViewData["ElapsedTime"] = sw.ElapsedMilliseconds.ToString();
            }

            sw.Stop();
            
            return View();
        }


        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
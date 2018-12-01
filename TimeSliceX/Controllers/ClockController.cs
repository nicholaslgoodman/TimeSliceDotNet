using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TimeSliceX.Controllers
{
    public class ClockController : Controller
    {


        public IActionResult Index()
        {
            return View();
        }
    }
}
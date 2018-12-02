using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TimeSliceX.Models;
using TimeSliceX.Services;
using Octokit;

namespace TimeSliceX.Controllers
{
    public class ClockController : Controller
    {
        
        public async Task<Account> GetProfile()
        {
            var client = new GitHubClient(new Octokit.ProductHeaderValue("TimeSlice"));
            var user = await client.User.Get("nicholaslgoodman");
            return user;


        }

        public async Task<IActionResult> Index()
        {
            var user = await GetProfile();
            ViewData["userProfile"] = user.AvatarUrl.ToString();
            return View();
        }


        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = System.Diagnostics.Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
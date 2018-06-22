﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASPNETCore2MVC.Models;

namespace ASPNETCore2MVC.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View("~/wwwroot/index.html");
        }
        public IActionResult Error404()
        {
            return View("~/Angular/src/app/error/404/e-404.html");
        }
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View("");
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

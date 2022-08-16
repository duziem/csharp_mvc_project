﻿using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebFundamentals.Models;

namespace WebFundamentals.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            { 
                return View();
            }
            else
            {
                return View("Landing");
            }
        }

        public IActionResult Privacy()
        {
            
            return View();
            //RedirectToAction()
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
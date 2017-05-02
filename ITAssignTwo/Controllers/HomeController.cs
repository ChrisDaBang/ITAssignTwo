﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ITAssignTwo.Models;

namespace ITAssignTwo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            AboutModel model = new AboutModel();

            return View(model);
        }

        public IActionResult Contact()
        {
            ContactModel model = new ContactModel();

            return View(model);
        }

        public IActionResult Error()
        {
            return View();
        }

        public IActionResult Gallery()
        {
            return View();
        }
    }
}

﻿using Microsoft.AspNetCore.Mvc;

namespace ControllerAndRoute.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Detail()
        {
            return View();
        }

        public IActionResult List()
        {
            return View();
        }
    }
}

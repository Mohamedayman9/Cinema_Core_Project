﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Cinema_Core_Project.Controllers
{
    public class SitemapController : Controller
    {
        public IActionResult Sitemap()
        {
            return View();
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Cinema_Core_Project.Controllers
{
    public class articlesController : Controller
    {
        public IActionResult Articles()
        {
            return View();
        }
    }
}
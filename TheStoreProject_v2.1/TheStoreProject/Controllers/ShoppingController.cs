﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheStoreProject.Controllers
{
    public class ShoppingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

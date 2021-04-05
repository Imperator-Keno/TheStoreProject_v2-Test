using Microsoft.AspNetCore.Mvc;
using System;
using TheStoreProject.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheStoreProject.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddItem()
        {
            return View();
        }
    }
}

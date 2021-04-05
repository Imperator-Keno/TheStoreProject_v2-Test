using Microsoft.AspNetCore.Mvc;
using TheStoreProject.ViewModels;
using System;
using TheStoreProject.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheStoreProject.Controllers
{
    public class ItemController : Controller
    {
        ItemDBContext db;
        public ItemController(ItemDBContext db)
        {
            this.db = db;
        }
        public async Task<IActionResult> AllItem()
        {
            var item = await db.itemMasters.ToListAsync();
            return View(item);
        }
        public IActionResult AddItem()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddItem(ItemMaster itemMaster)
        {
            db.Add(itemMaster);
            db.SaveChanges();
            return RedirectToAction("AllItem");
        }
    }
}

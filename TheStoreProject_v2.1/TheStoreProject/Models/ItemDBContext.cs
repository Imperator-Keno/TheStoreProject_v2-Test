using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TheStoreProject.Models
{
    public class ItemDBContext: DbContext
    {
        public DbSet<ItemMaster> itemMasters { get; set; }
        public DbSet<Category> categories { get; set; }
        public ItemDBContext(DbContextOptions<ItemDBContext> options) : base(options)
        {

        }


    }
}

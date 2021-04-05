using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheStoreProject.Models
{
    public class Category
    {
        public string CATEGORY_NAME { get; set; }
        
        [Key]
        public int CATEGORY_ID { get; set; }
    }
}

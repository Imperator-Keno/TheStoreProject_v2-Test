using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheStoreProject.Models
{
    // Model for the Item Master table in the store database.
    public class ItemMaster
    {
        public int ITEM_ID { get; set; }
        public int ITEM_UPC { get; set; }
        public string ITEM_NAME { get; set; }
        public String ITEM_CATEGORY { get; set; }
        public String ITEM_DESCRIPTION{ get; set; }
        public int INNER_PACK_QTY { get; set; }
        public Decimal RETAIL_PRICE { get; set; }
        public decimal DISCOUNT_PERCENTAGE { get; set; }
        public String SUPPLIER { get; set; }
        public int SUPPLIER_ID { get; set; }

        [Key]
        public int CATEGORY_ID { get; set; }
        public string BUYER_NAME { get; set; }
        public int BUYER_ID { get; set; }

    }
}

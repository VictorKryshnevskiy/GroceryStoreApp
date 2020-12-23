using System;
using System.Collections.Generic;
using System.Text;

namespace GroceryStoreApp
{
    public class Product
    {
        public string Name { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SalePrice { get; set; }
        public DateTime ShelfLife { get; set; }
        public Classification ProductClassification { get; set; } 

    }
}

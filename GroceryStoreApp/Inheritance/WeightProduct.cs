using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStoreApp
{
    public class WeightProduct : BaseProduct
    {
        public int Weight { get; set;}
        public WeightProduct(string name, decimal purchasePrice, decimal salePrice, DateTime shelfLife, int weight) 
        {
            Name = name;
            PurchasePrice = purchasePrice;
            SalePrice = salePrice;
            ShelfLife = shelfLife;
            Weight = weight;
        }
        //для десериализации
        public WeightProduct()
        { }
    }
}

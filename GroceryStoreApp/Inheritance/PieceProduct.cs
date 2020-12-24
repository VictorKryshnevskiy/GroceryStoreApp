using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStoreApp
{
    class PieceProduct : BaseProduct
    {
        public int Count { get; set;}
        public PieceProduct(string name, decimal purchasePrice, decimal salePrice, DateTime shelfLife, int count)
        {
            Name = name;
            PurchasePrice = purchasePrice;
            SalePrice = salePrice;
            ShelfLife = shelfLife;
            Count = count;
        }
        //для десериализации
        public PieceProduct()
        { }
    }
}

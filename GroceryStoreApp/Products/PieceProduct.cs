using System;

namespace GroceryStoreApp
{
    public class PieceProduct : BaseProduct
    {
        
        public PieceProduct(string name, decimal purchasePrice, decimal salePrice, DateTime shelfLife, int count, string storage = "items"): base(name, purchasePrice, salePrice, shelfLife, storage, count)
        {
            Storage = storage;
        }
        //для десериализации
        public PieceProduct()
        { }
    }
}

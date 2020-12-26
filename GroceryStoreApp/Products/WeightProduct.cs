using System;

namespace GroceryStoreApp
{
    public class WeightProduct : BaseProduct
    {
        public WeightProduct(string name, decimal purchasePrice, decimal salePrice, DateTime shelfLife, int count, string storage = "kg"): base(name, purchasePrice, salePrice, shelfLife, storage,count)
        {
            Storage = storage;
        }
        //для десериализации
        public WeightProduct()
        { }
    }
}

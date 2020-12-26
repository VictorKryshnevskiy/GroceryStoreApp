using System;

namespace GroceryStoreApp
{
    public class WeightProduct : BaseProduct
    {
        public int Weight { get; set; }
        public WeightProduct(string name, decimal purchasePrice, decimal salePrice, DateTime shelfLife, int weight, string storage = "kg"): base(name, purchasePrice, salePrice, shelfLife, storage)
        {
            Weight = weight;
            Storage = storage;
        }
        //для десериализации
        public WeightProduct()
        { }
    }
}

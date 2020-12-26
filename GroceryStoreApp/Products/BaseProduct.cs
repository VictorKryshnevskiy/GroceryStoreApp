using System;

namespace GroceryStoreApp
{
    public abstract class BaseProduct
    {
        public Guid Id { get; set;}
        public string Name { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SalePrice { get; set; }
        public DateTime ShelfLife { get; set; }
        public string Storage { get; set; }
        public int Count { get; set; }
        public BaseProduct(string name, decimal purchasePrice, decimal salePrice, DateTime shelfLife, string storage, int count)
        {
            Id = Guid.NewGuid();
            Name = name;
            PurchasePrice = purchasePrice;
            SalePrice = salePrice;
            ShelfLife = shelfLife;
            Storage = storage;
            Count = count;
        }
        public BaseProduct()
        {

        }
    }
}

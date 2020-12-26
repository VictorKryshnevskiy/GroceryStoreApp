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
        public BaseProduct(string name, decimal purchasePrice, decimal salePrice, DateTime shelfLife, string storage)
        {
            Id = Guid.NewGuid();
            Name = name;
            PurchasePrice = purchasePrice;
            SalePrice = salePrice;
            ShelfLife = shelfLife;
            Storage = storage;
        }
        public BaseProduct()
        {

        }
    }
}

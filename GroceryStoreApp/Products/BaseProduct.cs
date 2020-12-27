using System;

namespace GroceryStoreApp
{
    public abstract class BaseProduct
    {
        public Guid Id { get; set; }
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
        public void Validate()
        {
            if (ShelfLife < DateTime.Now)
            {
                throw new Exception("Товар не может быть просрочен");
            }
            if (Name.Length > 100)
            {
                throw new Exception("Наименование не может быть длинее 100 символов");
            }
            if (Count < 0)
            {
                throw new Exception("Количество товара не может быть отрицательным");
            }
            if (Name.Length < 2)
            {
                throw new Exception("Наименование не может короче 2х символов");
            }
        }
    }
}

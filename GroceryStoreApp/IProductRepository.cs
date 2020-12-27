using System;
using System.Collections.Generic;

namespace GroceryStoreApp
{
    public interface IProductRepository<T> where T: BaseProduct
    {
        List<T> GetProducts();
        void Save(T product);
        void Update(List<T> products);
    }
}

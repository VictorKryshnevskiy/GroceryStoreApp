using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStoreApp
{
    public interface IProductRepository
    {
        List<WeightProduct> GetWeightProducts();
        List<PieceProduct> GetPieceProducts();
        void Save<T>(T product) where T : BaseProduct;
        void Save<T>(List<T> products) where T : BaseProduct;
        void Update<T>(T product) where T : BaseProduct;
        void Update<T>(List<T> products) where T : BaseProduct;
        void Delete<T>(T product) where T : BaseProduct;
    }
}

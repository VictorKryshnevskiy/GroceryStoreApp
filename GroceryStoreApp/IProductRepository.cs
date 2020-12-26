using System.Collections.Generic;

namespace GroceryStoreApp
{
    public interface IProductRepository
    {
        List<WeightProduct> GetWeightProducts();
        List<PieceProduct> GetPieceProducts();
        void Save<T>(T product) where T : BaseProduct;
        void Update<T>(List<T> products) where T : BaseProduct;
    }
}

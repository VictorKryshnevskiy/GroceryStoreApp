using System.Collections.Generic;

namespace GroceryStoreApp
{

    public class PieceProductsRepository : IProductRepository<PieceProduct>
    {
        public const string path = "pieceProducts.json";
        public List<PieceProduct> GetProducts()
        {
            if (FileSystem.IsExist(path))
            {
                if (!FileSystem.IsFileEmpty(path))
                {
                    var jsonString = FileSystem.ReadAllText(path);
                    return JsonHelper.Deserialize<List<PieceProduct>>(jsonString);
                }
                else
                {
                    var pieceProductsList = new List<PieceProduct> { };
                    FileSystem.WriteAllText(path, JsonHelper.Serialize(pieceProductsList));
                    return pieceProductsList;
                }
            }
            else
            {
                FileSystem.Create(path);
                var pieceProductsList = new List<PieceProduct> { };
                FileSystem.WriteAllText(path, JsonHelper.Serialize(pieceProductsList));
                return pieceProductsList;
            }
        }

        public void Save(PieceProduct product)
        {
            product.Validate();
            var jsonString = FileSystem.ReadAllText(path);
            var products = JsonHelper.Deserialize<List<PieceProduct>>(jsonString);
            if (products.Exists(x => x.Id == product.Id))
            {
                int index = products.FindIndex(x => x.Id == product.Id);
                products[index] = product;
            }
            else
            {
                products.Add(product);
            }
            jsonString = JsonHelper.Serialize(products);
            FileSystem.WriteAllText(path, jsonString);
        }

        public void Update(List<PieceProduct> products)
        {
            var jsonString = JsonHelper.Serialize(products);
            FileSystem.WriteAllText(path, jsonString);
        }
    }
}

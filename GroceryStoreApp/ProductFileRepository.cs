using System;
using System.Linq;
using System.Collections.Generic;

namespace GroceryStoreApp
{
    public class ProductFileRepository : IProductRepository
    {
        public const string weightProductsPath = "weightProducts.json";
        public const string pieceProductsPath = "pieceProducts.json";
        public List<WeightProduct> GetWeightProducts()
        {
            if (FileSystem.IsExist(weightProductsPath))
            {
                if (!FileSystem.IsFileEmpty(weightProductsPath))
                {
                    var jsonString = FileSystem.ReadAllText(weightProductsPath);
                    return JsonHelper.Deserialize<List<WeightProduct>>(jsonString);
                }
                else
                {
                    var weightProductsList = new List<WeightProduct> { };
                    FileSystem.WriteAllText(weightProductsPath, JsonHelper.Serialize(weightProductsList));
                    return weightProductsList;
                }
            }
            else
            {
                FileSystem.Create(weightProductsPath);
                var weightProductsList = new List<WeightProduct> { };
                FileSystem.WriteAllText(weightProductsPath, JsonHelper.Serialize(weightProductsList));
                return weightProductsList;
            }
        }
        public List<PieceProduct> GetPieceProducts()
        {
            if (FileSystem.IsExist(pieceProductsPath))
            {
                if (!FileSystem.IsFileEmpty(pieceProductsPath))
                {
                    var jsonString = FileSystem.ReadAllText(pieceProductsPath);
                    return JsonHelper.Deserialize<List<PieceProduct>>(jsonString);
                }
                else
                {
                    var pieceProductsList = new List<PieceProduct> { };
                    FileSystem.WriteAllText(pieceProductsPath, JsonHelper.Serialize(pieceProductsList));
                    return pieceProductsList;
                }
            }
            else
            {
                FileSystem.Create(pieceProductsPath);
                var pieceProductsList = new List<PieceProduct> { };
                FileSystem.WriteAllText(pieceProductsPath, JsonHelper.Serialize(pieceProductsList));
                return pieceProductsList;
            }
        }
        public void Save<T>(T product) where T : BaseProduct
        {
            Validate(product);
            string fileName = null;
            if (product is WeightProduct)
            {
                fileName = weightProductsPath;
            }
            if (product is PieceProduct)
            {
                fileName = pieceProductsPath;
            }
            try
            {
                var jsonString = FileSystem.ReadAllText(fileName);
                var products = JsonHelper.Deserialize<List<T>>(jsonString);
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
                FileSystem.WriteAllText(fileName, jsonString);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void Update<T>(List<T> products) where T : BaseProduct
        {
            string fileName = null;
            if (products is List<WeightProduct>)
            {
                fileName = weightProductsPath;
            }
            if (products is List<PieceProduct>)
            {
                fileName = pieceProductsPath;
            }
            var jsonString = JsonHelper.Serialize(products);
            FileSystem.WriteAllText(fileName, jsonString);
        }
        public void Validate<T>(T product) where T : BaseProduct
        {
            if (product.ShelfLife < DateTime.Now)
            {
                throw new Exception("Товар не может быть просрочен");
            }
            if (product.Name.Length > 100)
            {
                throw new Exception("Наименование не может быть длинее 100 символов");
            }
            if (product.Count < 0)
            {
                throw new Exception("Количество товара не может быть отрицательным");
            }
        }
    }
}

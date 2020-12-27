using System.Collections.Generic;

namespace GroceryStoreApp
{
    public class WeightProductRepository : IProductRepository<WeightProduct>
    {
        private const string path = "weightProducts.json";

        public List<WeightProduct> GetProducts()
        {
            if (FileSystem.IsExist(path))
            {
                if (!FileSystem.IsFileEmpty(path))
                {
                    var jsonString = FileSystem.ReadAllText(path);
                    return JsonHelper.Deserialize<List<WeightProduct>>(jsonString);
                }
                else
                {
                    var weightProductsList = new List<WeightProduct> { };
                    FileSystem.WriteAllText(path, JsonHelper.Serialize(weightProductsList));
                    return weightProductsList;
                }
            }
            else
            {
                FileSystem.Create(path);
                var weightProductsList = new List<WeightProduct> { };
                FileSystem.WriteAllText(path, JsonHelper.Serialize(weightProductsList));
                return weightProductsList;
            }
        }

        public void Save(WeightProduct product)
        {
            product.Validate();
            var jsonString = FileSystem.ReadAllText(path);
            var products = JsonHelper.Deserialize<List<WeightProduct>>(jsonString);
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

        public void Update(List<WeightProduct> products)
        {
            var jsonString = JsonHelper.Serialize(products);
            FileSystem.WriteAllText(path, jsonString);
        }
    }
}

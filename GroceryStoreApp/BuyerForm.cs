using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GroceryStoreApp
{
    public partial class BuyerForm : Form
    {
        IProductRepository repository;
        List<WeightProduct> weightProductsList;
        List<PieceProduct> pieceProductsList;
        public BuyerForm()
        {
            InitializeComponent();
        }
        private void BuyerForm_Load(object sender, EventArgs e)
        {
            repository = new ProductFileRepository();
            weightProductsList = repository.GetWeightProducts();
            foreach (var product in weightProductsList)
            {
                productsDataGridView.Rows.Add(product.Name, product.SalePrice, product.ShelfLife, product.Id, Classification.WeightСlasses);
            }
            pieceProductsList = repository.GetPieceProducts();
            foreach (var product in pieceProductsList)
            {
                productsDataGridView.Rows.Add(product.Name, product.SalePrice, product.ShelfLife, product.Id, Classification.SinglePieces);
            }
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            int rowIndex = productsDataGridView.CurrentRow.Index;
            if ((Classification)productsDataGridView[classificationColumn.Name, rowIndex].Value == Classification.WeightСlasses)
            {
                var product = weightProductsList[FindIndexInArray(rowIndex, weightProductsList)];
                if (!IsProductContained(product.Id))
                {
                    productsToSaleGridView.Rows.Add(product.Name, product.SalePrice, product.ShelfLife, product.Id, Classification.WeightСlasses, 1);
                }
            }
            if ((Classification)productsDataGridView[classificationColumn.Name, rowIndex].Value == Classification.SinglePieces)
            {
                var product = pieceProductsList[FindIndexInArray(rowIndex, pieceProductsList)];
                if (!IsProductContained(product.Id))
                {
                    productsToSaleGridView.Rows.Add(product.Name, product.SalePrice, product.ShelfLife, product.Id, Classification.SinglePieces, 1);
                }
            }

        }
        private void cashButton_Click(object sender, EventArgs e)
        {
            if (productsToSaleGridView.Rows.Count > 1)
            {
                productsToSaleGridView.Rows.Clear();
                MessageBox.Show("Спасибо за покупку!");
            }
            else
            {
                MessageBox.Show("Корзина пуста!");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (productsToSaleGridView.CurrentRow != null)
            {
                int rowIndex = productsToSaleGridView.CurrentRow.Index;
                if (rowIndex != productsToSaleGridView.NewRowIndex)
                {
                    var quantity = Convert.ToInt32(productsToSaleGridView[quantityColumn.Index, rowIndex].Value);
                    if (quantity > 1)
                    {
                        quantity--;
                        productsToSaleGridView[quantityColumn.Index, rowIndex].Value = quantity;
                    }
                    else
                    {
                        productsToSaleGridView.Rows.RemoveAt(rowIndex);
                    }
                }
                else
                {
                    MessageBox.Show("Не выбран товар для удаления");
                }
                
            }
            else
            {
                MessageBox.Show("Не выбран товар для удаления");
            }
            
        }
        private int FindIndexInArray<T>(int indexInTable, List<T> products) where T : BaseProduct
        {
            return products.FindIndex(x => x.Id.ToString() == productsDataGridView[guidColumn.Index, indexInTable]
        .Value.ToString());
        }
        private bool IsProductContained(Guid id)
        {
            if (productsToSaleGridView.Rows.Count > 1)
            {
                for (int i = 0; i < productsToSaleGridView.Rows.Count - 1; i++)
                {
                    if (productsToSaleGridView[guidColumn.Index, i].Value.ToString() == id.ToString())
                    {
                        int value = Convert.ToInt32(productsToSaleGridView[quantityColumn.Index, i].Value);
                        value++;
                        productsToSaleGridView[quantityColumn.Index, i].Value = value;
                        return true;
                    }
                }
            }
            return false;
        }
    }
}

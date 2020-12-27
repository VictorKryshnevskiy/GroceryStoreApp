using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GroceryStoreApp
{
    public partial class BuyerForm : Form
    {
        IProductRepository<WeightProduct> weightRepository;
        IProductRepository<PieceProduct> pieceRepository;
        List<WeightProduct> weightProductsList;
        List<PieceProduct> pieceProductsList;
        public BuyerForm()
        {
            InitializeComponent();
        }
        private void BuyerForm_Load(object sender, EventArgs e)
        {
            weightRepository = new WeightProductRepository();
            pieceRepository = new PieceProductsRepository();
            weightProductsList = weightRepository.GetProducts();
            foreach (var product in weightProductsList)
            {
                if (product.Count >= 1)
                {
                    productsDataGridView.Rows.Add(product.Name, product.SalePrice, product.ShelfLife, product.Id, Classification.WeightСlasses);
                }
            }
            pieceProductsList = pieceRepository.GetProducts();
            foreach (var product in pieceProductsList)
            {
                if (product.Count >= 1)
                {
                    productsDataGridView.Rows.Add(product.Name, product.SalePrice, product.ShelfLife, product.Id, Classification.SinglePieces);
                }
            }
        }
        private void BuyButton_Click(object sender, EventArgs e)
        {
            if (productsDataGridView.CurrentRow != null)
            {
                int rowIndex = productsDataGridView.CurrentRow.Index;
                if (rowIndex != productsDataGridView.NewRowIndex)
                {
                    if ((Classification)productsDataGridView[classificationColumn.Name, rowIndex].Value == Classification.WeightСlasses)
                    {
                        var product = weightProductsList[FindIndexInArray(rowIndex, weightProductsList)];
                        MoveProductToBasket(product, Classification.WeightСlasses);
                    }
                    if ((Classification)productsDataGridView[classificationColumn.Name, rowIndex].Value == Classification.SinglePieces)
                    {
                        var product = pieceProductsList[FindIndexInArray(rowIndex, pieceProductsList)];
                        MoveProductToBasket(product, Classification.SinglePieces);
                    }
                }
                else
                {
                    MessageBox.Show("Не выбран товар для покупки");
                }
            }
            else
            {
                MessageBox.Show("Не выбран товар для покупки");
            }

        }
        private void CashButton_Click(object sender, EventArgs e)
        {
            if (productsToSaleGridView.Rows.Count > 0)
            {
                weightRepository.Update(weightProductsList);
                pieceRepository.Update(pieceProductsList);
                productsToSaleGridView.Rows.Clear();
                MessageBox.Show("Спасибо за покупку!");
                Refresh();
            }
            else
            {
                MessageBox.Show("Корзина пуста!");
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (productsToSaleGridView.CurrentRow != null)
            {
                int rowIndex = productsToSaleGridView.CurrentRow.Index;
                if (rowIndex != productsToSaleGridView.NewRowIndex)
                {
                    if ((Classification)productsToSaleGridView[classificationColumn.Index, rowIndex].Value == Classification.WeightСlasses)
                    {
                        MoveProductBack(weightProductsList, rowIndex);
                    }
                    if ((Classification)productsToSaleGridView[classificationColumn.Index, rowIndex].Value == Classification.SinglePieces)
                    {
                        MoveProductBack(pieceProductsList, rowIndex);
                    }
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
            if (productsToSaleGridView.Rows.Count > 0)
            {
                for (int i = 0; i < productsToSaleGridView.Rows.Count; i++)
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
        private void MoveProductToBasket<T>(T product, Classification classification) where T : BaseProduct
        {
            if (product.Count > 0)
            {
                if (!IsProductContained(product.Id))
                {
                    productsToSaleGridView.Rows.Add(product.Name, product.SalePrice, product.ShelfLife, product.Id, classification, 1);
                }
                product.Count--;
            }
            else
            {
                MessageBox.Show("Товар закончился");
            }
        }
        private void MoveProductBack<T>(List<T> products, int rowIndex) where T : BaseProduct
        {
            Guid guid = (Guid)productsToSaleGridView[guidColumn.Index, rowIndex].Value;
            int productIndex = weightProductsList.FindIndex(x => x.Id == guid);
            products[productIndex].Count++;
        }
    }
}

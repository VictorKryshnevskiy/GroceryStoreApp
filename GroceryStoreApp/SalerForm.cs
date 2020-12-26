using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GroceryStoreApp
{
    public partial class SalerForm : Form
    {
        IProductRepository repository;
        List<WeightProduct> weightProductsList;
        List<PieceProduct> pieceProductsList;
        public SalerForm()
        {
            InitializeComponent();
        }
        private void SalerForm_Load(object sender, EventArgs e)
        {
            repository = new ProductFileRepository();
        }
        private void addProductButton_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.ShowDialog();
        }
        private void deleteProductButton_Click(object sender, EventArgs e)
        {
            if (productsDataGridView.CurrentRow != null)
            {
                int rowIndex = productsDataGridView.CurrentRow.Index;
                if (rowIndex != productsDataGridView.NewRowIndex)
                {
                    if ((Classification)productsDataGridView[categoryColumn.Name, rowIndex].Value == Classification.WeightСlasses)
                    {
                        DeleteProduct(rowIndex, weightProductsList);
                        return;
                    }
                    if ((Classification)productsDataGridView[categoryColumn.Name, rowIndex].Value == Classification.SinglePieces)
                    {
                        DeleteProduct(rowIndex, pieceProductsList);
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
        private void productsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = productsDataGridView.CurrentRow.Index;
            if ((Classification)productsDataGridView[categoryColumn.Name, rowIndex].Value == Classification.WeightСlasses)
            {
                GetProductToEdit(rowIndex, weightProductsList);
            }
            if ((Classification)productsDataGridView[categoryColumn.Name, rowIndex].Value == Classification.SinglePieces)
            {
                GetProductToEdit(rowIndex, pieceProductsList);
            }
        }
        public void DeleteProduct<T>(int indexInTable, List<T> products) where T : BaseProduct
        {
            int indexToDelete = FindIndexInArray(indexInTable, products);
            products.RemoveAt(indexToDelete);
            productsDataGridView.Rows.RemoveAt(indexToDelete);
            repository.Update(products);
        }
        private void GetProductToEdit<T>(int indexInTable, List<T> products) where T : BaseProduct
        {
            int indexToEdit = FindIndexInArray(indexInTable, products);
            if (products is List<PieceProduct>)
            {
                AddProductForm addProductForm = new AddProductForm(pieceProductsList[indexToEdit], Classification.SinglePieces);
                addProductForm.ShowDialog();
            }
            if (products is List<WeightProduct>)
            {
                AddProductForm addProductForm = new AddProductForm(weightProductsList[indexToEdit], Classification.WeightСlasses);
                addProductForm.ShowDialog();
            }
        }

        private int FindIndexInArray<T>(int indexInTable, List<T> products) where T : BaseProduct
        {
            return products.FindIndex(x => x.Id.ToString() == productsDataGridView[guidColumn.Index, indexInTable]
        .Value.ToString());
        }

        private void SalerForm_Activated(object sender, EventArgs e)
        {
            productsDataGridView.Rows.Clear();
            weightProductsList = repository.GetWeightProducts();
            foreach (var item in weightProductsList)
            {
                productsDataGridView.Rows.Add(item.Name, item.PurchasePrice, item.SalePrice, item.ShelfLife.ToShortDateString(), item.Count, item.Storage, item.Id, Classification.WeightСlasses);
            }
            pieceProductsList = repository.GetPieceProducts();
            foreach (var item in pieceProductsList)
            {
                productsDataGridView.Rows.Add(item.Name, item.PurchasePrice, item.SalePrice, item.ShelfLife.ToShortDateString(), item.Count, item.Storage, item.Id, Classification.SinglePieces);
            }
        }
    }
}

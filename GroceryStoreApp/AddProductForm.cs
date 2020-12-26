using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GroceryStoreApp
{
    public partial class AddProductForm : Form
    {
        IProductRepository repository;
        string weightProductsPath;
        string pieceProductsPath;
        bool isEditing;
        BaseProduct product;
        public AddProductForm(string weight, string piece)
        {
            repository = new ProductFileRepository();
            InitializeComponent();
            weightProductsPath = weight;
            pieceProductsPath = piece;
            isEditing = false;
        }
        public AddProductForm(string weight, string piece, BaseProduct product)
        {
            InitializeComponent();
            weightProductsPath = weight;
            pieceProductsPath = piece;
            isEditing = true;
            this.product = product;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var name = nameTextBox.Text;
            var purchasePrice = Convert.ToDecimal(purPriceTextBox.Text);
            var salePrice = Convert.ToDecimal(salePriceTextBox.Text);
            var shelfLife = Convert.ToDateTime(maskedTextBox1.Text);
            var quantity = Convert.ToInt32(quantityTextBox.Text);
            if ((Classification)classificationComboBox.SelectedValue == Classification.WeightСlasses)
            {
                var product = new WeightProduct(name, purchasePrice, salePrice, shelfLife, quantity);
                repository.Save(product);
            }
            if ((Classification)classificationComboBox.SelectedValue == Classification.SinglePieces)
            {
                var product = new PieceProduct(name, purchasePrice, salePrice, shelfLife, quantity);
                repository.Save(product);
            }
            MessageBox.Show("Товар успешно добавлен");
            Close();
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {
            FillComboBox(classificationComboBox);
            if (isEditing)
            {
                LoadProductInformation();
            }
        }

        private void LoadProductInformation()
        {
            if (product != null)
            {
                nameTextBox.Text = product.Name;
                purPriceTextBox.Text = product.PurchasePrice.ToString();
                salePriceTextBox.Text = product.SalePrice.ToString();
                maskedTextBox1.Text = product.ShelfLife.ToString();
              // quantityTextBox.Text= product.
            }
        }

        private static void FillComboBox(ComboBox comboBox)
        {
            comboBox.DisplayMember = "Description";
            comboBox.ValueMember = "Value";
            comboBox.DataSource = Enum.GetValues(typeof(Classification)).Cast<Enum>().Select(value => new
            {
                (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                value
            })
             .OrderBy(item => item.value)
             .ToList();
        }
    }
}

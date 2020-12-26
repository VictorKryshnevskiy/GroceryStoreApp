using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GroceryStoreApp
{
    public partial class AddProductForm : Form
    {
        IProductRepository repository;
        bool isEditing;
        BaseProduct product;
        Classification classification;
        public AddProductForm()
        {
            InitializeComponent();
            repository = new ProductFileRepository();
            isEditing = false;
        }
        public AddProductForm(PieceProduct product)
        {
            InitializeComponent();
            repository = new ProductFileRepository();
            isEditing = true;
            this.product = product;
            classification = Classification.SinglePieces;
        }
        public AddProductForm(WeightProduct product)
        {
            InitializeComponent();
            repository = new ProductFileRepository();
            isEditing = true;
            this.product = product;
            classification = Classification.WeightСlasses;
        }
        private void saveButton_Click(object sender, EventArgs e)
        {

            try
            {
                var name = nameTextBox.Text;
                var purchasePrice = Convert.ToDecimal(purPriceTextBox.Text);
                var salePrice = Convert.ToDecimal(salePriceTextBox.Text);
                var shelfLife = Convert.ToDateTime(shelfLifeMaskedTextBox.Text);
                var quantity = Convert.ToInt32(quantityTextBox.Text);
                if (!isEditing)
                {
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
                }
                else
                {
                    if ((Classification)classificationComboBox.SelectedValue == Classification.WeightСlasses)
                    {
                        product.Name = name;
                        product.PurchasePrice = purchasePrice;
                        product.SalePrice = salePrice;
                        product.ShelfLife = shelfLife;
                        product.Count = quantity;
                        repository.Save(product as WeightProduct);
                    }
                    if ((Classification)classificationComboBox.SelectedValue == Classification.SinglePieces)
                    {
                        product.Name = name;
                        product.PurchasePrice = purchasePrice;
                        product.SalePrice = salePrice;
                        product.ShelfLife = shelfLife;
                        product.Count = quantity;
                        repository.Save(product as PieceProduct);
                    }
                }
                MessageBox.Show("Товар успешно добавлен");
                Close();
            }
            catch (FormatException )
            { MessageBox.Show("Убедитесь в правильности заполнения полей, все поля должны быть заполнены"); }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                shelfLifeMaskedTextBox.Text = product.ShelfLife.ToString();
                quantityTextBox.Text = product.Count.ToString();
                classificationComboBox.SelectedValue = classification;
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
        private void purPriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44) 
            {
                e.Handled = true;
            }
        }
        private void salePriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }
        private void quantityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) 
            {
                e.Handled = true;
            }
        }

        private void nameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (nameTextBox.Text.Trim() == "")
                errorProvider.SetError(nameTextBox, "Введите значение");
            else
                errorProvider.SetError(nameTextBox, "");
        }

        private void purPriceTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (purPriceTextBox.Text.Trim() == "")
                errorProvider.SetError(purPriceTextBox, "Введите значение");
            else
                errorProvider.SetError(purPriceTextBox, "");
        }

        private void salePriceTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (salePriceTextBox.Text.Trim() == "")
                errorProvider.SetError(salePriceTextBox, "Введите значение");
            else
                errorProvider.SetError(salePriceTextBox, "");
        }
        private void quantityTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (quantityTextBox.Text.Trim() == "")
                errorProvider.SetError(quantityTextBox, "Введите значение");
            else
                errorProvider.SetError(quantityTextBox, "");
        }
    }
}

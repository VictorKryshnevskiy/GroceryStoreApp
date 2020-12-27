using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GroceryStoreApp
{
    public partial class AddProductForm : Form
    {
        private readonly IProductRepository<WeightProduct> weightRepository;
        private readonly IProductRepository<PieceProduct> pieceRepository;
        private readonly bool isEditing;
        private readonly BaseProduct product;
        public AddProductForm(bool isEditing = false)
        {
            InitializeComponent();
            weightRepository = new WeightProductRepository();
            pieceRepository = new PieceProductsRepository();
            this.isEditing = isEditing;
        }
        public AddProductForm(BaseProduct product) : this(true)
        {
            this.product = product;
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                var name = nameTextBox.Text;
                var purchasePrice = Convert.ToDecimal(purPriceTextBox.Text);
                var salePrice = Convert.ToDecimal(salePriceTextBox.Text);
                var shelfLife = Convert.ToDateTime(shelfLifeMaskedTextBox.Text).Date;
                var quantity = Convert.ToInt32(quantityTextBox.Text);
                if (!isEditing)
                {
                    if ((Classification)classificationComboBox.SelectedValue == Classification.WeightСlasses)
                    {
                        var product = new WeightProduct(name, purchasePrice, salePrice, shelfLife, quantity);
                        weightRepository.Save(product);
                    }
                    if ((Classification)classificationComboBox.SelectedValue == Classification.SinglePieces)
                    {
                        var product = new PieceProduct(name, purchasePrice, salePrice, shelfLife, quantity);
                        pieceRepository.Save(product);
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
                        weightRepository.Save(product as WeightProduct);
                    }
                    if ((Classification)classificationComboBox.SelectedValue == Classification.SinglePieces)
                    {
                        product.Name = name;
                        product.PurchasePrice = purchasePrice;
                        product.SalePrice = salePrice;
                        product.ShelfLife = shelfLife;
                        product.Count = quantity;
                        pieceRepository.Save(product as PieceProduct);
                    }
                }
                MessageBox.Show("Товар успешно добавлен");
                Close();
            }
            catch (FormatException)
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
                shelfLifeMaskedTextBox.Text = product.ShelfLife.ToShortDateString();
                quantityTextBox.Text = product.Count.ToString();
                if (product is WeightProduct)
                {
                    classificationComboBox.SelectedValue = Classification.WeightСlasses;
                }
                if (product is PieceProduct)
                {
                    classificationComboBox.SelectedValue = Classification.SinglePieces;
                }
                classificationComboBox.Enabled = false;
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
        private void PurPriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            int commaNumber = 44;
            int backSpaseNumber = 8;
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != backSpaseNumber && number != commaNumber)
            {
                e.Handled = true;
            }
        }
        private void SalePriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            int commaNumber = 44;
            int backSpaseNumber = 8;
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != backSpaseNumber && number != commaNumber)
            {
                e.Handled = true;
            }
        }
        private void QuantityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            int backSpaseNumber = 8;
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != backSpaseNumber)
            {
                e.Handled = true;
            }
        }

        private void NameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (nameTextBox.Text.Trim() == "")
                errorProvider.SetError(nameTextBox, "Введите значение");
            else
                errorProvider.SetError(nameTextBox, "");
        }

        private void PurPriceTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (purPriceTextBox.Text.Trim() == "")
                errorProvider.SetError(purPriceTextBox, "Введите значение");
            else
                errorProvider.SetError(purPriceTextBox, "");
        }

        private void SalePriceTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (salePriceTextBox.Text.Trim() == "")
                errorProvider.SetError(salePriceTextBox, "Введите значение");
            else
                errorProvider.SetError(salePriceTextBox, "");
        }
        private void QuantityTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (quantityTextBox.Text.Trim() == "")
                errorProvider.SetError(quantityTextBox, "Введите значение");
            else
                errorProvider.SetError(quantityTextBox, "");
        }
    }
}

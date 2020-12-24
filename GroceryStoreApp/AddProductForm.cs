using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroceryStoreApp
{
    public partial class AddProductForm : Form
    {
        string docpath;
        public AddProductForm(string file)
        {
            InitializeComponent();
            docpath = file;
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
                var jsonString = FileSystem.ReadAllText(docpath);
                var products = JsonHelper.Deserialize<List<WeightProduct>>(jsonString);
                var product = new WeightProduct(name, purchasePrice, salePrice, shelfLife, quantity);
                products.Add(product);
                jsonString = JsonHelper.Serialize(product);
                FileSystem.WriteAllText(docpath, jsonString);
            }
            if ((Classification)classificationComboBox.SelectedValue == Classification.SinglePieces)
            {
                var jsonString = FileSystem.ReadAllText(docpath);
                var products = JsonHelper.Deserialize<List<PieceProduct>>(jsonString);
                var product = new PieceProduct(name, purchasePrice, salePrice, shelfLife, quantity);
                products.Add(product);
                jsonString = JsonHelper.Serialize(product);
                FileSystem.WriteAllText(docpath, jsonString);
            }
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {
            FillComboBox(classificationComboBox);
        }
        private void FillComboBox(ComboBox comboBox)
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

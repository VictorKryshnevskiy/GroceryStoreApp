using System;
using System.Windows.Forms;

namespace GroceryStoreApp
{
    public partial class MainForm : Form
    {
        const string weightProducts = "weightProducts.json";
        const string pieceProducts = "pieceProducts.json";
        public MainForm()
        {
            InitializeComponent();
        }

        private void confirmUserButton_Click(object sender, EventArgs e)
        {
            if (selectUserComboBox.SelectedItem != null)
            {
                if (selectUserComboBox.Text == "Покупатель")
                {
                    BuyerForm buyerForm = new BuyerForm(weightProducts, pieceProducts);
                    buyerForm.ShowDialog();
                }
                if (selectUserComboBox.Text == "Продавец")
                {
                    SalerForm salerForm = new SalerForm(weightProducts, pieceProducts);
                    salerForm.Show();
                }
            }
        }
    }
}

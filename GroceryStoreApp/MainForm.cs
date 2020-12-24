using System;
using System.Windows.Forms;

namespace GroceryStoreApp
{
    public partial class MainForm : Form
    {
        const string docPath = "";
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
                    BuyerForm buyerForm = new BuyerForm(docPath);
                    buyerForm.ShowDialog();
                }
                if (selectUserComboBox.Text == "Продавец")
                {
                    SalerForm salerForm = new SalerForm(docPath);
                    salerForm.Show();
                }
            }
        }
    }
}

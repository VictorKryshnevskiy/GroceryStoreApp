using System;
using System.Windows.Forms;

namespace GroceryStoreApp
{
    public partial class SalerForm : Form
    {
        string docPath ;
        public SalerForm()
        {
            InitializeComponent();
        }
        public SalerForm(string file)
        {
            docPath = file;
            InitializeComponent();
        }
        private void SalerForm_Load(object sender, EventArgs e)
        {
            if (FileSystem.IsExist(docPath))
            {

            }
            else
            {
                FileSystem.Create(docPath);
            }
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.ShowDialog();
        }
    }
}

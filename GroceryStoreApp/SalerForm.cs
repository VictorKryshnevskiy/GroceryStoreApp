using System;
using System.Collections.Generic;
using System.IO;
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
                if (!FileSystem.IsFileEmpty(docPath))
                {
                    var products = JsonHelper.Deserialize<List<Product>>(FileSystem.ReadAllText(docPath));
                    foreach (var item in products)
                    {
                        productsDataGridView.Rows.Add(item);
                    }
                }
            }
            else
            {
                FileSystem.Create(docPath);
            }
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm(docPath);
            addProductForm.ShowDialog();
        }
    }
}

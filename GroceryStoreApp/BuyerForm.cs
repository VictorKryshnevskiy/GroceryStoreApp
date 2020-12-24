using System;
using System.Windows.Forms;

namespace GroceryStoreApp
{
    public partial class BuyerForm : Form
    {
        readonly string docPath;
        public BuyerForm()
        {
            InitializeComponent();
        }
        public BuyerForm(string file)
        {
            docPath = file;
            InitializeComponent();
        }

        private void BuyerForm_Load(object sender, EventArgs e)
        {
            if (FileSystem.IsExist(docPath))
            {

            }
            else
            {
                FileSystem.Create(docPath);
            }
        }
    }
}

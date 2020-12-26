using System;
using System.Windows.Forms;

namespace GroceryStoreApp
{
    public partial class BuyerForm : Form
    {
        string weightProducts;
        string pieceProducts;

        public BuyerForm()
        {
            InitializeComponent();
        }
        public BuyerForm(string weight, string piece)
        {
            weightProducts = weight;
            pieceProducts = piece;
            InitializeComponent();
        }

        private void BuyerForm_Load(object sender, EventArgs e)
        {
            if (FileSystem.IsExist(weightProducts))
            {

            }
            else
            {
                FileSystem.Create(weightProducts);
            }
        }
    }
}

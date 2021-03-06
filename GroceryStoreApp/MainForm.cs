﻿using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace GroceryStoreApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ConfirmUserButton_Click(object sender, EventArgs e)
        {
            var selectedValue = (Users)selectUserComboBox.SelectedValue;
            if (selectUserComboBox.SelectedItem != null)
            {
                if (selectedValue == Users.Buyer)
                {
                    BuyerForm buyerForm = new BuyerForm();
                    buyerForm.ShowDialog();
                }
                if (selectedValue == Users.Saler)
                {
                    SalerForm salerForm = new SalerForm();
                    salerForm.ShowDialog();
                }
            }
        }
        private static void FillComboBox(ComboBox comboBox)
        {
            comboBox.DisplayMember = "Description";
            comboBox.ValueMember = "Value";
            comboBox.DataSource = Enum.GetValues(typeof(Users)).Cast<Enum>().Select(value => new
            {
                (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                value
            })
             .OrderBy(item => item.value)
             .ToList();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            FillComboBox(selectUserComboBox);
        }
    }
}

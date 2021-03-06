﻿
namespace GroceryStoreApp
{
    partial class AddProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.purPriceTextBox = new System.Windows.Forms.TextBox();
            this.salePriceTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.classificationComboBox = new System.Windows.Forms.ComboBox();
            this.productCategoryLabel = new System.Windows.Forms.Label();
            this.shelfLifeMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(159, 12);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(221, 23);
            this.nameTextBox.TabIndex = 0;
            this.nameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.NameTextBox_Validating);
            // 
            // purPriceTextBox
            // 
            this.purPriceTextBox.Location = new System.Drawing.Point(159, 41);
            this.purPriceTextBox.Name = "purPriceTextBox";
            this.purPriceTextBox.Size = new System.Drawing.Size(221, 23);
            this.purPriceTextBox.TabIndex = 1;
            this.purPriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PurPriceTextBox_KeyPress);
            this.purPriceTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.PurPriceTextBox_Validating);
            // 
            // salePriceTextBox
            // 
            this.salePriceTextBox.Location = new System.Drawing.Point(159, 70);
            this.salePriceTextBox.Name = "salePriceTextBox";
            this.salePriceTextBox.Size = new System.Drawing.Size(221, 23);
            this.salePriceTextBox.TabIndex = 2;
            this.salePriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SalePriceTextBox_KeyPress);
            this.salePriceTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.SalePriceTextBox_Validating);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(45, 20);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(90, 15);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Наименование";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(45, 49);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(81, 15);
            this.label.TabIndex = 5;
            this.label.Text = "Цена закупки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Цена реализации";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Срок хранения";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(395, 338);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // classificationComboBox
            // 
            this.classificationComboBox.FormattingEnabled = true;
            this.classificationComboBox.Location = new System.Drawing.Point(159, 99);
            this.classificationComboBox.Name = "classificationComboBox";
            this.classificationComboBox.Size = new System.Drawing.Size(221, 23);
            this.classificationComboBox.TabIndex = 9;
            // 
            // productCategoryLabel
            // 
            this.productCategoryLabel.AutoSize = true;
            this.productCategoryLabel.Location = new System.Drawing.Point(45, 107);
            this.productCategoryLabel.Name = "productCategoryLabel";
            this.productCategoryLabel.Size = new System.Drawing.Size(94, 15);
            this.productCategoryLabel.TabIndex = 10;
            this.productCategoryLabel.Text = "Классификация";
            // 
            // shelfLifeMaskedTextBox
            // 
            this.shelfLifeMaskedTextBox.Location = new System.Drawing.Point(159, 128);
            this.shelfLifeMaskedTextBox.Mask = "00/00/0000";
            this.shelfLifeMaskedTextBox.Name = "shelfLifeMaskedTextBox";
            this.shelfLifeMaskedTextBox.Size = new System.Drawing.Size(221, 23);
            this.shelfLifeMaskedTextBox.TabIndex = 11;
            this.shelfLifeMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(45, 165);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(72, 15);
            this.quantityLabel.TabIndex = 12;
            this.quantityLabel.Text = "Количество";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(159, 158);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(221, 23);
            this.quantityTextBox.TabIndex = 13;
            this.quantityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.QuantityTextBox_KeyPress);
            this.quantityTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.QuantityTextBox_Validating);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 386);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.shelfLifeMaskedTextBox);
            this.Controls.Add(this.productCategoryLabel);
            this.Controls.Add(this.classificationComboBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.salePriceTextBox);
            this.Controls.Add(this.purPriceTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Name = "AddProductForm";
            this.Text = "AddProductForm";
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox purPriceTextBox;
        private System.Windows.Forms.TextBox salePriceTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ComboBox classificationComboBox;
        private System.Windows.Forms.Label productCategoryLabel;
        private System.Windows.Forms.MaskedTextBox shelfLifeMaskedTextBox;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

namespace GroceryStoreApp
{
    partial class SalerForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addProductButton = new System.Windows.Forms.Button();
            this.deleteProductButton = new System.Windows.Forms.Button();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchasePriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salePriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shelfLifeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameColumn,
            this.purchasePriceColumn,
            this.salePriceColumn,
            this.shelfLifeColumn});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(766, 349);
            this.dataGridView1.TabIndex = 2;
            // 
            // addProductButton
            // 
            this.addProductButton.Location = new System.Drawing.Point(610, 399);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(86, 39);
            this.addProductButton.TabIndex = 3;
            this.addProductButton.Text = "Добавить товар";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // deleteProductButton
            // 
            this.deleteProductButton.Location = new System.Drawing.Point(702, 400);
            this.deleteProductButton.Name = "deleteProductButton";
            this.deleteProductButton.Size = new System.Drawing.Size(86, 38);
            this.deleteProductButton.TabIndex = 4;
            this.deleteProductButton.Text = "Удалить товар";
            this.deleteProductButton.UseVisualStyleBackColor = true;
            // 
            // nameColumn
            // 
            this.nameColumn.HeaderText = "Наименование";
            this.nameColumn.Name = "nameColumn";
            // 
            // purchasePriceColumn
            // 
            this.purchasePriceColumn.HeaderText = "Закупочная цена";
            this.purchasePriceColumn.Name = "purchasePriceColumn";
            // 
            // salePriceColumn
            // 
            this.salePriceColumn.HeaderText = "Розничная цена";
            this.salePriceColumn.Name = "salePriceColumn";
            // 
            // shelfLifeColumn
            // 
            this.shelfLifeColumn.HeaderText = "Срок хранения";
            this.shelfLifeColumn.Name = "shelfLifeColumn";
            // 
            // SalerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteProductButton);
            this.Controls.Add(this.addProductButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SalerForm";
            this.Text = "SalerForm";
            this.Load += new System.EventHandler(this.SalerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Button deleteProductButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchasePriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salePriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shelfLifeColumn;
    }
}

namespace GroceryStoreApp
{
    partial class BuyerForm
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
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salePriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shelfLifeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyButton = new System.Windows.Forms.Button();
            this.cashButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsListLabel = new System.Windows.Forms.Label();
            this.purchaseListlabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // productsDataGridView
            // 
            this.productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameColumn,
            this.salePriceColumn,
            this.shelfLifeColumn});
            this.productsDataGridView.Location = new System.Drawing.Point(12, 30);
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.RowTemplate.Height = 25;
            this.productsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productsDataGridView.Size = new System.Drawing.Size(364, 349);
            this.productsDataGridView.TabIndex = 3;
            // 
            // nameColumn
            // 
            this.nameColumn.HeaderText = "Наименование";
            this.nameColumn.Name = "nameColumn";
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
            // buyButton
            // 
            this.buyButton.Location = new System.Drawing.Point(301, 385);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(75, 23);
            this.buyButton.TabIndex = 5;
            this.buyButton.Text = "Купить";
            this.buyButton.UseVisualStyleBackColor = true;
            // 
            // cashButton
            // 
            this.cashButton.Location = new System.Drawing.Point(734, 385);
            this.cashButton.Name = "cashButton";
            this.cashButton.Size = new System.Drawing.Size(75, 23);
            this.cashButton.TabIndex = 6;
            this.cashButton.Text = "Оплатить";
            this.cashButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView1.Location = new System.Drawing.Point(445, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(364, 349);
            this.dataGridView1.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Наименование";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Розничная цена";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Срок хранения";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // productsListLabel
            // 
            this.productsListLabel.AutoSize = true;
            this.productsListLabel.Location = new System.Drawing.Point(151, 9);
            this.productsListLabel.Name = "productsListLabel";
            this.productsListLabel.Size = new System.Drawing.Size(80, 15);
            this.productsListLabel.TabIndex = 8;
            this.productsListLabel.Text = "Ассортимент";
            // 
            // purchaseListlabel
            // 
            this.purchaseListlabel.AutoSize = true;
            this.purchaseListlabel.Location = new System.Drawing.Point(612, 9);
            this.purchaseListlabel.Name = "purchaseListlabel";
            this.purchaseListlabel.Size = new System.Drawing.Size(53, 15);
            this.purchaseListlabel.TabIndex = 9;
            this.purchaseListlabel.Text = "Корзина";
            // 
            // BuyerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 450);
            this.Controls.Add(this.purchaseListlabel);
            this.Controls.Add(this.productsListLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cashButton);
            this.Controls.Add(this.buyButton);
            this.Controls.Add(this.productsDataGridView);
            this.Name = "BuyerForm";
            this.Text = "BuyerForm";
            this.Load += new System.EventHandler(this.BuyerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView productsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salePriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shelfLifeColumn;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.Button cashButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label productsListLabel;
        private System.Windows.Forms.Label purchaseListlabel;
    }
}
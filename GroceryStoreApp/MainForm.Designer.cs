
namespace GroceryStoreApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.selectUserLabel = new System.Windows.Forms.Label();
            this.selectUserComboBox = new System.Windows.Forms.ComboBox();
            this.confirmUserButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selectUserLabel
            // 
            this.selectUserLabel.AutoSize = true;
            this.selectUserLabel.Location = new System.Drawing.Point(88, 99);
            this.selectUserLabel.Name = "selectUserLabel";
            this.selectUserLabel.Size = new System.Drawing.Size(64, 15);
            this.selectUserLabel.TabIndex = 0;
            this.selectUserLabel.Text = "Войти как:";
            // 
            // selectUserComboBox
            // 
            this.selectUserComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectUserComboBox.FormattingEnabled = true;
            this.selectUserComboBox.Items.AddRange(new object[] {
            "Покупатель",
            "Продавец"});
            this.selectUserComboBox.Location = new System.Drawing.Point(88, 132);
            this.selectUserComboBox.Name = "selectUserComboBox";
            this.selectUserComboBox.Size = new System.Drawing.Size(116, 23);
            this.selectUserComboBox.TabIndex = 1;
            // 
            // confirmUserButton
            // 
            this.confirmUserButton.Location = new System.Drawing.Point(88, 180);
            this.confirmUserButton.Name = "confirmUserButton";
            this.confirmUserButton.Size = new System.Drawing.Size(116, 23);
            this.confirmUserButton.TabIndex = 2;
            this.confirmUserButton.Text = "Далее";
            this.confirmUserButton.UseVisualStyleBackColor = true;
            this.confirmUserButton.Click += new System.EventHandler(this.confirmUserButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 296);
            this.Controls.Add(this.confirmUserButton);
            this.Controls.Add(this.selectUserComboBox);
            this.Controls.Add(this.selectUserLabel);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label selectUserLabel;
        private System.Windows.Forms.ComboBox selectUserComboBox;
        private System.Windows.Forms.Button confirmUserButton;
    }
}


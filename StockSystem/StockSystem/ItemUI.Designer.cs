namespace StockSystem
{
    partial class ItemSetup
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ItemCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemReorderLevelTextBox = new System.Windows.Forms.TextBox();
            this.ItemSaveButton = new System.Windows.Forms.Button();
            this.ItemCompanyComboBox = new System.Windows.Forms.ComboBox();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.companyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Company";
            // 
            // ItemCategoryComboBox
            // 
            this.ItemCategoryComboBox.DataSource = this.categoryBindingSource;
            this.ItemCategoryComboBox.DisplayMember = "CategoryName";
            this.ItemCategoryComboBox.FormattingEnabled = true;
            this.ItemCategoryComboBox.Location = new System.Drawing.Point(102, 36);
            this.ItemCategoryComboBox.Name = "ItemCategoryComboBox";
            this.ItemCategoryComboBox.Size = new System.Drawing.Size(121, 21);
            this.ItemCategoryComboBox.TabIndex = 2;
            this.ItemCategoryComboBox.ValueMember = "CategoryID";
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(StockSystem.Models.Category);
            // 
            // itemReorderLevelTextBox
            // 
            this.itemReorderLevelTextBox.Location = new System.Drawing.Point(102, 132);
            this.itemReorderLevelTextBox.Name = "itemReorderLevelTextBox";
            this.itemReorderLevelTextBox.Size = new System.Drawing.Size(121, 20);
            this.itemReorderLevelTextBox.TabIndex = 3;
            // 
            // ItemSaveButton
            // 
            this.ItemSaveButton.Location = new System.Drawing.Point(206, 174);
            this.ItemSaveButton.Name = "ItemSaveButton";
            this.ItemSaveButton.Size = new System.Drawing.Size(75, 23);
            this.ItemSaveButton.TabIndex = 4;
            this.ItemSaveButton.Text = "Save";
            this.ItemSaveButton.UseVisualStyleBackColor = true;
            this.ItemSaveButton.Click += new System.EventHandler(this.ItemSaveButton_Click);
            // 
            // ItemCompanyComboBox
            // 
            this.ItemCompanyComboBox.DataSource = this.companyBindingSource1;
            this.ItemCompanyComboBox.DisplayMember = "CompanyName";
            this.ItemCompanyComboBox.FormattingEnabled = true;
            this.ItemCompanyComboBox.Location = new System.Drawing.Point(102, 68);
            this.ItemCompanyComboBox.Name = "ItemCompanyComboBox";
            this.ItemCompanyComboBox.Size = new System.Drawing.Size(121, 21);
            this.ItemCompanyComboBox.TabIndex = 5;
            this.ItemCompanyComboBox.ValueMember = "CompanyID";
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataSource = typeof(StockSystem.Models.Company);
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.Location = new System.Drawing.Point(102, 102);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.Size = new System.Drawing.Size(121, 20);
            this.itemNameTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Item Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Reorder";
            // 
            // companyBindingSource1
            // 
            this.companyBindingSource1.DataSource = typeof(StockSystem.Models.Company);
            // 
            // ItemSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 260);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.itemNameTextBox);
            this.Controls.Add(this.ItemCompanyComboBox);
            this.Controls.Add(this.ItemSaveButton);
            this.Controls.Add(this.itemReorderLevelTextBox);
            this.Controls.Add(this.ItemCategoryComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ItemSetup";
            this.Text = "Item Setup";
            this.Load += new System.EventHandler(this.ItemSetup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ItemCategoryComboBox;
        private System.Windows.Forms.TextBox itemReorderLevelTextBox;
        private System.Windows.Forms.Button ItemSaveButton;
        private System.Windows.Forms.ComboBox ItemCompanyComboBox;
        private System.Windows.Forms.TextBox itemNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private System.Windows.Forms.BindingSource companyBindingSource1;
    }
}
namespace StockSystem
{
    partial class StockInUI
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
            this.StockInCompanycomboBox = new System.Windows.Forms.ComboBox();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StockInCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // StockInCompanycomboBox
            // 
            this.StockInCompanycomboBox.DataSource = this.companyBindingSource;
            this.StockInCompanycomboBox.DisplayMember = "CompanyName";
            this.StockInCompanycomboBox.FormattingEnabled = true;
            this.StockInCompanycomboBox.Location = new System.Drawing.Point(135, 12);
            this.StockInCompanycomboBox.Name = "StockInCompanycomboBox";
            this.StockInCompanycomboBox.Size = new System.Drawing.Size(121, 21);
            this.StockInCompanycomboBox.TabIndex = 0;
            this.StockInCompanycomboBox.ValueMember = "CompanyID";
            this.StockInCompanycomboBox.SelectedIndexChanged += new System.EventHandler(this.StockInCompanycomboBox_SelectedIndexChanged);
            this.StockInCompanycomboBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.StockInCompanycomboBox_MouseClick);
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataSource = typeof(StockSystem.Models.Company);
            // 
            // StockInCategoryComboBox
            // 
            this.StockInCategoryComboBox.DataSource = this.categoryBindingSource;
            this.StockInCategoryComboBox.DisplayMember = "CategoryName";
            this.StockInCategoryComboBox.FormattingEnabled = true;
            this.StockInCategoryComboBox.Location = new System.Drawing.Point(135, 57);
            this.StockInCategoryComboBox.Name = "StockInCategoryComboBox";
            this.StockInCategoryComboBox.Size = new System.Drawing.Size(121, 21);
            this.StockInCategoryComboBox.TabIndex = 1;
            this.StockInCategoryComboBox.ValueMember = "CategoryID";
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(StockSystem.Models.Category);
            // 
            // StockInUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 255);
            this.Controls.Add(this.StockInCategoryComboBox);
            this.Controls.Add(this.StockInCompanycomboBox);
            this.Name = "StockInUI";
            this.Text = "StockInUI";
            this.Load += new System.EventHandler(this.StockInUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox StockInCompanycomboBox;
        private System.Windows.Forms.ComboBox StockInCategoryComboBox;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private System.Windows.Forms.BindingSource categoryBindingSource;
    }
}
namespace StockSystem
{
    partial class Form1
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
            this.ButtonCategory = new System.Windows.Forms.Button();
            this.ButtonCompany = new System.Windows.Forms.Button();
            this.ButtonItem = new System.Windows.Forms.Button();
            this.ButtonStockIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonCategory
            // 
            this.ButtonCategory.Location = new System.Drawing.Point(23, 33);
            this.ButtonCategory.Name = "ButtonCategory";
            this.ButtonCategory.Size = new System.Drawing.Size(102, 30);
            this.ButtonCategory.TabIndex = 0;
            this.ButtonCategory.Text = "Category";
            this.ButtonCategory.UseVisualStyleBackColor = true;
            this.ButtonCategory.Click += new System.EventHandler(this.ButtonCategory_Click);
            // 
            // ButtonCompany
            // 
            this.ButtonCompany.Location = new System.Drawing.Point(140, 33);
            this.ButtonCompany.Name = "ButtonCompany";
            this.ButtonCompany.Size = new System.Drawing.Size(109, 30);
            this.ButtonCompany.TabIndex = 1;
            this.ButtonCompany.Text = "Company";
            this.ButtonCompany.UseVisualStyleBackColor = true;
            this.ButtonCompany.Click += new System.EventHandler(this.ButtonCompany_Click);
            // 
            // ButtonItem
            // 
            this.ButtonItem.Location = new System.Drawing.Point(265, 33);
            this.ButtonItem.Name = "ButtonItem";
            this.ButtonItem.Size = new System.Drawing.Size(109, 30);
            this.ButtonItem.TabIndex = 2;
            this.ButtonItem.Text = "Item";
            this.ButtonItem.UseVisualStyleBackColor = true;
            this.ButtonItem.Click += new System.EventHandler(this.ButtonItem_Click);
            // 
            // ButtonStockIn
            // 
            this.ButtonStockIn.Location = new System.Drawing.Point(380, 33);
            this.ButtonStockIn.Name = "ButtonStockIn";
            this.ButtonStockIn.Size = new System.Drawing.Size(109, 29);
            this.ButtonStockIn.TabIndex = 3;
            this.ButtonStockIn.Text = "Stock In";
            this.ButtonStockIn.UseVisualStyleBackColor = true;
            this.ButtonStockIn.Click += new System.EventHandler(this.ButtonStockIn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 261);
            this.Controls.Add(this.ButtonStockIn);
            this.Controls.Add(this.ButtonItem);
            this.Controls.Add(this.ButtonCompany);
            this.Controls.Add(this.ButtonCategory);
            this.Name = "Form1";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonCategory;
        private System.Windows.Forms.Button ButtonCompany;
        private System.Windows.Forms.Button ButtonItem;
        private System.Windows.Forms.Button ButtonStockIn;
    }
}
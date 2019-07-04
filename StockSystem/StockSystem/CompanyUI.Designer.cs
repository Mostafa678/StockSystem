namespace StockSystem
{
    partial class CompanySetup
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
            this.CompanyNameLabel = new System.Windows.Forms.Label();
            this.companyNameTextBox = new System.Windows.Forms.TextBox();
            this.CompanySaveButton = new System.Windows.Forms.Button();
            this.ComapnyShowDataGridView = new System.Windows.Forms.DataGridView();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ComapnyShowDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CompanyNameLabel
            // 
            this.CompanyNameLabel.AutoSize = true;
            this.CompanyNameLabel.Location = new System.Drawing.Point(12, 29);
            this.CompanyNameLabel.Name = "CompanyNameLabel";
            this.CompanyNameLabel.Size = new System.Drawing.Size(35, 13);
            this.CompanyNameLabel.TabIndex = 0;
            this.CompanyNameLabel.Text = "Name";
            // 
            // companyNameTextBox
            // 
            this.companyNameTextBox.Location = new System.Drawing.Point(74, 22);
            this.companyNameTextBox.Name = "companyNameTextBox";
            this.companyNameTextBox.Size = new System.Drawing.Size(140, 20);
            this.companyNameTextBox.TabIndex = 1;
            // 
            // CompanySaveButton
            // 
            this.CompanySaveButton.Location = new System.Drawing.Point(139, 59);
            this.CompanySaveButton.Name = "CompanySaveButton";
            this.CompanySaveButton.Size = new System.Drawing.Size(75, 23);
            this.CompanySaveButton.TabIndex = 2;
            this.CompanySaveButton.Text = "Save";
            this.CompanySaveButton.UseVisualStyleBackColor = true;
            this.CompanySaveButton.Click += new System.EventHandler(this.CompanySaveButton_Click);
            // 
            // ComapnyShowDataGridView
            // 
            this.ComapnyShowDataGridView.AllowUserToAddRows = false;
            this.ComapnyShowDataGridView.AutoGenerateColumns = false;
            this.ComapnyShowDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ComapnyShowDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SL,
            this.companyNameDataGridViewTextBoxColumn,
            this.companyIDDataGridViewTextBoxColumn});
            this.ComapnyShowDataGridView.DataSource = this.companyBindingSource;
            this.ComapnyShowDataGridView.Location = new System.Drawing.Point(51, 108);
            this.ComapnyShowDataGridView.Name = "ComapnyShowDataGridView";
            this.ComapnyShowDataGridView.Size = new System.Drawing.Size(345, 158);
            this.ComapnyShowDataGridView.TabIndex = 3;
            this.ComapnyShowDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.ComapnyShowDataGridView_CellEndEdit);
            this.ComapnyShowDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ComapnyShowDataGridView_CellMouseClick);
            this.ComapnyShowDataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.ComapnyShowDataGridView_RowPostPaint);
            // 
            // SL
            // 
            this.SL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SL.HeaderText = "SL";
            this.SL.Name = "SL";
            // 
            // companyNameDataGridViewTextBoxColumn
            // 
            this.companyNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.companyNameDataGridViewTextBoxColumn.DataPropertyName = "CompanyName";
            this.companyNameDataGridViewTextBoxColumn.HeaderText = "CompanyName";
            this.companyNameDataGridViewTextBoxColumn.Name = "companyNameDataGridViewTextBoxColumn";
            // 
            // companyIDDataGridViewTextBoxColumn
            // 
            this.companyIDDataGridViewTextBoxColumn.DataPropertyName = "CompanyID";
            this.companyIDDataGridViewTextBoxColumn.HeaderText = "CompanyID";
            this.companyIDDataGridViewTextBoxColumn.Name = "companyIDDataGridViewTextBoxColumn";
            this.companyIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataSource = typeof(StockSystem.Models.Company);
            // 
            // CompanySetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 291);
            this.Controls.Add(this.ComapnyShowDataGridView);
            this.Controls.Add(this.CompanySaveButton);
            this.Controls.Add(this.companyNameTextBox);
            this.Controls.Add(this.CompanyNameLabel);
            this.Name = "CompanySetup";
            this.Text = "Company Setup";
            this.Load += new System.EventHandler(this.CompanySetup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ComapnyShowDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CompanyNameLabel;
        private System.Windows.Forms.TextBox companyNameTextBox;
        private System.Windows.Forms.Button CompanySaveButton;
        private System.Windows.Forms.DataGridView ComapnyShowDataGridView;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyIDDataGridViewTextBoxColumn;
    }
}
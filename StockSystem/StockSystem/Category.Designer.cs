namespace StockSystem
{
    partial class CatagorySetup
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
            this.categoryNameTextBox = new System.Windows.Forms.TextBox();
            this.CategorySaveButton = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // categoryNameTextBox
            // 
            this.categoryNameTextBox.Location = new System.Drawing.Point(79, 35);
            this.categoryNameTextBox.Name = "categoryNameTextBox";
            this.categoryNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.categoryNameTextBox.TabIndex = 1;
            // 
            // CategorySaveButton
            // 
            this.CategorySaveButton.Location = new System.Drawing.Point(165, 61);
            this.CategorySaveButton.Name = "CategorySaveButton";
            this.CategorySaveButton.Size = new System.Drawing.Size(75, 23);
            this.CategorySaveButton.TabIndex = 3;
            this.CategorySaveButton.Text = "Save";
            this.CategorySaveButton.UseVisualStyleBackColor = true;
            this.CategorySaveButton.Click += new System.EventHandler(this.CategorySaveButton_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SL,
            this.categoryNameDataGridViewTextBoxColumn,
            this.categoryIDDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.categoryBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(64, 115);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(245, 150);
            this.dataGridView.TabIndex = 4;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            this.dataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView_RowPostPaint);
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(StockSystem.Models.Category);
            // 
            // SL
            // 
            this.SL.HeaderText = "SL";
            this.SL.Name = "SL";
            // 
            // categoryNameDataGridViewTextBoxColumn
            // 
            this.categoryNameDataGridViewTextBoxColumn.DataPropertyName = "CategoryName";
            this.categoryNameDataGridViewTextBoxColumn.HeaderText = "CategoryName";
            this.categoryNameDataGridViewTextBoxColumn.Name = "categoryNameDataGridViewTextBoxColumn";
            this.categoryNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // categoryIDDataGridViewTextBoxColumn
            // 
            this.categoryIDDataGridViewTextBoxColumn.DataPropertyName = "CategoryID";
            this.categoryIDDataGridViewTextBoxColumn.HeaderText = "CategoryID";
            this.categoryIDDataGridViewTextBoxColumn.Name = "categoryIDDataGridViewTextBoxColumn";
            this.categoryIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // CatagorySetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 308);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.CategorySaveButton);
            this.Controls.Add(this.categoryNameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "CatagorySetup";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Category Setup";
            this.Load += new System.EventHandler(this.CatagorySetup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox categoryNameTextBox;
        private System.Windows.Forms.Button CategorySaveButton;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIDDataGridViewTextBoxColumn;
    }
}


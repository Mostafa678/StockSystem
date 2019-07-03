using StockSystem.BLL;
using StockSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockSystem
{
    public partial class CatagorySetup : Form
    {
        CategoryManager _categoryManager = new CategoryManager();
        private Category category;
       
        public CatagorySetup()
        {
            InitializeComponent();
            category = new Category();
        }

        //  public object _studentManager { get; private set; }
        private void CatagorySetup_Load(object sender, EventArgs e)
        {
            dataGridView.DataSource = _categoryManager.ShowCategory();
        }

        private void CategorySaveButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                category.CategoryName = categoryNameTextBox.Text;
                int isExecuted;

                isExecuted = _categoryManager.InsertCategory(category);
                if (isExecuted > 0)
                {
                    MessageBox.Show("Saved");   
                }
                else
                {
                    MessageBox.Show("Not Saved!!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //show Category
            dataGridView.DataSource = _categoryManager.ShowCategory();
        }

       private void dataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dataGridView.Rows[e.RowIndex].Cells["SL"].Value = (e.RowIndex + 1).ToString();
        }
        
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

           categoryNameTextBox.Text = dataGridView.Rows[e.RowIndex].Cells["CategoryName"].FormattedValue.ToString();

        }
    }
}

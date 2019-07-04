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
            DataGridView.DataSource = _categoryManager.ShowCategory();
        }

        private void CategorySaveButton_Click(object sender, EventArgs e)
        {
            category.CategoryName = categoryNameTextBox.Text;

            //isexisted
            int isExisted = _categoryManager.IsExisted(category);

            if (isExisted > 0)
            {
                MessageBox.Show("This Category Name is already Existed!  ");
            }
            else
            {
                try
                {



                   // category.CategoryName = categoryNameTextBox.Text;
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
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                //show Category
                DataGridView.DataSource = _categoryManager.ShowCategory();
            }
        
        }

       private void DataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.DataGridView.Rows[e.RowIndex].Cells["SL"].Value = (e.RowIndex + 1).ToString();
        }

        private void DataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            categoryNameTextBox.Text = "";
            categoryNameTextBox.Text = DataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            //IDTextBox.Text = DataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();

        }

        private void DataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            categoryNameTextBox.Text = DataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            category.CategoryName = categoryNameTextBox.Text;

           // IDTextBox.Text = DataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            category.CategoryID = Convert.ToInt32(DataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());

            int isExecuted = _categoryManager.UpdateCategory(category);
            if (isExecuted > 0)
            {
                MessageBox.Show("Update");
                
            }
            else
            {
                MessageBox.Show("Not Update!!");
            }
            categoryNameTextBox.Text = "";
        }



        //private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        ////////    categoryNameTextBox.Text = DataGridView.SelectedRows[0].Cells[0].Value.ToString();
        ////////    IDTextBox.Text = DataGridView.SelectedRows[0].Cells[1].Value.ToString();


        //////    categoryNameTextBox.Text = DataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
        //////    category.CategoryName = categoryNameTextBox.Text;

        //////    IDTextBox.Text = DataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
        //////    category.CategoryID = Convert.ToInt32(IDTextBox.Text);


        ////    if (e.RowIndex >= 0)
        ////    {
        ////        DataGridViewRow row = this.DataGridView.Rows[e.RowIndex];
        ////        categoryNameTextBox.Text = row.Cells[1].Value.ToString();
        ////        IDTextBox.Text = row.Cells[2].Value.ToString();
        ////    }
        //}


    }
}

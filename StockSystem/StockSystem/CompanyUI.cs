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
    public partial class CompanySetup : Form
    {
        CompanyManager _companyManager = new CompanyManager();
        private Company company;
        public CompanySetup()
        {
            InitializeComponent();
            company = new Company();
        }
        private void CompanySetup_Load(object sender, EventArgs e)
        {
            ComapnyShowDataGridView.DataSource = _companyManager.ShowCategory();
        }

        private void CompanySaveButton_Click(object sender, EventArgs e)
        {
            company.CompanyName = companyNameTextBox.Text;

            //isexisted
            int isExisted = _companyManager.IsExisted(company);

            if (isExisted > 0)
            {
                MessageBox.Show("This Company Name is already Existed!  ");
            }
            else
            {
                try
                {



                    // category.CategoryName = categoryNameTextBox.Text;
                    int isExecuted;

                    isExecuted = _companyManager.InsertCategory(company);
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
                ComapnyShowDataGridView.DataSource = _companyManager.ShowCategory();
            }
        }

        private void ComapnyShowDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.ComapnyShowDataGridView.Rows[e.RowIndex].Cells["SL"].Value = (e.RowIndex + 1).ToString();
        }

        private void ComapnyShowDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            companyNameTextBox.Text = "";
            companyNameTextBox.Text = ComapnyShowDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            //IDTextBox.Text = DataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void ComapnyShowDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            companyNameTextBox.Text = ComapnyShowDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            company.CompanyName = companyNameTextBox.Text;

            // IDTextBox.Text = DataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            company.CompanyID = Convert.ToInt32(ComapnyShowDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());

            int isExecuted = _companyManager.UpdateCategory(company);
            if (isExecuted > 0)
            {
                MessageBox.Show("Update");

            }
            else
            {
                MessageBox.Show("Not Update!!");
            }
            companyNameTextBox.Text = "";
        }
    }
}

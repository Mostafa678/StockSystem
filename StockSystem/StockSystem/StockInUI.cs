using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockSystem.BLL;
using StockSystem.Models;

namespace StockSystem
{
    public partial class StockInUI : Form
    {
        StockInManager _stockInManager = new StockInManager();
        private StockIn stockIn;
        public StockInUI()
        {
            InitializeComponent();
            stockIn = new StockIn();
        }

        private void StockInUI_Load(object sender, EventArgs e)
        {
            StockInCompanycomboBox.DataSource=_stockInManager.LoadCompany();
           // StockInCompanycomboBox.DataSource = _stockInManager.LoadCategory();
        }

        private void StockInCompanycomboBox_MouseClick(object sender, MouseEventArgs e)
        {
           // stockIn.ComID = StockInCompanycomboBox.SelectedValue.ToString();
           

        }

        private void StockInCompanycomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            stockIn.ComID = Convert.ToInt32(StockInCompanycomboBox.SelectedValue);
            StockInCategoryComboBox.DataSource = _stockInManager.LoadCategory(stockIn);
        }
    }
}

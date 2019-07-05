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
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonCategory_Click(object sender, EventArgs e)
        {
            
            CatagorySetup catagorySetup = new CatagorySetup();
            
            catagorySetup.ShowDialog();

            
        }

        private void ButtonCompany_Click(object sender, EventArgs e)
        {
            CompanySetup company = new CompanySetup();
            company.ShowDialog();
        }

        private void ButtonItem_Click(object sender, EventArgs e)
        {
            ItemSetup item = new ItemSetup();
            item.ShowDialog();
        }
    }
}

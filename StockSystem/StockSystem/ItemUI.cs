using StockSystem.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using StockSystem.Models;

namespace StockSystem
{
    public partial class ItemSetup : Form
    {
        ItemManager _itemManager = new ItemManager();
        private Item item;
        public ItemSetup()
        {
            InitializeComponent();
            item = new Item();
            
        }

        private void ItemSetup_Load(object sender, EventArgs e)
        {
            ItemFromComboLoad();
        }

        void ItemFromComboLoad()
        {
            ItemCategoryComboBox.DataSource = _itemManager.LoadCategory();
            ItemCompanyComboBox.DataSource = _itemManager.LoadCompany();
        }


        private void ItemSaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                int inputnum;

                if (String.IsNullOrEmpty(itemNameTextBox.Text))
                {
                    //ItemSaveButton.Visible = false;
                    MessageBox.Show("Input Item Name");
                    return;

                }


                if (String.IsNullOrEmpty(itemReorderLevelTextBox.Text))
                {
                    // ItemSaveButton.Visible = false;
                    MessageBox.Show("Input Reorder Level");
                    return;
                }
                if (!Int32.TryParse(itemReorderLevelTextBox.Text, out inputnum))
                {
                    //ItemSaveButton.Visible = false;
                    MessageBox.Show("Input Reorder Number");
                    return;
                }
                item.CatID = Convert.ToInt32(ItemCategoryComboBox.SelectedValue);
                item.ComID = Convert.ToInt32(ItemCompanyComboBox.SelectedValue);
                item.ItemName = itemNameTextBox.Text;
                item.ItemReorder = Convert.ToInt32(itemReorderLevelTextBox.Text);
                int isExcuted = _itemManager.InsertItem(item);
                if (isExcuted > 0)
                {
                    MessageBox.Show("Save");


                }
                else
                {
                    MessageBox.Show("Not Save");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }


    }
}

using StockSystem.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockSystem.Models;

namespace StockSystem.BLL
{
   public class ItemManager
    {
        ItemRepository _itemRepository = new ItemRepository();
        public DataTable LoadCategory()
        {
            return _itemRepository.LoadCategory();
        }

        public int InsertItem(Item item)
        {
            return _itemRepository.InsertItem(item);
        }

        public DataTable LoadCompany()
        {
            return _itemRepository.LoadCompany();
        }
    }
}

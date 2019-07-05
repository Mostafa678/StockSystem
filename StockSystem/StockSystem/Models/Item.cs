using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockSystem.Models
{
    public class Item
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public int ItemReorder { get; set; }

        public int CatID { get; set; }
        public int ComID { get; set; }
    }
}

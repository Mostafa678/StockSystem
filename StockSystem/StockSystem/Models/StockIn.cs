using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockSystem.Models
{
    public class StockIn
    {
        public int StockInID { get; set; }
        public int CatID { get; set; }
        public int ComID { get; set; }
        public int ItemID { get; set; }
        public int StockInQuantity { get; set; }
        public string Date { get; set; }
    }
}

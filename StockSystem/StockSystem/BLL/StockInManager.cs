using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockSystem.Models;
using StockSystem.Repository;

namespace StockSystem.BLL
{
    public class StockInManager
    {
        StockInRepository _stockInRepository = new StockInRepository();

        public DataTable LoadCompany()
        {
            return _stockInRepository.LoadCompany();
        }

        public DataTable LoadCategory(StockIn stockIn)
        {
            return _stockInRepository.LoadCategory(stockIn);
        }

    }
}

using StockSystem.Models;
using StockSystem.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockSystem.BLL
{
    public class CompanyManager
    {
        CompanyRepository _categoryRepository = new CompanyRepository();
        public int InsertCategory(Company company)
        {
            return _categoryRepository.InsertCompany(company);
        }
        public DataTable ShowCategory()
        {
            return _categoryRepository.ShowCompany();
        }

        public int UpdateCategory(Company company)
        {
            return _categoryRepository.UpdateCompany(company);
        }
        public int IsExisted(Company company)
        {
            return _categoryRepository.IsExisted(company);
        }
    }
}

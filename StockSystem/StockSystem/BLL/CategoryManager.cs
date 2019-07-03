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
    public class CategoryManager
    {
        CategoryRepository _categoryRepository = new CategoryRepository();
        public int InsertCategory(Category category )
        {
            return _categoryRepository.InsertCategory(category);
        }
        public DataTable ShowCategory()
        {
            return _categoryRepository.ShowCategory();
        }
    }
}

using DbFirst.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFirst.BLL
{
    public class CategoryController
    {
        CategoryManagement categoryManagement = new CategoryManagement();

        public List<Category> categoriesList()
        {
            return categoryManagement.categoriesList().ToList();
        }
    }
     
}

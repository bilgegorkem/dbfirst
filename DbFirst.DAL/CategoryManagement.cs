using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFirst.DAL
{
    public class CategoryManagement
    {
        public List<Category> categoriesList()
        {
            NORTHWNDEntities nORTHWNDEntities = new NORTHWNDEntities();
            List<Category> categories = nORTHWNDEntities.Categories.ToList();

            return categories;
        }
    }
}

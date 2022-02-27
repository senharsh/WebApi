using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Entities;
using WebApi.Helpers;
using WebApi.Interface;

namespace WebApi.Services
{
    public class CategoryService : ICategory
    {
        private DataContext _context;

        public CategoryService(DataContext context)
        {
            _context = context;
        }
        public IEnumerable<CategoryMaster> GetAllCategory()
        {
            return _context.CategoryMaster;
        }


    }
}

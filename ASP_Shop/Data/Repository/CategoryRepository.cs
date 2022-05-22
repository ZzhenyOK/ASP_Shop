using ASP_Shop.Data.Interfaces;
using ASP_Shop.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP_Shop.Data.Repository
{
    public class CategoryRepository : ICarsCategory
    {
        private readonly AppDBContext appdbContext;

        public CategoryRepository(AppDBContext appdbContext)
        {
            this.appdbContext = appdbContext;
        }
        public IEnumerable<Category> AllCategories => appdbContext.Category;
    }
}

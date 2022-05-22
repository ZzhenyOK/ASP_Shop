using ASP_Shop.Data.Models;

namespace ASP_Shop.Data.Interfaces
{
    public interface ICarsCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}

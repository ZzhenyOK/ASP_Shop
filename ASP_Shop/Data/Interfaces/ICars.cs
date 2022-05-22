using ASP_Shop.Data.Models;

namespace ASP_Shop.Data.Interfaces
{
    public interface ICars
    {
        IEnumerable<Car> Cars { get; }
        IEnumerable<Car> GetFavCars { get; }
        Car GetObjectId(int carId);
    }
}

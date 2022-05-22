using ASP_Shop.Data.Interfaces;
using ASP_Shop.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP_Shop.Data.Repository
{
    public class CarRepository : ICars
    {
        private readonly AppDBContext appdbContext;

        public CarRepository(AppDBContext appdbContext)
        {
            this.appdbContext = appdbContext;
        }

        public IEnumerable<Car> Cars => appdbContext.Car.Include(c => c.Category);

        public IEnumerable<Car> GetFavCars => appdbContext.Car.Where(f => f.IsFavourite).Include(c => c.Category);

        public Car GetObjectId(int carId) => appdbContext.Car.FirstOrDefault(p => p.Id == carId);
    }
}

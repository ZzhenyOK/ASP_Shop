using ASP_Shop.Data.Interfaces;
using ASP_Shop.Data.Models;

namespace ASP_Shop.Data.Mocks
{
    public class MockCars : ICars
    {
        private readonly ICarsCategory carsCategory = new MockCategory();
        public IEnumerable<Car> Cars 
        {
            get
            {
                return new List<Car>()
                {
                    new Car
                    {
                        Name = "Tesla",
                        ShortDesc = "Быстрый автомобиль",
                        LongDesc = "",
                        Img = "/Img/Tesla.jpg",
                        Price = 45000,
                        IsFavourite = true,
                        Available = true,
                        Category = carsCategory.AllCategories.First()
                    },
                    new Car
                    {
                        Name = "Ford Fiesta",
                        ShortDesc = "Тихий и спокойный",
                        LongDesc = "",
                        Img = "/Img/FordFiesta.jpg",
                        Price = 11000,
                        IsFavourite = false,
                        Available = true,
                        Category = carsCategory.AllCategories.Last()
                    },
                    new Car
                    {
                        Name = "BMW M3",
                        ShortDesc = "Дерзкий и стильный",
                        LongDesc = "",
                        Img = "/Img/BMWM3.jpg",
                        Price = 65000,
                        IsFavourite = true,
                        Available = true,
                        Category = carsCategory.AllCategories.Last()
                    },
                    new Car
                    {
                        Name = "Mercedes C Class",
                        ShortDesc = "Уютный и большой",
                        LongDesc = "",
                        Img = "/Img/MercedesCClass.jpg",
                        Price = 40000,
                        IsFavourite = false,
                        Available = false,
                        Category = carsCategory.AllCategories.Last()
                    },
                    new Car
                    {
                        Name = "Nissan Leaf",
                        ShortDesc = "Безшумный и экономный",
                        LongDesc = "",
                        Img = "/Img/NissanLeaf.jpg",
                        Price = 14000,
                        IsFavourite = true,
                        Available = true,
                        Category = carsCategory.AllCategories.First()
                    }
                };
            }
        }
        public IEnumerable<Car> GetFavCars { get; set; }

        public Car GetObjectId(int carId)
        {
            throw new NotImplementedException();
        }
    }
}

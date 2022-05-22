using ASP_Shop.Data.Interfaces;
using ASP_Shop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ASP_Shop.Controllers
{
    public class CarsController : Controller
    {
        private readonly ICars _allCars;
        private readonly ICarsCategory _allCategories;

        public CarsController(ICars allCars, ICarsCategory allCategories)
        {
            _allCars = allCars;
            _allCategories = allCategories;
        }
        public ViewResult List()
        {
            ViewBag.Title = "Страница с автомобилями";
            CarsListViewModel obj = new CarsListViewModel();
            obj.AllCars = _allCars.Cars;
            obj.currCategory = "Автомобили";
            return View(obj);
        }
    }
}

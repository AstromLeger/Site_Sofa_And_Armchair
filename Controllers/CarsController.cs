using Microsoft.AspNetCore.Mvc;
using Test_Shop_2_1.Interfaces;
using Test_Shop_2_1.mocks;
using Test_Shop_2_1.ViewModels;

namespace Test_Shop_2_1.Controllers
{

    public class CarsController : Controller 
    {
        private IAllCars _allCars;
        private ICarsCategory _allCategories;

      

        public ViewResult Index()
        {
            if (_allCars == null)
            {
                _allCars = new MockCars();
            }
            if (_allCategories == null)
            {
                _allCategories = new MockCategory();
            }
            ViewBag.Title = "Страница товаров";
            CarsListViewModel obj = new CarsListViewModel();
            obj.allCars = _allCars.Cars;
            obj.currCategory = "Автомобили";
            return View(obj);
        }

        


    }
}

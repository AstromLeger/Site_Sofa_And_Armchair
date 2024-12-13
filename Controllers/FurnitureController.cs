using Microsoft.AspNetCore.Mvc;
using Test_Shop_2_1.Interfaces;
using Test_Shop_2_1.mocks;

namespace Test_Shop_2_1.Controllers
{
    public class FurnitureController : Controller
    {
        private IAllFurnitures _allFurnitures;
        private IFurnitureCategory _allFurnitureCategories;


        //public FurnitureController(IAllFurnitures iAllFurnitures, IFurnitureCategory iFurnitureCat)
        //{
            //_allFurnitures = iAllFurnitures;
            //_allFurnitureCategories = iFurnitureCat;
        //}
        //Все зелёное не нужно, оно создает ошибку и ломает весь код

        public ViewResult Index()
        {
            if (_allFurnitures == null)
            {
                _allFurnitures = new MockFurnitures();
            }
            if (_allFurnitureCategories == null)
            {
                _allFurnitureCategories = new MockFurnitureCategory();
            }
            var furniture = _allFurnitures.Furnitures;
            return View(furniture);
        }




    }
}

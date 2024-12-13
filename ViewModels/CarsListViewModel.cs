using Test_Shop_2_1.Models;

namespace Test_Shop_2_1.ViewModels
{
    public class CarsListViewModel
    {
        public IEnumerable<Car> allCars { get; set; }

        public string currCategory { get; set; }

    }
}

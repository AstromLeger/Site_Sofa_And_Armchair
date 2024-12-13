using Test_Shop_2_1.Models;

namespace Test_Shop_2_1.Interfaces
{
    public interface IAllCars
    {
        IEnumerable<Car> Cars { get; }
        IEnumerable<Car>? getFavCars { get; set; }
        Car getobjectcar(int carId);
    }
}

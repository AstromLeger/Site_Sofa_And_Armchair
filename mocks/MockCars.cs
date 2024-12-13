using Test_Shop_2_1.Interfaces;
using Test_Shop_2_1.Models;

namespace Test_Shop_2_1.mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car {
                        name = "Tesla Model S",
                        shortDesc = "Быстрый автомобиль",
                        longDesc = "Красивый, быстрый и очень тихий автомобиль компании Tesla",
                        img = "/img/TeslaModel_S.jpeg",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.First()
                    },
                    new Car{
                        name = "Ford Fiesta",
                        shortDesc = "Тихий и спокойный ",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "/img/FordFiesta.jpg",
                        price = 11000,
                        isFavourite = false,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car{
                        name = "BMW M3",
                        shortDesc = "Дерзкий и стильный",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "/img/BMW_M3.jpg",
                        price = 65000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car{
                        name = "Mercedec C class",
                        shortDesc = "Уютный и большой",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "/img/MercedecC_class.jpg",
                        price = 40000,
                        isFavourite = false,
                        available = false,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car{
                        name = "Nissan Leaf",
                        shortDesc = "Бесшумный и экономный",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "/img/NissanLeaf.jpeg",
                        price = 14000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.First()
                    }
                };
            }
        }
        public IEnumerable<Car>? getFavCars { get; set; }

        public Car getobjectcar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}

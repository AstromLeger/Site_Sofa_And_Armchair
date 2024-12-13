using Test_Shop_2_1.Interfaces;
using Test_Shop_2_1.Models;

namespace Test_Shop_2_1.mocks
{
    public class MockFurnitures : IAllFurnitures
    {
        private readonly IFurnitureCategory _CategoryFurniture = new MockFurnitureCategory();
        public IEnumerable<Furniture> Furnitures {
            get {
                return new List<Furniture> {
                    new Furniture {
                        id = 1,
                        name = "Армада",
                        shortDesc = "Мягкий и удобный",
                        longDesc = "Для просмотра телевизора в семейном кругу",
                        img = "",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        Category = _CategoryFurniture.AllFurnitureCategories.First()
                    },
                    new Furniture{
                        id = 2,
                        name = "Аврора",
                        shortDesc = "Широкий и мягкий",
                        longDesc = "Для просмотра телевизора в семейном кругу",
                        img = "",
                        price = 11000,
                        isFavourite = false,
                        available = true,
                        Category = _CategoryFurniture.AllFurnitureCategories.First()
                    },
                    new Furniture{
                        id = 3,
                        name = "Каминный",
                        shortDesc = "Мягкий и расслабляющий",
                        longDesc = "Для просмотра телевизора в семейном кругу",
                        img = "",
                        price = 65000,
                        isFavourite = true,
                        available = true,
                        Category = _CategoryFurniture.AllFurnitureCategories.First()
                    },
                    new Furniture{
                        id = 4,
                        name = "Бруклин",
                        shortDesc = "Уютный и большой",
                        longDesc = "Для просмотра телевизора в семейном кругу",
                        img = "",
                        price = 40000,
                        isFavourite = false,
                        available = false,
                        Category = _CategoryFurniture.AllFurnitureCategories.First()
                    },
                    new Furniture{
                        id = 5,
                        name = "Бали",
                        shortDesc = "Большой и мягкий",
                        longDesc = "Для просмотра телевизора в семейном кругу",
                        img = "",
                        price = 14000,
                        isFavourite = true,
                        available = true,
                        Category = _CategoryFurniture.AllFurnitureCategories.Last()
                    }
                };
            }
        }

        public IEnumerable<Furniture> getFavFurnitures { get; set; }

        public Furniture getObjectfurniture(int furnitureId)
        {
            throw new NotImplementedException();
        }
    }
}

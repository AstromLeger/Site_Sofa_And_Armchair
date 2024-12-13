using Test_Shop_2_1.Models;
using Test_Shop_2_1.Interfaces;

namespace Test_Shop_2_1.mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                   new Category {categoryName = "Электромобиль", desc = "Современный вид транспорта"},
                   new Category {categoryName = "Классические автомобили", desc = "Машины с двигателем внутреннего сгорания"}
                };
            }
        }
    }
}

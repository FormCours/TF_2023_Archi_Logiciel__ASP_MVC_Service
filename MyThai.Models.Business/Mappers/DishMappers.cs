
using BLL = MyThai.Models.Business.Models;
using DAL = MyThai.Models.Data.Entities;

namespace MyThai.Models.Business.Mappers
{
    internal static class DishMappers
    {
        internal static DAL.Dish ToDal(this BLL.Dish dish)
        {
            return new DAL.Dish()
            {
                Id = dish.Id,
                Name = dish.Name,
                Description = dish.Description,
                Price = dish.Price,
                IsDisabled = false,
                IdCategory = dish.Category.Id
            };
        }

        internal static BLL.Dish ToBll(this DAL.Dish dish, DAL.DishCategory category)
        {
            return new BLL.Dish(
                dish.Name,
                dish.Description,
                dish.Price,
                category.ToBll()
            );
        }
    }
}

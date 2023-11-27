
using BLL = MyThai.Models.Business.Models;
using DAL = MyThai.Models.Data.Entities;

namespace MyThai.Models.Business.Mappers
{
    internal static class DishCategoryMappers
    {

        internal static DAL.DishCategory ToDal(this BLL.DishCategory dishCategory)
        {
            return new DAL.DishCategory() 
            {
                Id = dishCategory.Id,
                Name = dishCategory.Name,
            };
        }

        internal static BLL.DishCategory ToBll(this DAL.DishCategory dishCategory)
        {
            return new BLL.DishCategory(
                dishCategory.Id,
                dishCategory.Name
            );
        }

    }
}

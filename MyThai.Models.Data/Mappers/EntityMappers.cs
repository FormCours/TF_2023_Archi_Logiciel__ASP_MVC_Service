using MyThai.Models.Data.Entities;
using System.Data.Common;

namespace MyThai.Models.Data.Mappers
{
    internal static class EntityMappers
    {

        internal static DishCategory ToDishCategory(this DbDataReader reader)
        {
            return new DishCategory()
            {
                Id = (int)reader["Id_DishCategory"],
                Name = (string)reader["Name"],
            };

            //return new DishCategory()
            //{
            //    Id = reader.GetInt32(reader.GetOrdinal("Id_DishCategory")),
            //    Name = reader.GetString(reader.GetOrdinal("Name")),
            //};
        }

        internal static Dish ToDish(this DbDataReader reader)
        {
            return new Dish() 
            {
                Id = (int)reader["Id_Dish"],
                Name = (string)reader["Name"],
                Description = reader["Description"] is DBNull ? null : (string)reader["Description"],
                Price = (double)reader["Price"],
                IdCategory = (int)reader["Id_Category"],
                IsDisabled = (bool)reader["IsDisabled"]
            };
        }
    }
}

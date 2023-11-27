using MyThai.Models.Data.Entities;
using MyThai.Models.Data.Interfaces;
using MyThai.Models.Data.Mappers;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Ado;

namespace MyThai.Models.Data.Repositories
{
    public class DishCategoryRepository : RepositoryBase, IDishCategoryRepository
    {
        public DishCategoryRepository(DbConnection connection) : base(connection) { }


        public IEnumerable<DishCategory> GetAll()
        {
            Connection.Open();

            return Connection.ExecuteReader("SELECT * FROM DishCategory", reader => reader.ToDishCategory(), null);
            // return Connection.ExecuteReader("SELECT * FROM DishCategory", EntityMappers.ToDishCategory, null);
        }

        public DishCategory? GetbyId(int id)
        {
            Connection.Open();

            IEnumerable<DishCategory> categories = Connection.ExecuteReader(
                "SELECT * FROM DishCategory WHERE Id_DishCategory = @Id",
                reader => reader.ToDishCategory(),
                new { Id = id }
            );
             
            return categories.SingleOrDefault();
        }
    }
}

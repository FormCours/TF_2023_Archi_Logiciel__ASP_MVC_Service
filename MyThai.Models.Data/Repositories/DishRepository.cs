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
    public class DishRepository : RepositoryBase, IDishRepository
    {
        public DishRepository(DbConnection connection) : base(connection) { }


        public IEnumerable<Dish> GetAll()
        {
            Connection.Open();

            return Connection.ExecuteReader(
                "SELECT * FROM Dish WHERE IsDisabled = 0", // Simplification possible avec un View SQL
                reader => reader.ToDish(), 
                null
            );
        }

        public IEnumerable<Dish> GetByCategory(int categoryId)
        {
            Connection.Open();

            return Connection.ExecuteReader(
                "SELECT * FROM Dish WHERE IsDisabled = 0 AND Id_Category = @CatId",
                reader => reader.ToDish(),
                new { CatId =  categoryId }
            );
        }

        public Dish? GetbyId(int id)
        {
            Connection.Open();

            IEnumerable<Dish> dishes = Connection.ExecuteReader(
                "SELECT * FROM Dish WHERE IsDisabled = 0 AND Id_Dish = @Id",
                reader => reader.ToDish(),
                new { Id = id }
            );

            return dishes.SingleOrDefault();
        }

        public Dish Insert(Dish data)
        {
            Connection.Open();

            IEnumerable<Dish> dishes = Connection.ExecuteReader(
                "INSERT INTO Dish(Name, Description, Price, Id_Category)" +
                " OUTPUT inserted.*" +
                " VALUES(@Name, @Description, @Price, @CatId)",
                reader => reader.ToDish(),
                new
                {
                    data.Name,
                    data.Description,
                    data.Price,
                    CatId = data.IdCategory
                }
            );

            return dishes.Single();
        }

        public bool Update(int id, Dish data)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            Connection.Open();

            int nbRowDeleted = Connection.ExecuteNonQuery(
                "DELETE FROM Dish WHERE Id_Dish = @Id",
                new { Id = id }
            );

            return nbRowDeleted == 1;
        }
    }
}

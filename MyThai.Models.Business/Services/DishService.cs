using MyThai.Models.Business.Interfaces;
using MyThai.Models.Business.Mappers;
using MyThai.Models.Business.Models;
using MyThai.Models.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyThai.Models.Business.Services
{
    public class DishService : IDishService
    {
        private readonly IDishRepository _dishRepository;
        private readonly IDishCategoryRepository _dishCategoryRepository;

        public DishService(IDishRepository dishRepository, IDishCategoryRepository dishCategoryRepository)
        {
            _dishRepository = dishRepository;
            _dishCategoryRepository = dishCategoryRepository;
        }

        public Dish? GetById(int id)
        {
            // Récuperation des données depuis les repos
            var dishEntity = _dishRepository.GetbyId(id);

            if(dishEntity == null)
                return null;

            var dishCategoryEntity = _dishCategoryRepository.GetbyId(dishEntity.IdCategory);

            if (dishCategoryEntity == null)
                return null;

            // Logique metier
            Dish dish = dishEntity.ToBll(dishCategoryEntity);
            if (DateTime.Today.DayOfWeek == DayOfWeek.Wednesday)
            {
                dish.Price = dish.Price - (dish.Price * 0.1);
            }

            // Return de la fonction
            return dish;
        }

        public Dish Insert(Dish dish)
        {
            var dishInserted = _dishRepository.Insert(dish.ToDal());
            var dishCategoryEntity = _dishCategoryRepository.GetbyId(dishInserted.IdCategory);

            if (dishCategoryEntity == null)
                throw new Exception();

            return dishInserted.ToBll(dishCategoryEntity);
        }
    }
}

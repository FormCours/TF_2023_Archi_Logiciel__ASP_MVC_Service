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
    internal class DishCategoryService : IDishCategoryService
    {
        private readonly IDishCategoryRepository _repository;

        public DishCategoryService(IDishCategoryRepository repository)
        {
            _repository = repository;
        }


        public IEnumerable<DishCategory> GetAll()
        {
            return _repository.GetAll().Select(dc => dc.ToBll());
        }
    }
}

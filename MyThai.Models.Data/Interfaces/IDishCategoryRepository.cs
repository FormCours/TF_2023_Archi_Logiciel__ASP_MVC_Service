using MyThai.Models.Data.Entities;
using MyThai.Models.Data.Interfaces.CRUD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyThai.Models.Data.Interfaces
{
    public interface IDishCategoryRepository : IReaderRepository<int, DishCategory>
    {
        // Ajout des méthodes custom pour "IDishCategoryRepository" 
    }
}

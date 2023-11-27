using MyThai.Models.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyThai.Models.Business.Interfaces
{
    public interface IDishCategoryService
    {
        IEnumerable<DishCategory> GetAll();
    }
}

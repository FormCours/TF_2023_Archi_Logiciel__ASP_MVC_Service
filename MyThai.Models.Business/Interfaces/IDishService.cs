using MyThai.Models.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyThai.Models.Business.Interfaces
{
    public interface IDishService
    {
        Dish? GetById(int id);

        Dish Insert(Dish dish);
    }
}

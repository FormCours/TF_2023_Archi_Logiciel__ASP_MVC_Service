using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyThai.Models.Business.Models
{
    public class DishCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public DishCategory(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}

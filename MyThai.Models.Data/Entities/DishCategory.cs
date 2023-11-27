using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyThai.Models.Data.Entities
{
    public class DishCategory
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
    }

    // « = null! » => Permet d'éviter le warning "null safe" sur une string
}

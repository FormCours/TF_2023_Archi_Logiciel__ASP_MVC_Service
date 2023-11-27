using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyThai.Models.Business.Models
{
    public class Dish
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public double Price { get; set; }
        public DishCategory Category { get; set; } = null! ;

        public Dish(string name, string? description, double price, DishCategory category)
        {
            Id = 0;
            Name = name;
            Description = description;
            Price = price;
            Category = category;
        }
        public Dish(int id, string name, string? description, double price, DishCategory category)
            : this(name, description, price, category)
        {
            Id = id;
        }
    }
}

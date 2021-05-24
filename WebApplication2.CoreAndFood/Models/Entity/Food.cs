using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.CoreAndFood.Models.Entity
{
    public class Food
    {
        public int FoodId { get; set; }
        public string FoodName { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public int UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

    }
}

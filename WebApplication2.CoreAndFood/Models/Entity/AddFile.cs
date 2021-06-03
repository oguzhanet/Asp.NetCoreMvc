using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.CoreAndFood.Models.Entity
{
    public class AddFile
    {
        public string FoodName { get; set; }
        public string Description { get; set; }
        public IFormFile ImageUrl { get; set; }
        public int UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }

        public int CategoryId { get; set; }
    }
}

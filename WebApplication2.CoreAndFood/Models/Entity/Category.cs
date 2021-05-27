using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.CoreAndFood.Models.Entity
{
    public class Category
    {
        public int CategoryId { get; set; }
        [Required(ErrorMessage ="Kategori Adı Boş Olmaz!")]
        [StringLength(20,ErrorMessage ="Kategori Adı 20 Karakterden Fazla Olmaz!",MinimumLength =2)]
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public bool Status { get; set; }

        public List<Food> Foods { get; set; }
    }
}

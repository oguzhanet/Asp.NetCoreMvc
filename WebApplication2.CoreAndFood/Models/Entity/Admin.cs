using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.CoreAndFood.Models.Entity
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }
        [StringLength(20)]
        public string UserName { get; set; }
        [StringLength(14)]
        public string Password { get; set; }
        [StringLength(10)]
        public string AdminRole { get; set; }
    }
}

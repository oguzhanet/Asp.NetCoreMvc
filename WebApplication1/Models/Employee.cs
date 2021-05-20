using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }


        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}

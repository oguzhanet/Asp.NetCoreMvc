using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-D8VO00IR; database=CoreApp1Db; integrated security=true;");
        }

        public DbSet<Departman> Departmen { get; set; }
        public DbSet<Personel> Personels { get; set; }
    }
}

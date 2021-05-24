using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.CoreAndFood.DataAccess.Abstract;
using WebApplication2.CoreAndFood.Models.Entity;

namespace WebApplication2.CoreAndFood.DataAccess.Concrete.EntityFramework
{
    public class EfFoodDal: GenericRepository<Food>,IFoodDal
    {
    }
}

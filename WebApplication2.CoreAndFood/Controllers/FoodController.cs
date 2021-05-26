using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.CoreAndFood.DataAccess.Concrete.EntityFramework;

namespace WebApplication2.CoreAndFood.Controllers
{
    public class FoodController : Controller
    {
        EfFoodDal foodDal = new EfFoodDal();
        public IActionResult Index()
        {
            var result = foodDal.GetAll("Category");
            return View(result);
        }
    }
}

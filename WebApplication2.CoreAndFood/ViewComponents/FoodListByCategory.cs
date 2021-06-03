using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.CoreAndFood.DataAccess.Concrete.EntityFramework;

namespace WebApplication2.CoreAndFood.ViewComponents
{
    public class FoodListByCategory:ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            EfFoodDal foodDal = new EfFoodDal();
            var result = foodDal.GetAll(x => x.CategoryId == id);
            return View(result);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.CoreAndFood.DataAccess.Concrete.EntityFramework;

namespace WebApplication2.CoreAndFood.ViewComponents
{
    public class FoodGetAll:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            EfFoodDal foodDal = new EfFoodDal();
            var result = foodDal.GetAll();
            return View(result);
        }
    }
}

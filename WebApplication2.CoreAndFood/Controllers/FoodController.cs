using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.CoreAndFood.DataAccess.Concrete.EntityFramework;
using WebApplication2.CoreAndFood.Models.Entity;

namespace WebApplication2.CoreAndFood.Controllers
{
    public class FoodController : Controller
    {
        Context context = new Context();
        EfFoodDal foodDal = new EfFoodDal();
        public IActionResult Index()
        {
            var result = foodDal.GetAll("Category");
            return View(result);
        }

        [HttpGet]
        public IActionResult Add()
        {
            List<SelectListItem> categories = (from category in context.Categories.ToList()
                                               select new SelectListItem
                                               {
                                                   Text = category.CategoryName,
                                                   Value = category.CategoryId.ToString()
                                               }).ToList();
            ViewBag.category = categories;

            return View();
        }

        [HttpPost]
        public IActionResult Add(Food food)
        {
            foodDal.Add(food);
            return RedirectToAction("Index");
        }
    }
}

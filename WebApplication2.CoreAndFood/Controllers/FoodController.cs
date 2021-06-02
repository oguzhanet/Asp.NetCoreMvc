using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.CoreAndFood.DataAccess.Concrete.EntityFramework;
using WebApplication2.CoreAndFood.Models.Entity;
using X.PagedList;

namespace WebApplication2.CoreAndFood.Controllers
{
    public class FoodController : Controller
    {
        Context context = new Context();
        EfFoodDal foodDal = new EfFoodDal();

        public IActionResult Index(int page=1)
        {
            var result = foodDal.GetAll("Category").ToPagedList(page,3);
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

        public IActionResult Delete(int id)
        {
            var result = foodDal.Get(x=>x.FoodId==id);
            foodDal.Delete(result);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult GetById(int id)
        {
            List<SelectListItem> categories = (from category in context.Categories.ToList()
                                               select new SelectListItem
                                               {
                                                   Text = category.CategoryName,
                                                   Value = category.CategoryId.ToString()
                                               }).ToList();
            ViewBag.category = categories;

            var result = foodDal.Get(id);
            return View(result);
        }

        [HttpPost]
        public IActionResult GetById(Food food)
        {
            //food.Status = true;
            foodDal.Update(food);
            return RedirectToAction("Index");
        }
    }
}

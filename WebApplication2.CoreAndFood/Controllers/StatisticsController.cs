using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.CoreAndFood.Models.Entity;

namespace WebApplication2.CoreAndFood.Controllers
{
    public class StatisticsController : Controller
    {
        Context context = new Context();
        public IActionResult Index()
        {
            var result1 = context.Categories.Count();
            ViewBag.result1 = result1;

            var result2 = context.Foods.Count();
            ViewBag.result2 = result2;

            var value1 = context.Categories.Where(x => x.CategoryName == "Meyveler").Select(z => z.CategoryId).FirstOrDefault();
            var result3 = context.Foods.Where(x => x.CategoryId == value1).Count();
            ViewBag.result3 = result3;

            var value2 = context.Categories.Where(x => x.CategoryName == "Sebzeler").Select(z => z.CategoryId).FirstOrDefault();
            var result4 = context.Foods.Where(x => x.CategoryId == value2).Count();
            ViewBag.result4 = result4;

            var value3 = context.Categories.Where(x => x.CategoryName == "Baklagiller").Select(z => z.CategoryId).FirstOrDefault();
            var result5 = context.Foods.Where(x => x.CategoryId == value3).Count();
            ViewBag.result5 = result5;

            var result6 = context.Foods.Sum(x => x.UnitsInStock);
            ViewBag.result6 = result6;

            var result7 = context.Foods.OrderByDescending(x => x.UnitsInStock).Select(z => z.FoodName).FirstOrDefault();
            ViewBag.result7 = result7;

            var result8 = context.Foods.OrderBy(x => x.UnitsInStock).Select(z => z.FoodName).FirstOrDefault();
            ViewBag.result8 = result8;

            var result9 = context.Foods.Average(x => x.UnitPrice).ToString("0.00");
            ViewBag.result9 = result9;

            var result10 = context.Foods.Where(x => x.CategoryId == value1).Sum(z => z.UnitsInStock);
            ViewBag.result10 = result10;

            var result11 = context.Foods.Where(x => x.CategoryId == value2).Sum(z => z.UnitsInStock);
            ViewBag.result11 = result11;

            var result12 = context.Foods.OrderByDescending(x => x.UnitPrice).Select(z => z.FoodName).FirstOrDefault();
            ViewBag.result12 = result12;

            return View();
        }
    }
}

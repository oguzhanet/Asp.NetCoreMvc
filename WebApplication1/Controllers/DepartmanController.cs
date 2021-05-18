using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class DepartmanController : Controller
    {
        Context context = new Context();
        public IActionResult Index()
        {
            var result = context.Departmen.ToList();
            return View(result);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Departman departman)
        {
            context.Departmen.Add(departman);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var result = context.Departmen.Find(id);
            context.Departmen.Remove(result);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult GetById(int id)
        {
            var result = context.Departmen.Find(id);
            return View("GetById",result);
        }

        public IActionResult Update(Departman departman)
        {
            var result = context.Departmen.Find(departman.Id);
            result.DepartmanName = departman.DepartmanName;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

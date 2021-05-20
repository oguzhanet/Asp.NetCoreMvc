using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class DepartmentController : Controller
    {
        Context context = new Context();
        public IActionResult Index()
        {
            var result = context.Departments.ToList();
            return View(result);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Department department)
        {
            context.Departments.Add(department);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var result = context.Departments.Find(id);
            context.Departments.Remove(result);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult GetById(int id)
        {
            var result = context.Departments.Find(id);
            return View("GetById", result);
        }

        public IActionResult Update(Department department)
        {
            var result = context.Departments.Find(department.Id);
            result.DepartmentName = department.DepartmentName;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

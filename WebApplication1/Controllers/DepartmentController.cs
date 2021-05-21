using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        [Authorize]
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

        public IActionResult Detail(int id)
        {
            var results = context.Employees.Where(x => x.DepartmentId == id).ToList();
            var result = context.Departments.Where(x => x.Id == id).Select(x => x.DepartmentName).FirstOrDefault();
            ViewBag.result = result;
            return View(results);
        }
    }
}

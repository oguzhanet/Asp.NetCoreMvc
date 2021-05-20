using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        Context context = new Context();
        public IActionResult Index()
        {
            var result = context.Employees.Include(x=>x.Department).ToList();
            return View(result);
        }

        [HttpGet]
        public IActionResult Add()
        {
            List<SelectListItem> results = (from department in context.Departments.ToList()
                                            select new SelectListItem
                                            {
                                                Text = department.DepartmentName,
                                                Value = department.Id.ToString()
                                            }).ToList();
            ViewBag.result = results;
            return View();
        }

        //[HttpPost]
        public IActionResult Add(Employee employee)
        {
            var result = context.Departments.Where(x => x.Id == employee.Department.Id).FirstOrDefault();
            employee.Department = result;
            context.Employees.Add(employee);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

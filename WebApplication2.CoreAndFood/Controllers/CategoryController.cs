
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.CoreAndFood.DataAccess.Abstract;
using WebApplication2.CoreAndFood.DataAccess.Concrete.EntityFramework;
using WebApplication2.CoreAndFood.Models.Entity;

namespace WebApplication2.CoreAndFood.Controllers
{
    public class CategoryController : Controller
    {
        EFCategoryDal categoryDal = new EFCategoryDal();

        //[AllowAnonymous]
        public IActionResult Index(string parameter)
        {
            if (!string.IsNullOrEmpty(parameter))
            {
                return View(categoryDal.GetAll(x => x.CategoryName == parameter));
            }

            var result = categoryDal.GetAll();
            return View(result);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Category category)
        {
            if (!ModelState.IsValid)
            {
                return View("Add");
            }
            categoryDal.Add(category);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult GetById(int id)
        {
            var result = categoryDal.Get(id);
            return View(result);
        }

        [HttpPost]
        public IActionResult GetById(Category category)
        {
            category.Status = true;
            categoryDal.Update(category);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var result = categoryDal.Get(id);
            result.Status = false;
            categoryDal.Update(result);
            return RedirectToAction("Index");
        }
    }
}

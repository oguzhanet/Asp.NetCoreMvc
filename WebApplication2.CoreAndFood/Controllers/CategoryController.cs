
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.CoreAndFood.DataAccess.Abstract;
using WebApplication2.CoreAndFood.DataAccess.Concrete.EntityFramework;

namespace WebApplication2.CoreAndFood.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            EFCategoryDal categoryDal = new EFCategoryDal();
            return View(categoryDal.GetAll());
        }
    }
}

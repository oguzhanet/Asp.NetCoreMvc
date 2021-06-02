using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.CoreAndFood.DataAccess.Concrete.EntityFramework;

namespace WebApplication2.CoreAndFood.ViewComponents
{
    public class CategoryGetAll:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            EFCategoryDal categoryDal = new EFCategoryDal();
            var result = categoryDal.GetAll();
            return View(result);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.CoreAndFood.Models;

namespace WebApplication2.CoreAndFood.Controllers
{
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Index2()
        {
            return View();
        }

        public IActionResult VisualizeProductResult()
        {
            return Json(ProductList());
        }

        public List<Parameter> ProductList()
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter
            {
                ProductName="Computer",
                Stock=120
            });
            parameters.Add(new Parameter
            {
                ProductName = "Lcd",
                Stock = 120
            });
            parameters.Add(new Parameter
            {
                ProductName = "Flash Disk",
                Stock = 120
            });
            return parameters;
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Index2()
        {
            var result = new List<Book>
            {
                new Book{Id=1, BookName="Momo",Writer="Michael Ende"},
                new Book{Id=2, BookName="Değirmen",Writer="Sabahattin Ali"},
                new Book{Id=3, BookName="Yaşamak",Writer="Yu Hua"},
                new Book{Id=4, BookName="Bir Noel Hikayesi",Writer="Charles Dickens"}
            };
            return View(result);
        }

        public IActionResult Tema()
        {
            return View();
        }
    }
}

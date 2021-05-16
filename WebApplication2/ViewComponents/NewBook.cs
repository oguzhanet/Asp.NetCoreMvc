using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.ViewComponents
{
    public class NewBook:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var bookList=new List<Book>
            {
                new Book
                {
                    Id = 5, BookName = "1984", Writer = "George Orwell"
                },
                new Book
                {
                    Id = 7, BookName = "Hayvan Çiftliği", Writer = "George Orwell"
                }
            };
            return View(bookList);
        }
    }
}

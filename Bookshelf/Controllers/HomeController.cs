using Bookshelf.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.VisualStudio.Web.CodeGeneration.Design;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookshelf.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var books = new List<Book>() {
            new Book(){ID=1,Name="Atomic Habits", Author="James Clear",Price = 10.5M},
            new Book(){ ID=2,Name= "The Life Lessons From A Monk Who Sold His Ferrari",Author = "Robin Sharma", Price = 11},
            new Book(){ID = 3, Name = "The 12 Rules of Life", Author = "Jordan Peterson", Price=13.5M},
            new Book(){ID =4,Name = "Rational Male", Author = "Rollo Tomassi", Price=17}
            
            
            };
            
            return View(books);
        }
    }
}

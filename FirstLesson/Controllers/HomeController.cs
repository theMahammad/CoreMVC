using FirstLesson.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;

namespace FirstLesson.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public int Index2()
        {
            return 25;
        }
        public string Index3()
        {
            return "Hello to C# learners!";
        }
        public IActionResult ModelExample()
        {
            var  books = new List<Book>() { new Book() { ID = 1, Name = "Mastery", Author = "Robert Greene" },
             new Book() { ID = 2, Name = "Start with \"Why\"", Author = " Simon Sinek" }
        };
            return View(books);
        }

        public IActionResult UsingViewBag()
        {
            ViewBag.variable1 = "Knock! Knock! I'm back!";
            ViewBag.variable2 = ViewBag.variable1 + " I'm Mahammad! ";
            return View();

        }
    }
}

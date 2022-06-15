using Bookshelf.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookshelf.ViewComponents
{
    /*There are 3 ways to turn a normal class to a view component class :
    1) Creating a class ending "ViewComponent" suffix
   
    2) Using [ViewComponent] attribute to decorate the class 
    3) Deriving from ViewComponent class 
     */

    // public class NewBooksWViewComponent {} (1)
    // [ViewComponent](2)
    public class NewBooks:ViewComponent //(3)
    {
        public IViewComponentResult Invoke() //Thanks to this method, we can call this component class in main html file
        {
            var books = new List<Book>()
            {
                new Book(){ID=6,Name="Letters to Milenna",Author="Frans Kafka", Price=5}
            };
            
            return View(books);
        }
    }
}

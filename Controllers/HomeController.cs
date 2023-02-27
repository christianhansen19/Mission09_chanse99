using Microsoft.AspNetCore.Mvc;
using Mission09_chanse99.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission09_chanse99.Controllers
{
    public class HomeController : Controller
    {
        private BookstoreContext context { get; set; }

        public HomeController (BookstoreContext temp)
        {
            context = temp;
        }

        public IActionResult Index()
        {
            var blah = context.Books.ToList();

            return View(blah);
        }
    }
}

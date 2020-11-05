using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace YarnsMobile.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult BrowseBooks()
        {
            return View();
        }

        public IActionResult MyBooks()
        {
            return View();
        }

        [Route("Books/Details/{id}")]
        public IActionResult Details()
        {
            return View();
        }
    }
}

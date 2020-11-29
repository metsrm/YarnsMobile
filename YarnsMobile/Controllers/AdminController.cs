using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using YarnsMobile.Models;
using YarnsMobile.Repositories;

namespace YarnsMobile.Controllers
{
    public class AdminController : Controller
    {
        private IRepository _repository;
        private IHostingEnvironment _environment;
        public AdminController(IRepository repository, IHostingEnvironment environment)
        {
            _repository = repository;
            _environment = environment;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddBook()
        {
            return View();
        }

        [HttpPost, ActionName("AddBook")]
        public IActionResult AddBookPost(Book book)
        {
            if(ModelState.IsValid)
            {
                if(book.CoverImage != null && book.CoverImage.Length > 0)
                {
                    book.ImageMimeType = book.CoverImage.ContentType;
                    book.Image = Path.GetFileName(book.CoverImage.FileName);
                    using (var memoryStream = new MemoryStream())
                    {
                        book.CoverImage.CopyTo(memoryStream);
                        book.PhotoFile = memoryStream.ToArray();
                    }
                }
                _repository.AddBook(book);
                return RedirectToAction(nameof(Index));
            }
            return View(book);
        }
    }
}

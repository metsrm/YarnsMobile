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
    public class BooksController : Controller
    {
        private IRepository _repository;
        private IHostingEnvironment _environment;
        public BooksController(IRepository repository, IHostingEnvironment environment)
        {
            _repository = repository;
            _environment = environment;
        }
        public IActionResult BrowseBooks()
        {
            var books = _repository.GetBooks();
            return View(books);
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

        public IActionResult GetImage(int id)
        {
            Book requestedBook = _repository.GetBookById(id);
            if (requestedBook != null)
            {
                string webRootpath = _environment.WebRootPath;
                string folderPath = "\\images\\";
                string fullPath = webRootpath + folderPath + requestedBook.Image;
                if (System.IO.File.Exists(fullPath))
                {
                    FileStream fileOnDisk = new FileStream(fullPath, FileMode.Open);
                    byte[] fileBytes;
                    using (BinaryReader br = new BinaryReader(fileOnDisk))
                    {
                        fileBytes = br.ReadBytes((int)fileOnDisk.Length);
                    }
                    return File(fileBytes, requestedBook.ImageMimeType);
                }
                else
                {
                    if (requestedBook.PhotoFile.Length > 0)
                    {
                        return File(requestedBook.PhotoFile, requestedBook.ImageMimeType);
                    }
                    else
                    {
                        return NotFound();
                    }
                }
            }
            else
            {
                return NotFound();
            }
        }
    }
}

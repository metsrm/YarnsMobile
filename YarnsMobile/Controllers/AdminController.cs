using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using YarnsMobile.Database;
using YarnsMobile.Models;
using YarnsMobile.Repositories;
using Microsoft.EntityFrameworkCore;
using YarnsMobile.ViewModels;

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
            IEnumerable<Book> books = _repository.GetBooks();
            return View(books);
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
    
        [Route("Admin/UpdateBook/{id}")]
        [HttpGet]
        public IActionResult UpdateBook(int id)
        {
            Book book = _repository.GetBookById(id);
            return View(book);
        }
        
        [Route("Admin/UpdateBook/{id}")]
        [HttpPost, ActionName("UpdateBook")]
        public IActionResult UpdateBookPost(Book book)
        {
            Book newBook = _repository.GetBookById(book.Id);
            if (ModelState.IsValid)
            {
                if (book.CoverImage != null && book.CoverImage.Length > 0)
                {
                    book.ImageMimeType = book.CoverImage.ContentType;
                    book.Image = Path.GetFileName(book.CoverImage.FileName);
                    using (var memoryStream = new MemoryStream())
                    {
                        book.CoverImage.CopyTo(memoryStream);
                        book.PhotoFile = memoryStream.ToArray();
                    }
                    newBook.Image = book.Image;
                    newBook.PhotoFile = book.PhotoFile;
                    newBook.ImageMimeType = book.ImageMimeType;
                }
                newBook.Title = book.Title;
                newBook.Author = book.Author;
                newBook.CopyrightYear = book.CopyrightYear;
                newBook.ISBN = book.ISBN;
                newBook.CurrentPrice = book.CurrentPrice;

                _repository.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(book);
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

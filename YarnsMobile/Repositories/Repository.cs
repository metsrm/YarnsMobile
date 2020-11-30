using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YarnsMobile.Database;
using YarnsMobile.Models;

namespace YarnsMobile.Repositories
{
    public class Repository : IRepository
    {
        private YarnsMobileContext _context;
        public Repository(YarnsMobileContext context)
        {
            _context = context;
        }

        public IEnumerable<Book> GetBooks()
        {
            return _context.Books.ToList();
        }

        public Book GetBookById(int id)
        {
            return _context.Books.FirstOrDefault(b => b.Id == id);
        }

        public void AddBook(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
        }

        public void UpdateBook(Book book)
        {
            _context.SaveChanges();
        }
    }
}

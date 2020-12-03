using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YarnsMobile.Models;
using YarnsMobile.ViewModels;

namespace YarnsMobile.Repositories
{
    public interface IRepository
    {
        IEnumerable<Book> GetBooks();
        Book GetBookById(int id);
        void AddBook(Book book);
        void UpdateBook(Book book);
    }
}

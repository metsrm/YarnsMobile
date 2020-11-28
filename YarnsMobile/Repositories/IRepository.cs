using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YarnsMobile.Models;

namespace YarnsMobile.Repositories
{
    public interface IRepository
    {
        IEnumerable<Book> GetBooks();
        void AddBook(Book book);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DataLayar.Repositories
{
    public interface IBookRepository
    {
        List<tb_Books> GetAllBooks();
        IEnumerable<tb_Books> GetBookByFilter(string parameter);
        tb_Books GetBookById(int bookId);
        bool InsertBook(tb_Books book);
        bool UpdateBook(tb_Books book);
        bool DeleteBook(tb_Books book);
        bool DeleteBook(int bookId);
    }
}

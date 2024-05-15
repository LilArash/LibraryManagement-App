using LibraryManagement.DataLayar.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace LibraryManagement.DataLayar.Services
{
    public class BookRepository : IBookRepository
    {
        private LibraryManagement_DBEntities db;
        public BookRepository(LibraryManagement_DBEntities context)
        {
            //give an instance of LibraryManagement_DBEntities
            db = context;
        }

        public bool DeleteBook(tb_Books book)
        {
            try
            {
                db.Entry(book).State = EntityState.Deleted;
                return true;
            }
            catch
            {

                return false;
            }
        }

        public bool DeleteBook(int bookId)
        {
            try
            {
                var book = GetBookById(bookId);
                DeleteBook(book);
                return true;
            }
            catch
            {

                return false;
            }
        }

        public List<tb_Books> GetAllBooks()
        {
            return db.tb_Books.ToList();
        }

        public IEnumerable<tb_Books> GetBookByFilter(string parameter)
        {
            return db.tb_Books.Where(b => b.bookName.Contains(parameter)
            || b.bookSubject.Contains(parameter) || b.bookWriter.Contains(parameter)).ToList();
        }

        public tb_Books GetBookById(int bookId)
        {
            return db.tb_Books.Find(bookId);
        }

        public bool InsertBook(tb_Books book)
        {
            try
            {
                db.tb_Books.Add(book);
                return true;
            }
            catch
            {

                return false;
            }
        }

        public bool UpdateBook(tb_Books book)
        {
            try
            {
                db.Entry(book).State = EntityState.Modified;
                return true;
            }
            catch
            {

                return false;
            }
        }
    }
}

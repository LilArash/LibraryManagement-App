using LibraryManagement.DataLayar.Repositories;
using LibraryManagement.DataLayar.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DataLayar.Context
{
    public class UnitOfWork : IDisposable
    {
        LibraryManagement_DBEntities db = new LibraryManagement_DBEntities();

        private IMemberRepository _memberRepository;
        public IMemberRepository MemberRepository
        {
            get
            {
                if (_memberRepository == null)
                {
                    _memberRepository = new MemberRepository(db);
                }
                return _memberRepository;
            }

        }

        private IBookRepository _bookRepository;
        public IBookRepository BookRepository
        {
            get
            {
                if(_bookRepository == null)
                {
                    _bookRepository = new BookRepository(db);
                }
                return _bookRepository;
            }
        }

        private GenericRepository<tb_BooksStatus1> _bookStatusRepository;
        public GenericRepository<tb_BooksStatus1> BookStatusRepository
        {
            get
            {
                if(_bookStatusRepository == null)
                {
                    _bookStatusRepository = new GenericRepository<tb_BooksStatus1> (db);
                }
                return _bookStatusRepository;
            }
        }

        private GenericRepository<tb_Login> _loginRepository;
        public GenericRepository<tb_Login> LoginRepository
        {
            get
            {
                if(_loginRepository == null)
                {
                    _loginRepository = new GenericRepository<tb_Login>(db);
                }

                return _loginRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}

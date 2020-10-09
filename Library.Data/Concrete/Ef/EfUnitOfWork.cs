using Library.Data.Concrete.Contexts;
using Library.Data.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Data.Concrete.Ef
{
    public class EfUnitOfWork : IUnitOfWork
    {
        private readonly LibraryContext context;
        public EfUnitOfWork(LibraryContext _context)
        {
            context = _context;
        }

        private IBookRepository _book;
        public IBookRepository books
        {
            get
            {
                return _book ?? (_book = new EfBookRepository(context));
            }
        }

        public bool SaveChanges()
        {
            try
            {
                context.SaveChanges();
                return true;
            }
            catch (Exception )
            {
                return false;
            }
        }
    }
}

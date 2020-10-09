using Library.Data.Concrete.Contexts;
using Library.Data.Interface;
using Library.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Data.Concrete.Ef
{
    public class EfBookRepository : EfGenericRepository<Book>, IBookRepository
    {
        public EfBookRepository(LibraryContext context) : base(context)
        {
                
        }

        //public LibraryContext Lcontext
        //{
        //   get { return context as LibraryContext; }
        //}
    }
}

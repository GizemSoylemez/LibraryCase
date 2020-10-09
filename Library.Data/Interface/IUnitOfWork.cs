using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Data.Interface
{
    public interface IUnitOfWork
    {
        IBookRepository books { get; }
        bool SaveChanges();
    }
}

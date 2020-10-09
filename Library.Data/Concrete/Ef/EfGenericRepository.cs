using Library.Data.Concrete.Contexts;
using Library.Data.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library.Data.Concrete.Ef
{
    public class EfGenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly LibraryContext context;
        public EfGenericRepository(LibraryContext _context)
        {
            context = _context;
        }
        public void Delete(T entity)
        {
            context.Set<T>().Remove(entity);
        }

        public T Get(int id)
        {
            return context.Set<T>().Find(id);
        }

        public IQueryable<T> GetAll()
        {
            return context.Set<T>();
        }

        public void Post(T entity)
        {
            context.Set<T>().Add(entity);
        }

        public void Put(T entity)
        {
            context.Entry(entity).State = EntityState.Modified;
        }
        public void Save()
        {
            context.SaveChanges();
                
        }
    }
}

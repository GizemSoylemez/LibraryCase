using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library.Data.Interface
{
    public interface IGenericRepository<T> where T : class
    {
        //Generic yapmamdaki amaç proje büyürse eğer generic bir yapıda olması için
        void Post(T entity);
        void Put(T entity);
        void Delete(T entity);
        T Get(int id);
        IQueryable<T> GetAll();
        void Save();
   
    }
}

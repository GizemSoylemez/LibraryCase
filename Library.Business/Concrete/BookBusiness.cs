using Library.Data.Concrete.Ef;
using Library.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Business.Concrete
{
    public class BookBusiness : IBookBusiness
    {
        private readonly EfBookRepository efBookRepository;
        public BookBusiness(EfBookRepository _efBookRepository)
        {
            efBookRepository = _efBookRepository;
        }

        //public void Delete()
        //{
        //    efBookRepository.Delete();
        //}

        //public Book Get(int id)
        //{
        //    return efBookRepository.Get(id);
        //}

        //public List<Book> GetAll()
        //{
        //    return efBookRepository.GetAll();
        //}

        //public void Post()
        //{
        //    efBookRepository.Post();
        //}

        //public void Put()
        //{
        //    efBookRepository.Put();
        //}

        //public void Save()
        //{
        //    efBookRepository.Save();
        //}
    }
}

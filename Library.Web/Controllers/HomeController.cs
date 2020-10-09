using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Library.Web.Models;
using Library.Data.Interface;

namespace Library.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork uow;

        public HomeController(IUnitOfWork _uow)
        {
            this.uow = _uow;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Book model)
        {
            Entities.Book book = new Entities.Book()
            {
                Name = model.Name,
                Author = model.Author
            };

            try
            {
                uow.books.Post(book);
                uow.SaveChanges();
            }
            catch (Exception)
            {
                // loglama
            }
            return View();
        }
        public IActionResult ListBook()
        {
            List<Book> bookList = new List<Book>();
            foreach (var item in uow.books.GetAll())
            {
                Book book = new Book()
                {
                    Id = item.Id,
                    Author = item.Author,
                    Name = item.Name
                };
                bookList.Add(book);
            }

            return View(bookList);
        }

        public IActionResult Delete(int id)
        {
            try
            {
                var deleted = uow.books.Get(id);
                uow.books.Delete(deleted);
                uow.SaveChanges();
            }
            catch (Exception)
            {
                //loglama
            }
            return RedirectToAction("ListBook");
        }
        public IActionResult Edit(int id)
        {
            Book book = new Book();
            try
            {
                var edit = uow.books.Get(id);
                book.Id = edit.Id;
                book.Name = edit.Name;
                book.Author = edit.Author;
            }
            catch (Exception)
            {
                //loglama
            }
            return View(book);
        }
        [HttpPost]
        public IActionResult Edit(Book model)
        {
            try
            {
                Entities.Book book = new Entities.Book()
                {
                    Author = model.Author,
                    Id = model.Id,
                    Name = model.Name
                };
                uow.books.Put(book);
                uow.SaveChanges();
            }
            catch (Exception)
            {
                //loglama
            }
            return View(model);
        }
    }
}

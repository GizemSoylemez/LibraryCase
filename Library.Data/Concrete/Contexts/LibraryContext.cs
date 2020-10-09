using Library.Data.Mapping;
using Library.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Data.Concrete.Contexts
{
    public class LibraryContext:DbContext
    {
        public LibraryContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //database bağlanacak
            optionsBuilder.UseSqlServer(@"server=DESKTOP-S1LPS5E\SQLEXPRESS;database=LibraryCase;integrated security=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Mapping klasörünü burada tanımlıyorum ki database ile bağlantısını kuruyorum
            modelBuilder.ApplyConfiguration(new BookMap());
        }

        //DbSet tablolarımı belirlemek için kullanılıyor    
        public DbSet<Book> Books { get; set; }
    }
}

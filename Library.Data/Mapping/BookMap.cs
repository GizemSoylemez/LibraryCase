using Library.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Data.Mapping
{
    public class BookMap : IEntityTypeConfiguration<Book>
    {
        //Bu klasörümü oluşturmamdaki amaç Solid prensiblerin ilk koşuluna Single responsibility kuralına uymak için
        //Aynı işlemleri Entities katmanı içerisinde Book classı içerisinde yapabilirdim ama bu herkes kendi görevini 
        //yapsın kuralına uymamaktadır.
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(I => I.Id);
            builder.Property(I => I.Name).HasMaxLength(100).IsRequired();
            builder.Property(I => I.Author).HasMaxLength(100).IsRequired();
        }
    }
}

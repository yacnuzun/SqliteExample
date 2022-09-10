using Entities;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.DatabaseContext
{
    public class EntegraDbContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=c:\Users\yacnu\sqlitedb\entegra.db;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
               new Product { Id = 1223, Name = "Finish Bulaşık Makinesi Parlatıcı 800 ml", ProductCode = "3007975", Quantity = 2 },
               new Product { Id = 1240, Name = "Finish Classic Jel Bulaşık Makinesi Deterjanı", ProductCode = "11", Quantity = 47 },
               new Product { Id = 1232, Name = "Fatih 2 pants", ProductCode = "w-l-12532w2i", Quantity = 12 },
               new Product { Id = 1237, Name= "MAVİ LOGO TİŞÖRT koyu yeşil", ProductCode = "065781-31966", Quantity = -1 },
               new Product { Id = 1233, Name = "Finish Bulaşık Makinesi Parlatıcı 800 ml", ProductCode = "12321321", Quantity = 51 }
               );
        }
        }
}

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
        public EntegraDbContext()
        {
        }
        public EntegraDbContext(DbContextOptions<EntegraDbContext> options) : base(options)
        {
        }



        public DbSet<Product> Products { get; set; }

        
    }
}

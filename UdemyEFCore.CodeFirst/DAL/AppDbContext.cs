using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyEFCore.CodeFirst.DAL
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; } // Products kısmı tabloya verecegı ısım 



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            Initalizer.Build(); 
            optionsBuilder.UseSqlServer(Initalizer.Configuration.GetConnectionString("SqlCon"));
        }
    }
}

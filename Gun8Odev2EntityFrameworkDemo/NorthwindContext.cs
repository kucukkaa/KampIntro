using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gun8Odev2EntityFrameworkDemo
{
    public class NorthwindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server= (localdb)\mssqllocaldb; database= Northwind; Trusted_Connection=true");
        }

        public DbSet<Product> Products { get; set; }
    }
}

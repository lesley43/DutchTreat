using Microsoft.EntityFrameworkCore;
using DutchTreat.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Linq;

namespace DutchTreat.Data
{
    public class DutchContext : DbContext
    {
        public DutchContext(DbContextOptions<DutchContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Order>()
                .HasData(new Order()
                {
                    Id = 1,
                    OrderDate = DateTime.Now,
                    OrderNumber = "12345"
                });
        }
    }

}

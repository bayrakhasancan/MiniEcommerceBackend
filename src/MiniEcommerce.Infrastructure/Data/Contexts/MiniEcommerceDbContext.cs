using Microsoft.EntityFrameworkCore;
using MiniEcommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace MiniEcommerce.Infrastructure.Data.Contexts
{
    public class MiniEcommerceDbContext(DbContextOptions<MiniEcommerceDbContext> options) : DbContext(options)
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Product>(entity =>
            {
                entity.OwnsOne(p => p.Price, money =>
                {
                    money.Property(m => m.Amount)
                         .HasColumnName("Amount")
                         .IsRequired();

                    money.Property(m => m.Currency)
                         .HasColumnName("Currency")
                         .HasConversion<string>() // Enum değerlerini string olarak saklamak için
                         .IsRequired();
                });
            });
        }
        public DbSet<Product> Products { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMVC.Models;

namespace SalesWebMVC.Data
{
    public class SalesWebMVCContext : DbContext
    {
        public SalesWebMVCContext (DbContextOptions<SalesWebMVCContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<SalesRecord>()
                .HasOne(sr => sr.Seller)
                .WithMany(s => s.Sales)
                .HasForeignKey(sr => sr.Id)
                .OnDelete(DeleteBehavior.Cascade);
        }

    }
}

﻿using Microsoft.EntityFrameworkCore;

namespace GummiBearKingdom.Models
{
    public class GummiBearKingdomDbContext : DbContext
    {
        public GummiBearKingdomDbContext()
        {
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=GummiBearKingdom;integrated security=True");
        }

        public GummiBearKingdomDbContext(DbContextOptions<GummiBearKingdomDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}

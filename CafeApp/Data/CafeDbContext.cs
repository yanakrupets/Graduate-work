using DIPLOM.Data.DB.Models;
using DIPLOM.Data.DB;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CafeApp.Data
{
    public class CafeDbContext : DbContext
    {
        public CafeDbContext(DbContextOptions<CafeDbContext> options)
            : base(options)
        {
        }

        public DbSet<Role> Roles { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Dish> Dishes { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Allergen> Allergens { get; set; }

        public DbSet<Booking> Bookings { get; set; }

        public DbSet<Ingridient> Ingridients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}

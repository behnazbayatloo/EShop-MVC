using EShop.Domain.Core.BasketAgg.Entity;
using EShop.Domain.Core.BasketItemAgg.Entity;
using EShop.Domain.Core.CategoryAgg.Entity;
using EShop.Domain.Core.OrderAgg.Entity;
using EShop.Domain.Core.OrderItemAgg.Entity;
using EShop.Domain.Core.ProductAgg.Entity;
using EShop.Domain.Core.UserAgg.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Infra.Db.Sql.DbCtx
{
    public class AppDbContext : IdentityDbContext<ApplicationUser, IdentityRole<int>,int>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.ConfigureWarnings(warnings =>
    warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityRole<int>>().HasData(
    new IdentityRole<int>
    {
        Id = 1,
        Name = "Admin",
        NormalizedName = "ADMIN"
    },
    new IdentityRole<int>
    {
        Id = 2,
        Name = "Customer",
        NormalizedName = "CUSTOMER"
    }
);

            modelBuilder.Entity<IdentityUserRole<int>>().HasData(
    new IdentityUserRole<int>
    {
        UserId = 1,
        RoleId = 1
    },
    new IdentityUserRole<int>
    {
        UserId = 2,
        RoleId = 2
    }
);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);

            base.OnModelCreating(modelBuilder);


        }
        
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<BasketItem> BasketItems { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}

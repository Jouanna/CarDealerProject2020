using CarDealerProject2020.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CarDealerProject2020.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        private const string connectionString = @"Server=.;Database=CarDealerProject2020;Integrated Security=true;";
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(connectionString);
            }

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Deal>()
                .HasOne(x => x.Detail)
                .WithMany(y => y.Deals)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Detail>()
                .HasOne(x => x.Vehicle)
                .WithMany(y => y.Details)
                .OnDelete(DeleteBehavior.Restrict);
        }

        public DbSet<BuyerInfo> BuyersInfos { get; set; }
        public DbSet<Deal> Deals { get; set; }
        public DbSet<Detail> Details { get; set; }
        public DbSet<SellerInfo> SellerInfos { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }

    }

}

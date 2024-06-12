using CarRentCM.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarRentCM.DAL.Context
{
    public class CarRentContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-4QIIH5S;database=CarRentCMDb;integrated security=true;");
        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<RentACar> RentACars { get; set; }
        public DbSet<BodyType> BodyTypes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RentACar>()
                .HasOne(x => x.PickUpLocation)
                .WithMany(x => x.PickUpLocation)
                .HasForeignKey(x => x.PickUpLocationId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<RentACar>()
               .HasOne(x => x.DropOffLocation)
               .WithMany(x => x.DropOffLocation)
               .HasForeignKey(x => x.DropOffLocationId)
               .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}

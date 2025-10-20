using Microsoft.EntityFrameworkCore;
using EventManagement.Models;

namespace EventManagement.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Event> Events { get; set; }
        public DbSet<Venue> Venues { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Venue>().HasData(
                new Venue { Id = 1, Name = "Grand Hall", Address = "123 Main St", Capacity = 500 },
                new Venue { Id = 2, Name = "Conference Room", Address = "456 Elm St", Capacity = 100 },
                new Venue { Id = 3, Name = "Outdoor Arena", Address = "789 Park Ave", Capacity = 1000 }
            );
        }
    }
}

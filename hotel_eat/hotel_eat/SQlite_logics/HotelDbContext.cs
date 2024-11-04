using Microsoft.EntityFrameworkCore;

namespace hotel_eat.SQlite_logics {
    public class HotelDbContext : DbContext {
        public DbSet<Room> Rooms { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderMenuItem> OrderMenuItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlite("Data Source=hotel_room_service.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) { 
            modelBuilder.Entity<OrderMenuItem>()
                .HasKey(omi => new { omi.OrderId, omi.MenuItemId });

            modelBuilder.Entity<OrderMenuItem>()
                .HasOne(omi => omi.Order)
                .WithMany(o => o.OrderMenuItems)
                .HasForeignKey(omi => omi.OrderId);

            modelBuilder.Entity<OrderMenuItem>()
                .HasOne(omi => omi.MenuItem)
                .WithMany(mi => mi.OrderMenuItems)
                .HasForeignKey(omi => omi.MenuItemId);
        }
    }
}

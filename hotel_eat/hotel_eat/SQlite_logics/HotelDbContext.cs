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
           modelBuilder.Entity<Room>().HasData(
               new Room { RoomId = 1, RoomNumber = 100,  IsOccupied = true},
               new Room { RoomId = 2, RoomNumber = 101, IsOccupied = true },
               new Room { RoomId = 3, RoomNumber = 102, IsOccupied = true }


           );
            modelBuilder.Entity<Order>().HasData(
                new Order {OrderId = 1 , RoomId = 1, OrderDateTime = DateTime.Now, TotalPrice = 2323}
                
            );
            modelBuilder.Entity<MenuItem>().HasData(
                new MenuItem { MenuItemId = 1, Name = "пицца", Price = 23, Description = "хз" }

            );
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

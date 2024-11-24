using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xz {
    public class HotelDbContext : DbContext {
        public DbSet<Room> Rooms { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            // Указываем SQLite как источник данных
            optionsBuilder.UseSqlite("Data Source=hotel.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
             modelBuilder.Entity<Room>().HasData(
               new Room { RoomId = 1, RoomNumber = 100,  IsOccupied = true},
               new Room { RoomId = 2, RoomNumber = 101, IsOccupied = true },
               new Room { RoomId = 3, RoomNumber = 102, IsOccupied = true }


           );
            modelBuilder.Entity<Order>().HasData(
                new Order {OrderId = 1 , RoomId = 1, MenuItemId = 1, OrderDateTime = DateTime.Now, Quantity = 2 }
                
            );
            modelBuilder.Entity<MenuItem>().HasData(
                new MenuItem { MenuItemId = 1, Name = "пицца", Price = 23 }

            );
            // Настройка связей
            modelBuilder.Entity<Order>()
                .HasOne(o => o.Room)
                .WithMany(r => r.Orders)
                .HasForeignKey(o => o.RoomId);

            modelBuilder.Entity<Order>()
                .HasOne(o => o.MenuItem)
                .WithMany(m => m.Orders)
                .HasForeignKey(o => o.MenuItemId);
        }
    }

}

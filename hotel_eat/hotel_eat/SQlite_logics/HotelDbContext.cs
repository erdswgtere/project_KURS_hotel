using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace hotel_eat.SQlite_logics {
    public class HotelDbContext : DbContext {
        public DbSet<Room> Rooms { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public HotelDbContext() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlite("Data Source=hotel_room_service.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            try {
                modelBuilder.Entity<Room>().HasData(
                    new Room { RoomId = 1, RoomNumber = 100, IsOccupied = true },
                    new Room { RoomId = 2, RoomNumber = 101, IsOccupied = true },
                    new Room { RoomId = 3, RoomNumber = 102, IsOccupied = true }


                );
                modelBuilder.Entity<Order>().HasData(
                new Order {
                    Id = 1,
                    RoomId = 1,
                    OrderDateTime = DateTime.Now,
                    OrderDetailsSerialized = "1:2;2:3" // 2 порции Пасты и 3 порции Салата
                }

                );
                modelBuilder.Entity<MenuItem>().HasData(
                    new MenuItem { MenuItemId = 1, Name = "Пицца", Price = 500, Category = "Основные блюда" },
                    new MenuItem { MenuItemId = 2, Name = "Кофе", Price = 100, Category = "Напитки" },
                    new MenuItem { MenuItemId = 3, Name = "Торт", Price = 200, Category = "Десерты" },
                    new MenuItem { MenuItemId = 4, Name = "Салат", Price = 300, Category = "Закуски" }

                );
                // Настройка связей
                modelBuilder.Entity<Room>()
                     .HasKey(r => r.RoomId);

                modelBuilder.Entity<Room>()
                    .Property(r => r.RoomNumber)
                    .IsRequired();

                // Конфигурация для MenuItem
                modelBuilder.Entity<MenuItem>()
                    .HasKey(m => m.MenuItemId);

                modelBuilder.Entity<MenuItem>()
                    .Property(m => m.Name)
                    .IsRequired();

                modelBuilder.Entity<MenuItem>()
                    .Property(m => m.Price)
                    .HasColumnType("decimal(18,2)");

                modelBuilder.Entity<MenuItem>()
                    .Property(m => m.Category)
                    .IsRequired();

                // Конфигурация для Order
                modelBuilder.Entity<Order>()
                    .HasKey(o => o.Id);

                modelBuilder.Entity<Order>()
                    .Property(o => o.OrderDateTime)
                    .IsRequired();

                modelBuilder.Entity<Order>()
                    .HasOne(o => o.Room)
                    .WithMany(r => r.Orders)
                    .HasForeignKey(o => o.RoomId);

                // Сохраняем OrderDetails в виде сериализованной строки
                modelBuilder.Entity<Order>()
                    .Property(o => o.OrderDetailsSerialized)
                    .HasColumnName("OrderDetails")
                    .IsRequired();
            }
            catch (SqliteException) {
                MessageBox.Show("Произошла ошибка при сохранении строки в базу данных, вероятно не заполнена одна из ячеек");
            }

        }
    }
}

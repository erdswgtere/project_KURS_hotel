using Microsoft.EntityFrameworkCore;

namespace hotel_eat.SQlite_logics
{
    public class OrderManager {
        private HotelDbContext _context;

        public OrderManager() {
            _context = new HotelDbContext();
        }

        public void CreateOrder(int roomId, List<int> menuItemIds) {
            var room = _context.Rooms.Find(roomId);
            if (room == null)
                throw new System.Exception("Room not found");

            var menuItems = _context.MenuItems.Where(mi => menuItemIds.Contains(mi.MenuItemId));
            if (!menuItems.Any())
                throw new System.Exception("No menu items selected");

            var order = new Order {
                RoomId = roomId,
                Room = room,
                OrderDateTime = System.DateTime.Now,
                TotalPrice = menuItems.Sum(mi => mi.Price),
                OrderMenuItems = (Microsoft.EntityFrameworkCore.ChangeTracking.ObservableCollectionListSource<OrderMenuItem>)menuItems.Select(mi => new OrderMenuItem {
                    MenuItemId = mi.MenuItemId,
                    MenuItem = mi
                })
            };

            _context.Orders.Add(order);
            _context.SaveChanges();
        }

        public List<Order> GetOrderHistory(int roomId) {
            return _context.Orders
                .Where(o => o.RoomId == roomId)
                .Include(o => o.OrderMenuItems)
                .ThenInclude(omi => omi.MenuItem)
                .ToList();
        }
    }

}

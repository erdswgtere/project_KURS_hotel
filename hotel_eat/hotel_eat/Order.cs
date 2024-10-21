namespace hotel_eat {
    public class Order {
        public int OrderId { get; set; }
        public Room Room { get; set; }
        public List<MenuItem> MenuItems { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime OrderDateTime { get; set; }

        public Order(Room room, List<MenuItem> menuItems) {
            Room = room;
            MenuItems = menuItems;
            TotalPrice = menuItems.Sum(item => item.Price);
            OrderDateTime = DateTime.Now;
        }
    }
}

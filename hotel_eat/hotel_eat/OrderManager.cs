namespace hotel_eat {
    public class OrderManager {
        private List<Order> orders;

        public OrderManager() {
            orders = new List<Order>();
        }

        public void CreateOrder(Room room, List<MenuItem> menuItems) {
            var newOrder = new Order(room, menuItems);
            orders.Add(newOrder);
        }

        public List<Order> GetOrderHistory() {
            return orders;
        }
    }

}

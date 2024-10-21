namespace hotel_eat {
    public class MenuItem {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        public MenuItem(string name, decimal price, string description) {
            Name = name;
            Price = price;
            Description = description;
        }
    }

}

using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.ComponentModel.DataAnnotations;

namespace hotel_eat {
    public class MenuItem{
        [Key]
        public int MenuItemId { get; set; } // Уникальный идентификатор
        public string Name { get; set; } // Название блюда
        public decimal Price { get; set; } // Цена блюда
        public string Category { get; set; }
        public virtual ObservableCollectionListSource<Order> Orders { get; set; }
    }

}

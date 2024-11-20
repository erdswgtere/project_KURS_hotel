using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.ComponentModel.DataAnnotations;

namespace hotel_eat {
    public class MenuItem {
        [Key]
        public int MenuItemId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public virtual ObservableCollectionListSource<OrderMenuItem> OrderMenuItems { get; set; }
    }

}

using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.ComponentModel.DataAnnotations;

namespace hotel_eat {
    public class Order {
        [Key]
        public int OrderId { get; set; }
        public int RoomId { get; set; }
        public Room Room { get; set; }
        public DateTime OrderDateTime { get; set; }
        public decimal TotalPrice { get; set; }
        public virtual ObservableCollectionListSource<OrderMenuItem> OrderMenuItems { get; set; }
    }
}

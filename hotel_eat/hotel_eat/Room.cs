using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.ComponentModel.DataAnnotations;

namespace hotel_eat {
    public class Room : BaseEntity {
        [Key]
        public int RoomId { get; set; }
        public int RoomNumber { get; set; }
        public bool IsOccupied { get; set; }
        public virtual ObservableCollectionListSource<Order> Orders { get; set; }
    }

}

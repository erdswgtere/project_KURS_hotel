using System.ComponentModel.DataAnnotations;

namespace hotel_eat {
    public class Room {
        [Key]
        public int RoomId { get; set; }
        public int RoomNumber { get; set; }
        public bool IsOccupied { get; set; }
        public ICollection<Order> Orders { get; set; }
    }

}

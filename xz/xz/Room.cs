using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xz {
    public class Room {
        public int RoomId { get; set; } // Уникальный идентификатор
        public int RoomNumber { get; set; } // Номер комнаты
        public bool IsOccupied { get; set; } // Занятость

        public ICollection<Order> Orders { get; set; } // Связь с заказами
    }

}

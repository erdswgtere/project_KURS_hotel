using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xz {
    public class Order {
        public int OrderId { get; set; } // Уникальный идентификатор
        public int RoomId { get; set; } // Идентификатор комнаты
        public int MenuItemId { get; set; } // Идентификатор позиции меню
        public DateTime OrderDateTime { get; set; } // Дата и время заказа
        public int Quantity { get; set; } // Количество

        public Room Room { get; set; } // Навигационное свойство для комнаты
        public MenuItem MenuItem { get; set; } // Навигационное свойство для меню
    }

}

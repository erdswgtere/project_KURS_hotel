using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xz {
    public class MenuItem {
        public int MenuItemId { get; set; } // Уникальный идентификатор
        public string Name { get; set; } // Название блюда
        public decimal Price { get; set; } // Цена блюда

        public ICollection<Order> Orders { get; set; } // Связь с заказами
    }

}

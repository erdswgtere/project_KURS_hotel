using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace hotel_eat {
    public class Order : IBaseEntity {
        public int Id { get; set; }
        public int RoomId { get; set; }
        public Room Room { get; set; }
        public DateTime OrderDateTime { get; set; }

        [NotMapped] // Поле не будет храниться в базе напрямую
        public Dictionary<int, int> OrderDetails { get; set; } = new Dictionary<int, int>();

        // Строка для хранения данных в базе
        public string OrderDetailsSerialized {
            get => SerializeOrderDetails();
            set => OrderDetails = DeserializeOrderDetails(value);
        }

        private string SerializeOrderDetails() {
            return string.Join(";", OrderDetails.Select(od => $"{od.Key}:{od.Value}"));
        }

        private Dictionary<int, int> DeserializeOrderDetails(string serialized) {
            return string.IsNullOrWhiteSpace(serialized)
                ? new Dictionary<int, int>()
                : serialized.Split(';')
                    .Select(part => part.Split(':'))
                    .ToDictionary(parts => int.Parse(parts[0]), parts => int.Parse(parts[1]));
        }
    }

}

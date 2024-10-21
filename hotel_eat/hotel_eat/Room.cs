namespace hotel_eat {
    public class Room {
        public int RoomNumber { get; set; }
        public bool IsOccupied { get; set; }

        public Room(int roomNumber, bool isOccupied) {
            RoomNumber = roomNumber;
            IsOccupied = isOccupied;
        }
    }

}

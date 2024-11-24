namespace xz {
    public partial class Form1 : Form {
        private DataGridView dgvRooms;
        private DataGridView dgvOrders;
        private ComboBox cmbMenuItems;
        private TextBox txtQuantity;
        private Button btnAddOrder;
        public Form1() {
            InitializeComponent();
            LoadRooms();
            LoadMenuItems();
        }
        private void LoadRooms() {
            using (var context = new HotelDbContext()) {
                dgvRooms.DataSource = context.Rooms.ToList();
            }
        }

        private void LoadOrders(int roomId) {
            using (var context = new HotelDbContext()) {
                dgvOrders.DataSource = context.Orders
                    .Where(o => o.RoomId == roomId)
                    .Select(o => new {
                        o.OrderId,
                        MenuItem = o.MenuItem.Name,
                        o.Quantity,
                        o.OrderDateTime
                    })
                    .ToList();
            }
        }

        private void LoadMenuItems() {
            using (var context = new HotelDbContext()) {
                cmbMenuItems.DataSource = context.MenuItems.ToList();
                cmbMenuItems.DisplayMember = "Name";
                cmbMenuItems.ValueMember = "MenuItemId";
            }
        }

        private void dgvRooms_SelectionChanged(object sender, EventArgs e) {
            if (dgvRooms.CurrentRow != null) {
                int roomId = (int)dgvRooms.CurrentRow.Cells["RoomId"].Value;
                LoadOrders(roomId);
            }
        }

        private void btnAddOrder_Click(object sender, EventArgs e) {
            if (dgvRooms.CurrentRow != null && cmbMenuItems.SelectedValue != null && int.TryParse(txtQuantity.Text, out int quantity)) {
                int roomId = (int)dgvRooms.CurrentRow.Cells["RoomId"].Value;
                int menuItemId = (int)cmbMenuItems.SelectedValue;

                using (var context = new HotelDbContext()) {
                    var order = new Order {
                        RoomId = roomId,
                        MenuItemId = menuItemId,
                        Quantity = quantity,
                        OrderDateTime = DateTime.Now
                    };

                    context.Orders.Add(order);
                    context.SaveChanges();
                }

                LoadOrders(roomId);
            }
            else {
                MessageBox.Show("Пожалуйста, заполните все поля!");
            }
        }
    }
}

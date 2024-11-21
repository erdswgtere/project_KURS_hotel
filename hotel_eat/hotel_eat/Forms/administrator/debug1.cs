using System.ComponentModel;
using hotel_eat.SQlite_logics;
using Microsoft.EntityFrameworkCore;

namespace hotel_eat.Forms.administrator {

    public partial class debug1 : Form {
        private HotelDbContext _context;
        private OrderManager _orderManager;
        public debug1() {
            InitializeComponent();
            _context = new HotelDbContext();
            _orderManager = new OrderManager();
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            _context.Database.EnsureCreated();
            _context.Rooms.Load();
            _context.MenuItems.Load();
            _context.Orders.Load();
            this.ordersBindingSource.DataSource = _context.Orders.Local.ToBindingList();
            this.roomBindingSource.DataSource = _context.Rooms.Local.ToBindingList();
        }
        protected override void OnClosing(CancelEventArgs e) {
            base.OnClosing(e);
            _context.Dispose();
            _context = null;
        }

        private void buttonSave_Click(object sender, EventArgs e) {
            this._context.SaveChanges();
            this.dataGridView1.Refresh();
            this.dataGridView2.Refresh();
            this.dataGridView3.Refresh();
            this.dataGridView4.Refresh();
        }
    }
}

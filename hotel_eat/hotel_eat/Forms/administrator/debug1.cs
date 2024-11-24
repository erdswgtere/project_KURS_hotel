using System.ComponentModel;
using hotel_eat.SQlite_logics;
using Microsoft.EntityFrameworkCore;

namespace hotel_eat.Forms.administrator {
    public partial class debug1 : Form {

        private HotelDbContext _context;
        public debug1() {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            this._context = new HotelDbContext();
            this._context.Database.EnsureCreated();
            this._context.Rooms.Load();
            this._context.MenuItems.Load();
            this._context.Orders.Load();
            this.ordersBindingSource.DataSource = _context.Orders.Local.ToBindingList();
            this.roomBindingSource.DataSource = _context.Rooms.Local.ToBindingList();
            this.menuItemBindingSource.DataSource = _context.MenuItems.Local.ToBindingList();
            LoadCategories();
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
            LoadCategories();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (dataGridView3.CurrentRow == null) {
                int menuitemid = (int)dataGridView3.CurrentRow.Cells["MenuItemId"].Value + 1;
                string Name = (string)dataGridView3.CurrentCell.Value;
                int price = (int)dataGridView3.CurrentCell.Value;
                string category = (string)dataGridView3.CurrentCell.Value;

                using (var context = _context) {
                    var MenuItem = new MenuItem {
                        Name = Name,
                        Price = price,
                        Category = category,
                    };

                    context.MenuItems.Add(MenuItem);
                    context.SaveChanges();
                }
            }
        }
        private void LoadCategories() {
            using (var context = new HotelDbContext()) {
                var categories = context.MenuItems
                    .Select(m => m.Category)
                    .Distinct()
                    .ToList();

                cmbCategories.DataSource = categories;
                cmbCategories.SelectedIndex = -1; // Без выбора по умолчанию
            }
        }

        private void delete_string_Click(object sender, EventArgs e) {
            if (dataGridView2.CurrentRow != null) {
                dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            if (dataGridView3.CurrentRow != null) {
                dataGridView3.Rows.Remove(dataGridView3.CurrentRow);
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            if (dataGridView1.CurrentRow != null) {
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            }
        }
    }
}

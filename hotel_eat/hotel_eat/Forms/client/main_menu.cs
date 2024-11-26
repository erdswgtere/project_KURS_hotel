using hotel_eat.SQlite_logics;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Text;

namespace hotel_eat.Forms {
    public partial class main_menu : Form {
        public Form MainForm { get; set; }
        public main_menu() {
            InitializeComponent();
            _ = LoadMenuItemsIntoMenuStripAsync(); // Асинхронная загрузка меню
        }

        private async Task LoadMenuItemsIntoMenuStripAsync() {
            menuStrip2.Items.Clear();

            using (var context = new HotelDbContext()) {
                // Получение категорий меню
                var categories = await context.MenuItems
                    .GroupBy(m => m.Category)
                    .Select(g => g.Key)
                    .ToListAsync();

                foreach (var category in categories) {
                    var categoryMenuItem = new ToolStripMenuItem(category);

                    // Получение блюд для категории
                    var items = await context.MenuItems
                        .Where(m => m.Category == category)
                        .ToListAsync();

                    foreach (var item in items) {
                        var menuItem = new ToolStripMenuItem($"{item.Name} - {item.Price:C}");
                        menuItem.Click += async (s, e) => await OnMenuItemClickedAsync(item);
                        menuItem.Click += async (s, e) => await PopulateListViewWithProductsAsync(item.Name);
                        categoryMenuItem.DropDownItems.Add(menuItem);
                    }

                    menuStrip2.Items.Add(categoryMenuItem);
                }
            }
        }
        private void button2_Click(object sender, EventArgs e) {
            listView1.Items.RemoveAt(listView1.SelectedItems.Count - 1);
        }

        private async Task PopulateListViewWithProductsAsync(string name) {
            if (listView1 == null)
                throw new InvalidOperationException("ListView не инициализирован. Используйте метод SetListView.");

            using (var context = new HotelDbContext()) {
                var products = await context.MenuItems
                    .Where(m => m.Name == name)
                    .ToListAsync();

                foreach (var product in products) {
                    var item = new ListViewItem(product.Name);
                    item.SubItems.Add(product.Price.ToString("C"));
                    item.Tag = product;
                    listView1.Items.Add(item);
                }
            }
        }

        private async Task OnMenuItemClickedAsync(MenuItem menuItem) {
            MessageBox.Show($"Вы выбрали блюдо: {menuItem.Name}\nЦена: {menuItem.Price:C}",
                "Информация о блюде", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async Task<decimal> CalculateTotalFromListViewAsync(System.Windows.Forms.ListView listView) {
            decimal total = 0m;
            var dishCounts = new Dictionary<string, int>();

            foreach (ListViewItem item in listView.Items) {
                string itemName = item.Text;

                if (dishCounts.ContainsKey(itemName)) {
                    dishCounts[itemName]++;
                } else {
                    dishCounts[itemName] = 1;
                }
            }

            using (var context = new HotelDbContext()) {
                foreach (var dish in dishCounts) {
                    var menuItem = await context.MenuItems.FirstOrDefaultAsync(m => m.Name == dish.Key);

                    if (menuItem != null) {
                        total += menuItem.Price * dish.Value;
                    } else {
                        throw new Exception($"Блюдо '{dish.Key}' не найдено в базе данных.");
                    }
                }
            }
            return total;
        }

        private async void button3_Click(object sender, EventArgs e) {
            textBox1.Text = (await CalculateTotalFromListViewAsync(listView1)).ToString();
        }

        private async void button1_Click(object sender, EventArgs e) {
            var dishCounts = new Dictionary<string, int>();

            foreach (ListViewItem item in listView1.Items) {
                string itemName = item.Text;

                if (dishCounts.ContainsKey(itemName)) {
                    dishCounts[itemName]++;
                } else {
                    dishCounts[itemName] = 1;
                }
            }

            if (dishCounts.Count == 0) {
                MessageBox.Show("Список блюд пуст. Добавьте блюда перед сохранением заказа.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var context = new HotelDbContext()) {
                var room = await context.Rooms.FirstOrDefaultAsync(r => r.RoomNumber == int.Parse(Roomnum.Roomname));

                try {
                    var newOrder = new Order {
                        RoomId = room.RoomId,
                        OrderDateTime = DateTime.Now
                    };

                    foreach (var dish in dishCounts) {
                        var menuItem = await context.MenuItems.FirstOrDefaultAsync(m => m.Name == dish.Key);
                        if (menuItem == null) {
                            MessageBox.Show($"Блюдо '{dish.Key}' не найдено в базе данных.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        newOrder.OrderDetails[menuItem.MenuItemId] = dish.Value;
                    }

                    context.Orders.Add(newOrder);
                    await context.SaveChangesAsync();

                    listView1.Items.Clear();
                    var result = MessageBox.Show("Заказ успешно сохранен! Сохранить чек?", "Успех", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes) {
                        await GenerateReceiptAsync(newOrder.Id);
                    }
                    if(result == DialogResult.No) {
                        var message = "Спасибо за заказ, ожидайте его получения!";
                        string caption = "Ожидание заказа";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult end;
                        end = MessageBox.Show(message, caption, buttons);
                        if (end == DialogResult.OK) {
                            this.Close();
                        }

                    }
                } catch (Exception ex) {
                    MessageBox.Show($"Произошла ошибка при сохранении заказа: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async Task GenerateReceiptAsync(int orderId) {
            using (var context = new HotelDbContext()) {
                var order = await context.Orders.Include(o => o.Room).FirstOrDefaultAsync(o => o.Id == orderId);

                if (order == null) {
                    MessageBox.Show("Заказ не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var receipt = new StringBuilder();
                receipt.AppendLine("***** ЧЕК *****");
                receipt.AppendLine($"Номер комнаты: {order.Room.RoomNumber}");
                receipt.AppendLine($"Дата заказа: {order.OrderDateTime:yyyy-MM-dd HH:mm}");
                receipt.AppendLine();
                receipt.AppendLine("Список блюд:");
                receipt.AppendLine("-------------------------------------");
                receipt.AppendLine("Название          Кол-во      Сумма");
                receipt.AppendLine("-------------------------------------");

                decimal totalSum = 0;

                foreach (var orderDetail in order.OrderDetails) {
                    var menuItem = await context.MenuItems.FirstOrDefaultAsync(m => m.MenuItemId == orderDetail.Key);
                    if (menuItem == null)
                        continue;

                    int quantity = orderDetail.Value;
                    decimal itemTotal = menuItem.Price * quantity;
                    totalSum += itemTotal;

                    receipt.AppendLine($"{menuItem.Name,-15} {quantity,-10} {itemTotal,8:C}");
                }

                receipt.AppendLine("-------------------------------------");
                receipt.AppendLine($"Итоговая сумма: {totalSum:C}");
                receipt.AppendLine("Спасибо за заказ!");

                string receiptFileName = $"Receipt_Order_{orderId}.txt";

                try {
                    await File.WriteAllTextAsync(receiptFileName, receipt.ToString());
                    MessageBox.Show($"Чек успешно сохранен: {receiptFileName}", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } catch (Exception ex) {
                    MessageBox.Show($"Ошибка при сохранении чека: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

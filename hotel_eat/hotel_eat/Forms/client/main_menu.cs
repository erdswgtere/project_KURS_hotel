using hotel_eat.SQlite_logics;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Text;

namespace hotel_eat.Forms {
    public partial class main_menu : Form {
        protected string roomnum;
        public Form MainForm { get; set; }
        public main_menu() {
            InitializeComponent();
            LoadMenuItemsIntoMenuStrip();

        }
        private void LoadMenuItemsIntoMenuStrip() {
            menuStrip2.Items.Clear();

            using (var context = new HotelDbContext()) {
                var categories = context.MenuItems
                    .GroupBy(m => m.Category)
                    .Select(g => g.Key)
                    .ToList();

                foreach (var category in categories) {
                    var categoryMenuItem = new ToolStripMenuItem(category);

                    var items = context.MenuItems
                        .Where(m => m.Category == category)
                        .ToList();
                    foreach (var item in items) {
                        // Создаем подменю для каждого блюда
                        var menuItem = new ToolStripMenuItem($"{item.Name} - {item.Price:C}");

                        textBox1.Text = "0";
                        menuItem.Click += (s, e) => OnMenuItemClicked(item);
                        menuItem.Click += (s, e) => PopulateListViewWithProducts(item.Name);
                        categoryMenuItem.DropDownItems.Add(menuItem);
                    }

                    // Добавляем категорию в MenuStrip
                    menuStrip2.Items.Add(categoryMenuItem);
                }
            }
        }

        private void PopulateListViewWithProducts(string name) {
            if (listView1 == null)
                throw new InvalidOperationException("ListView не инициализирован. Используйте метод SetListView.");

            using (var context = new HotelDbContext()) {
                // Получаем продукты для выбранной категории
                var products = context.MenuItems
                    .Where(m => m.Name == name)
                    .ToList();

                // Заполняем ListView продуктами
                foreach (var product in products) {
                    var item = new ListViewItem(product.Name); // Название блюда
                    item.SubItems.Add(product.Price.ToString("C")); // Цена блюда
                    item.Tag = product; // Сохраняем объект MenuItem для использования позже
                    listView1.Items.Add(item);
                }
            }
        }
        private void OnMenuItemClicked(MenuItem menuItem) {
            MessageBox.Show($"Вы выбрали блюдо: {menuItem.Name}\nЦена: {menuItem.Price:C}",
           "Информация о блюде", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // decimal fnl_price_dec = Convert.ToDecimal(textBox1.Text) + menuItem.Price;
            //fnl_price = fnl_price_dec.ToString() ;
        }

        private void button2_Click(object sender, EventArgs e) {
            listView1.Items.RemoveAt(listView1.SelectedItems.Count - 1);
        }

        public decimal CalculateTotalFromListView(System.Windows.Forms.ListView listView) {
            decimal total = 0m;

            // Создаем словарь для подсчета количества каждого блюда
            var dishCounts = new Dictionary<string, int>();

            // Проходим по всем элементам в ListView
            foreach (ListViewItem item in listView.Items) {
                string itemName = item.Text; // Название блюда (первый столбец)

                // Если блюдо уже встречалось, увеличиваем его счетчик
                if (dishCounts.ContainsKey(itemName)) {
                    dishCounts[itemName]++;
                }
                else {
                    // Если блюдо встречается первый раз, добавляем в словарь с количеством 1
                    dishCounts[itemName] = 1;
                }
            }

            // для каждого блюда получаем его цену из базы данных и считаем сумму
            using (var context = new HotelDbContext()) {
                foreach (var dish in dishCounts) {
                    var menuItem = context.MenuItems.FirstOrDefault(m => m.Name == dish.Key);

                    if (menuItem != null) {
                        // Рассчитываем стоимость для данного блюда и добавляем к общей сумме
                        total += menuItem.Price * dish.Value;
                    }
                    else {
                        // Если блюдо не найдено в базе данных, выводим ошибку
                        throw new Exception($"Блюдо '{dish.Key}' не найдено в базе данных.");
                    }
                }
            }
            return total;
        }


        private void button3_Click(object sender, EventArgs e) {
            textBox1.Text = CalculateTotalFromListView(listView1).ToString();
        }

        private void button1_Click(object sender, EventArgs e) {
            // Словарь для подсчета количества каждого блюда
            var dishCounts = new Dictionary<string, int>();

            // Проходим по элементам в ListView и заполняем словарь dishCounts
            foreach (ListViewItem item in listView1.Items) {
                string itemName = item.Text;

                if (dishCounts.ContainsKey(itemName)) {
                    dishCounts[itemName]++;
                }
                else {
                    dishCounts[itemName] = 1;
                }
            }

            if (dishCounts.Count == 0) {
                MessageBox.Show("Список блюд пуст. Добавьте блюда перед сохранением заказа.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (var context = new HotelDbContext()) {
                var room = context.Rooms.FirstOrDefault(r => r.RoomNumber == int.Parse(Roomnum.Roomname));

                try {
                    var newOrder = new Order {
                        RoomId = room.RoomId,
                        OrderDateTime = DateTime.Now
                    };
                    foreach (var dish in dishCounts) {
                        var menuItem = context.MenuItems.FirstOrDefault(m => m.Name == dish.Key);
                        if (menuItem == null) {
                            MessageBox.Show($"Блюдо '{dish.Key}' не найдено в базе данных.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        newOrder.OrderDetails[menuItem.MenuItemId] = dish.Value;
                    }
                    context.Orders.Add(newOrder);
                    context.SaveChanges();
                    var message = "Заказ успешно сохранен!";
                    string caption = "Успех";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;
                    result = MessageBox.Show(message, caption, buttons);
                    listView1.Items.Clear();
                    if (result == DialogResult.OK) {
                        DialogResult result2;
                        MessageBoxButtons buttons2 = MessageBoxButtons.YesNo;
                        var message2 = "Желаете ли сохранить чек?";
                        string caption2 = "Создание чека";
                        result2 = MessageBox.Show(message2, caption2, buttons2);
                        if (result2 == DialogResult.Yes) {
                            GenerateReceipt(newOrder.Id);
                        }
                        else {

                        }

                    }
                }
                catch (Exception ex) {
                    MessageBox.Show($"Произошла ошибка при сохранении заказа: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void GenerateReceipt(int orderId) {
            using (var context = new HotelDbContext()) {
                // Находим заказ по ID
                var order = context.Orders.Include(o => o.Room).FirstOrDefault(o => o.Id == orderId);

                if (order == null) {
                    MessageBox.Show("Заказ не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Инициализация строки чека
                var receipt = new StringBuilder();

                // Добавляем общую информацию о заказе
                receipt.AppendLine("***** ЧЕК *****");
                receipt.AppendLine($"Номер комнаты: {order.Room.RoomNumber}");
                receipt.AppendLine($"Дата заказа: {order.OrderDateTime:yyyy-MM-dd HH:mm}");
                receipt.AppendLine();
                receipt.AppendLine("Список блюд:");
                receipt.AppendLine("-------------------------------------");
                receipt.AppendLine("Название          Кол-во      Сумма");
                receipt.AppendLine("-------------------------------------");

                decimal totalSum = 0;

                // Обрабатываем блюда в заказе
                foreach (var orderDetail in order.OrderDetails) {
                    var menuItem = context.MenuItems.FirstOrDefault(m => m.MenuItemId == orderDetail.Key);
                    if (menuItem == null)
                        continue;

                    int quantity = orderDetail.Value;
                    decimal itemTotal = menuItem.Price * quantity;
                    totalSum += itemTotal;

                    // Форматируем строку для блюда
                    receipt.AppendLine($"{menuItem.Name,-15} {quantity,-10} {itemTotal,8:C}");
                }

                receipt.AppendLine("-------------------------------------");
                receipt.AppendLine($"Итоговая сумма: {totalSum:C}");
                receipt.AppendLine("Спасибо за заказ!");

                // Сохраняем чек в файл
                string receiptFileName = $"Receipt_Order_{orderId}.txt";
                try {
                    File.WriteAllText(receiptFileName, receipt.ToString());
                    MessageBox.Show($"Чек успешно сгенерирован и сохранен в файл: {receiptFileName}", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex) {
                    MessageBox.Show($"Ошибка при сохранении чека: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}

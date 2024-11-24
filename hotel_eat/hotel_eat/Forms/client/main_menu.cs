using hotel_eat.SQlite_logics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace hotel_eat.Forms {
    public partial class main_menu : Form {
        protected string roomnum;
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
    }
}

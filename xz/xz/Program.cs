namespace xz {
    internal static class Program {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            using (var context = new HotelDbContext()) {
                // Создание базы данных, если она отсутствует
                context.Database.EnsureCreated();

                // Инициализация данных, если они отсутствуют
                if (!context.MenuItems.Any()) {
                    context.MenuItems.AddRange(new[]
                    {
                    new MenuItem { Name = "Бургер", Price = 300 },
                    new MenuItem { Name = "Кофе", Price = 100 },
                });

                    context.SaveChanges();
                }
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

    }
}
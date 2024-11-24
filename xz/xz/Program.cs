namespace xz {
    internal static class Program {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            using (var context = new HotelDbContext()) {
                // �������� ���� ������, ���� ��� �����������
                context.Database.EnsureCreated();

                // ������������� ������, ���� ��� �����������
                if (!context.MenuItems.Any()) {
                    context.MenuItems.AddRange(new[]
                    {
                    new MenuItem { Name = "������", Price = 300 },
                    new MenuItem { Name = "����", Price = 100 },
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
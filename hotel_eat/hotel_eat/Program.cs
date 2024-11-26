using hotel_eat.Forms;
using Microsoft.Data.Sqlite;

namespace hotel_eat {
    internal static class Program {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            try { 
                ApplicationConfiguration.Initialize();
                Application.Run(new main_pannel());
            }
            catch (SqliteException) {
                MessageBox.Show("Произошла ошибка при сохранении строки в базу данных, вероятно не заполнена одна из ячеек");
            }
        }
    }
}
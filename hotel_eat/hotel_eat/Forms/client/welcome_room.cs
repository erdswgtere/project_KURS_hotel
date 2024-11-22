using hotel_eat.SQlite_logics;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace hotel_eat.Forms {
    public partial class welcome_room : Form {
        public welcome_room() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            if(input_num.Text.Length != 3 )
                input_num.Text = input_num.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e) {
            if (input_num.Text.Length != 3)
                input_num.Text = input_num.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e) {
            if (input_num.Text.Length != 3)
                input_num.Text = input_num.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e) {
            if (input_num.Text.Length != 3)
                input_num.Text = input_num.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e) {
            if (input_num.Text.Length != 3)
                input_num.Text = input_num.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e) {
            if (input_num.Text.Length != 3)
                input_num.Text = input_num.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e) {
            if (input_num.Text.Length != 3)
                input_num.Text = input_num.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e) {
            if (input_num.Text.Length != 3)
                input_num.Text = input_num.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e) {
            if (input_num.Text.Length != 3)
                input_num.Text = input_num.Text + "9";
        }

        private void enter_Click(object sender, EventArgs e) {
            using (HotelDbContext _context = new HotelDbContext()) {
                _context.Database.EnsureCreated();
                // создаем два объекта User
                var rooms = _context.Rooms.ToList();
                Console.WriteLine("Список объектов:");
                foreach (Room r in rooms) {
                    if(r.RoomNumber == int.Parse(input_num.Text) && r.IsOccupied == true) {
                        var message = "Создаётся заказ для вашего номера";
                        string caption = "Создание заказа";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result;
                        result = MessageBox.Show(message, caption, buttons);
                        if (result == DialogResult.OK) {
                            this.Close();
                        }
                    }
                }
            }
        }
    }
}

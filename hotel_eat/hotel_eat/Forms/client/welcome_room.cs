using hotel_eat.SQlite_logics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Windows.Forms;

namespace hotel_eat.Forms {
    public partial class welcome_room : Form {

        public Form MainForm { get; set; }
        public welcome_room() {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e) {
            if (input_num.Text.Length != 3)
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
        private void button0_Click(object sender, EventArgs e) {
            if (input_num.Text.Length != 3)
                input_num.Text = input_num.Text + "0";
        }

        private void enter_Click(object sender, EventArgs e) {
            using (HotelDbContext _context = new HotelDbContext()) {
                _context.Database.EnsureCreated();
                var rooms = _context.Rooms.ToList();
                foreach (Room r in rooms) {
                    if (Convert.ToString(r.RoomNumber) == input_num.Text && r.IsOccupied == true) {
                        var message = "Создаётся заказ для вашего номера";
                        string caption = "Создание заказа";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result;
                        result = MessageBox.Show(message, caption, buttons);
                        Roomnum.Roomname = input_num.Text;
                        if (result == DialogResult.OK) {
                            this.Close();
                            main_menu mnm = new main_menu();
                            mnm.MdiParent = MainForm;
                            mnm.Show();
                            mnm.MdiParent.LayoutMdi(MdiLayout.TileVertical);
                        }
                    }
                    else if (Convert.ToString(r.RoomNumber) != input_num.Text || r.IsOccupied != true) {
                        var message = "Комната которую вы выбрали не существует либо незанята";
                        string caption = "ОШИБКА!!!";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result;
                        result = MessageBox.Show(message, caption, buttons);
                        break;
                    }
                    break;
                }
            }
        }

        private void button10_Click(object sender, EventArgs e) {
            try {
                input_num.Text = input_num.Text.Remove(input_num.Text.Length - 1);
            }
            catch (ArgumentOutOfRangeException) {
                var message = "Нельзя удалять пустые строки";
                string caption = "ОШИБКА";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
            }
        }
    }
}

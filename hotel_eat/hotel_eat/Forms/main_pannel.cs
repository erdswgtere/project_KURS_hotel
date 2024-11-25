using hotel_eat.Forms.administrator;

namespace hotel_eat.Forms {
    public partial class main_pannel : Form {
        protected Form active;
        public Form Active {  get { return active; } set { active = value; } }

        public main_pannel() {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Maximized;
        }
        private void input_room_num_Click(object sender, EventArgs e) {
            if (active != null)
                active.Close();
            welcome_room welcome_Room = new welcome_room();
            active = welcome_Room;
            welcome_Room.MainForm = this;
            welcome_Room.MdiParent = this;
            welcome_Room.Show();
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        protected void create_deliv_Click(object sender, EventArgs e) {
            if (active != null)
                active.Close();
            main_menu mainmn = new();
            welcome_room main_room = new welcome_room();
            if (Roomnum.Roomname != null) {
                active = mainmn;
                mainmn.MdiParent = this;
                mainmn.Show();
                this.LayoutMdi(MdiLayout.TileVertical);
            }
            else {
                var message = "Не выбран номер гостиницы!";
                string caption = "ОШИБКА";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
            }
        }



        private void add_records_Click(object sender, EventArgs e) {

        }

        private void debugstr_Click(object sender, EventArgs e) {
            if (active != null)
                active.Close();
            debug1 dbg = new();
            active = dbg;
            dbg.MdiParent = this;
            dbg.Show();
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        public void opn_nxt(Form act) {
            if (active != null)
                active.Close();
            active = act;
            active.MdiParent = this;
            active.Show();
            this.LayoutMdi(MdiLayout.TileVertical);
        }
    }
}


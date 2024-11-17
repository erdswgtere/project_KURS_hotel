﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel_eat.Forms {
    public partial class main_pannel : Form {
        private Form active;

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
            welcome_Room.MdiParent = this;
            welcome_Room.Show();
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void create_deliv_Click(object sender, EventArgs e) {
            if (active != null)
                active.Close();
            main_menu mainmn = new main_menu();
            active = mainmn;
            mainmn.MdiParent = this;
            mainmn.Show();
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void print_delivpage_Click(object sender, EventArgs e) {
            if (active != null)
                active.Close();
            check_final chkfnl = new check_final();
            active = chkfnl;
            chkfnl.MdiParent = this;
            chkfnl.Show();
            this.LayoutMdi(MdiLayout.TileVertical);
        }
    }
}

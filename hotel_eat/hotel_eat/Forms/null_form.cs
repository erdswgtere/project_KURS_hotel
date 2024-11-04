using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace hotel_eat.Forms {
    public partial class null_form : Form {
        private Form active;
        public null_form() {
            InitializeComponent();
        }
        private void PanelForm(Form fm) {
            if (active != null)
                active.Close();

            active = fm;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            panelxz.Controls.Add(fm);
            panelxz.Tag = fm;
            fm.BringToFront();
            fm.Show();
        }
        private void null_form_Load(object sender, EventArgs e) {
            PanelForm(new welcome());
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            button1.FlatStyle = FlatStyle.Flat;
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
        }
    }
}

namespace hotel_eat.Forms {
    partial class main_pannel {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            panel1 = new Panel();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            input_room_num = new ToolStripMenuItem();
            create_deliv = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            debugstr = new ToolStripMenuItem();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(menuStrip1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 46);
            panel1.TabIndex = 2;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.Fill;
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 46);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { input_room_num, create_deliv });
            toolStripMenuItem1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 204);
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(121, 42);
            toolStripMenuItem1.Text = "Для клиента";
            // 
            // input_room_num
            // 
            input_room_num.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Underline);
            input_room_num.Name = "input_room_num";
            input_room_num.Size = new Size(227, 22);
            input_room_num.Text = "Ввести номер комнаты";
            input_room_num.Click += input_room_num_Click;
            // 
            // create_deliv
            // 
            create_deliv.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Underline);
            create_deliv.Name = "create_deliv";
            create_deliv.Size = new Size(227, 22);
            create_deliv.Text = "Сделать заказ";
            create_deliv.Click += create_deliv_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { debugstr });
            toolStripMenuItem2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 204);
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(188, 42);
            toolStripMenuItem2.Text = "Для администратора";
            // 
            // debugstr
            // 
            debugstr.Name = "debugstr";
            debugstr.Size = new Size(289, 26);
            debugstr.Text = "Меню редактирования БД";
            debugstr.Click += debugstr_Click;
            // 
            // main_pannel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 489);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Name = "main_pannel";
            Text = "main_pannel";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem input_room_num;
        private ToolStripMenuItem create_deliv;
        private ToolStripMenuItem debugstr;
    }
}
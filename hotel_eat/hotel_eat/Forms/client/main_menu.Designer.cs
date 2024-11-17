namespace hotel_eat.Forms {
    partial class main_menu {
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
            menuStrip2 = new MenuStrip();
            drinks = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            des = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripMenuItem();
            fastfood = new ToolStripMenuItem();
            toolStripMenuItem6 = new ToolStripMenuItem();
            hoteat = new ToolStripMenuItem();
            label1 = new Label();
            listView1 = new ListView();
            button1 = new Button();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip2
            // 
            menuStrip2.BackColor = Color.DarkGray;
            menuStrip2.Dock = DockStyle.Left;
            menuStrip2.Items.AddRange(new ToolStripItem[] { drinks, des, fastfood, hoteat });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(126, 520);
            menuStrip2.TabIndex = 0;
            menuStrip2.Text = "menuStrip2";
            // 
            // drinks
            // 
            drinks.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem4 });
            drinks.Name = "drinks";
            drinks.Size = new Size(118, 19);
            drinks.Text = "Напитки";
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(180, 22);
            toolStripMenuItem4.Text = "toolStripMenuItem4";
            // 
            // des
            // 
            des.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem5 });
            des.Name = "des";
            des.Size = new Size(118, 19);
            des.Text = "Десерты";
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(180, 22);
            toolStripMenuItem5.Text = "toolStripMenuItem5";
            // 
            // fastfood
            // 
            fastfood.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem6 });
            fastfood.Name = "fastfood";
            fastfood.Size = new Size(118, 19);
            fastfood.Text = "Быстрое питание";
            // 
            // toolStripMenuItem6
            // 
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new Size(180, 22);
            toolStripMenuItem6.Text = "toolStripMenuItem6";
            // 
            // hoteat
            // 
            hoteat.Name = "hoteat";
            hoteat.Size = new Size(113, 19);
            hoteat.Text = "Горячее питание";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 204);
            label1.Location = new Point(164, 9);
            label1.Name = "label1";
            label1.Size = new Size(605, 37);
            label1.TabIndex = 1;
            label1.Text = "Выберите блюда для формирования заказа";
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.Top;
            listView1.Location = new Point(310, 110);
            listView1.Name = "listView1";
            listView1.Size = new Size(260, 152);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 204);
            button1.Location = new Point(310, 303);
            button1.Name = "button1";
            button1.Size = new Size(260, 57);
            button1.TabIndex = 4;
            button1.Text = "Заказать";
            button1.UseVisualStyleBackColor = true;
            // 
            // main_menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 520);
            Controls.Add(button1);
            Controls.Add(listView1);
            Controls.Add(label1);
            Controls.Add(menuStrip2);
            MainMenuStrip = menuStrip2;
            Name = "main_menu";
            Text = "main_menu";
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem drinks;
        private ToolStripMenuItem des;
        private ToolStripMenuItem fastfood;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem toolStripMenuItem6;
        private Label label1;
        private ToolStripMenuItem hoteat;
        private ListView listView1;
        private Button button1;
    }
}
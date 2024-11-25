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
            label1 = new Label();
            listView1 = new ListView();
            button1 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // menuStrip2
            // 
            menuStrip2.BackColor = Color.DarkGray;
            menuStrip2.Dock = DockStyle.Left;
            menuStrip2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 204);
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(30, 520);
            menuStrip2.TabIndex = 0;
            menuStrip2.Text = "menuStrip2";
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
            listView1.AccessibleRole = AccessibleRole.ScrollBar;
            listView1.Anchor = AnchorStyles.Top;
            listView1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            listView1.LabelEdit = true;
            listView1.Location = new Point(310, 110);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(260, 152);
            listView1.TabIndex = 3;
            listView1.TileSize = new Size(228, 20);
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Tile;
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
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Right;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(608, 130);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(160, 29);
            textBox1.TabIndex = 5;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(636, 106);
            label2.Name = "label2";
            label2.Size = new Size(122, 21);
            label2.TabIndex = 6;
            label2.Text = "Сумма заказа:";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Right;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 204);
            button2.Location = new Point(608, 429);
            button2.Name = "button2";
            button2.Size = new Size(169, 45);
            button2.TabIndex = 7;
            button2.Text = "Удалить из заказа";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Right;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 204);
            button3.Location = new Point(608, 334);
            button3.Name = "button3";
            button3.Size = new Size(169, 45);
            button3.TabIndex = 8;
            button3.Text = "Расчитать сумму заказа";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // main_menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 520);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(listView1);
            Controls.Add(label1);
            Controls.Add(menuStrip2);
            MainMenuStrip = menuStrip2;
            Name = "main_menu";
            Text = "main_menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private MenuStrip menuStrip2;
        private Label label1;
        private ListView listView1;
        private Button button1;
        private TextBox textBox1;
        private Label label2;
        private Button button2;
        private Button button3;
    }
}
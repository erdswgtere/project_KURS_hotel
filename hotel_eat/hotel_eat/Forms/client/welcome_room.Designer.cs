namespace hotel_eat.Forms {
    partial class welcome_room {
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
            welcome_message = new Label();
            room_message = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            enter = new Button();
            input_num = new TextBox();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // welcome_message
            // 
            welcome_message.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            welcome_message.AutoSize = true;
            welcome_message.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 204);
            welcome_message.Location = new Point(188, 21);
            welcome_message.Name = "welcome_message";
            welcome_message.Size = new Size(441, 37);
            welcome_message.TabIndex = 0;
            welcome_message.Text = "Добро пожаловать в ИСОПВГ!!!";
            // 
            // room_message
            // 
            room_message.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            room_message.AutoSize = true;
            room_message.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 204);
            room_message.Location = new Point(244, 87);
            room_message.Name = "room_message";
            room_message.Size = new Size(321, 32);
            room_message.TabIndex = 1;
            room_message.Text = "Введите номер комнаты";
            // 
            // button1
            // 
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.Location = new Point(58, 19);
            button1.Name = "button1";
            button1.Size = new Size(75, 25);
            button1.TabIndex = 2;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(161, 19);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(269, 19);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 4;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(58, 63);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 5;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(161, 63);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 6;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(269, 63);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 7;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(58, 105);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 8;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(161, 105);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 9;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(269, 105);
            button9.Name = "button9";
            button9.Size = new Size(75, 23);
            button9.TabIndex = 10;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // enter
            // 
            enter.Location = new Point(269, 142);
            enter.Name = "enter";
            enter.Size = new Size(83, 40);
            enter.TabIndex = 11;
            enter.Text = "Ввод";
            enter.UseVisualStyleBackColor = true;
            enter.Click += enter_Click;
            // 
            // input_num
            // 
            input_num.Anchor = AnchorStyles.Top;
            input_num.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            input_num.Location = new Point(254, 138);
            input_num.MaxLength = 3;
            input_num.Name = "input_num";
            input_num.Size = new Size(286, 43);
            input_num.TabIndex = 12;
            input_num.TextAlign = HorizontalAlignment.Center;
            input_num.WordWrap = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panel1.Controls.Add(enter);
            panel1.Controls.Add(button9);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(188, 222);
            panel1.Name = "panel1";
            panel1.Size = new Size(442, 182);
            panel1.TabIndex = 13;
            // 
            // welcome_room
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(871, 495);
            Controls.Add(panel1);
            Controls.Add(input_num);
            Controls.Add(room_message);
            Controls.Add(welcome_message);
            Name = "welcome_room";
            StartPosition = FormStartPosition.CenterParent;
            Text = "welcome_room";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label welcome_message;
        private Label room_message;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button enter;
        private TextBox input_num;
        private Panel panel1;
    }
}
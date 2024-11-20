namespace hotel_eat.Forms.administrator {
    partial class room_menu {
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
            components = new System.ComponentModel.Container();
            dgvRooms = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            roomBindingSource = new BindingSource(components);
            roomIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            roomNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isOccupiedDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            ordersDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvRooms).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roomBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgvRooms
            // 
            dgvRooms.AllowUserToOrderColumns = true;
            dgvRooms.AutoGenerateColumns = false;
            dgvRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRooms.Columns.AddRange(new DataGridViewColumn[] { roomIdDataGridViewTextBoxColumn, roomNumberDataGridViewTextBoxColumn, isOccupiedDataGridViewCheckBoxColumn, ordersDataGridViewTextBoxColumn });
            dgvRooms.DataSource = roomBindingSource;
            dgvRooms.Location = new Point(153, 34);
            dgvRooms.Name = "dgvRooms";
            dgvRooms.Size = new Size(444, 259);
            dgvRooms.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(153, 343);
            button1.Name = "button1";
            button1.Size = new Size(122, 45);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(472, 343);
            button2.Name = "button2";
            button2.Size = new Size(125, 45);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // roomBindingSource
            // 
            roomBindingSource.DataSource = typeof(Room);
            // 
            // roomIdDataGridViewTextBoxColumn
            // 
            roomIdDataGridViewTextBoxColumn.DataPropertyName = "RoomId";
            roomIdDataGridViewTextBoxColumn.HeaderText = "RoomId";
            roomIdDataGridViewTextBoxColumn.Name = "roomIdDataGridViewTextBoxColumn";
            // 
            // roomNumberDataGridViewTextBoxColumn
            // 
            roomNumberDataGridViewTextBoxColumn.DataPropertyName = "RoomNumber";
            roomNumberDataGridViewTextBoxColumn.HeaderText = "RoomNumber";
            roomNumberDataGridViewTextBoxColumn.Name = "roomNumberDataGridViewTextBoxColumn";
            // 
            // isOccupiedDataGridViewCheckBoxColumn
            // 
            isOccupiedDataGridViewCheckBoxColumn.DataPropertyName = "IsOccupied";
            isOccupiedDataGridViewCheckBoxColumn.HeaderText = "IsOccupied";
            isOccupiedDataGridViewCheckBoxColumn.Name = "isOccupiedDataGridViewCheckBoxColumn";
            // 
            // ordersDataGridViewTextBoxColumn
            // 
            ordersDataGridViewTextBoxColumn.DataPropertyName = "Orders";
            ordersDataGridViewTextBoxColumn.HeaderText = "Orders";
            ordersDataGridViewTextBoxColumn.Name = "ordersDataGridViewTextBoxColumn";
            // 
            // room_menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dgvRooms);
            Name = "room_menu";
            Text = "menu_edit";
            ((System.ComponentModel.ISupportInitialize)dgvRooms).EndInit();
            ((System.ComponentModel.ISupportInitialize)roomBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvRooms;
        private Button button1;
        private Button button2;
        private DataGridViewTextBoxColumn roomIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn roomNumberDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isOccupiedDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn ordersDataGridViewTextBoxColumn;
        private BindingSource roomBindingSource;
    }
}
namespace hotel_eat.Forms.administrator {
    partial class order_bd_edit {
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            orderBindingSource = new BindingSource(components);
            orderIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            roomIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            roomDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            orderDateTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            orderMenuItemsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { orderIdDataGridViewTextBoxColumn, roomIdDataGridViewTextBoxColumn, roomDataGridViewTextBoxColumn, orderDateTimeDataGridViewTextBoxColumn, totalPriceDataGridViewTextBoxColumn, orderMenuItemsDataGridViewTextBoxColumn });
            dataGridView1.DataSource = orderBindingSource;
            dataGridView1.Location = new Point(110, 42);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(621, 340);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(110, 433);
            button1.Name = "button1";
            button1.Size = new Size(172, 56);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(570, 433);
            button2.Name = "button2";
            button2.Size = new Size(161, 52);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // orderBindingSource
            // 
            orderBindingSource.DataSource = typeof(Order);
            // 
            // orderIdDataGridViewTextBoxColumn
            // 
            orderIdDataGridViewTextBoxColumn.DataPropertyName = "OrderId";
            orderIdDataGridViewTextBoxColumn.HeaderText = "OrderId";
            orderIdDataGridViewTextBoxColumn.Name = "orderIdDataGridViewTextBoxColumn";
            // 
            // roomIdDataGridViewTextBoxColumn
            // 
            roomIdDataGridViewTextBoxColumn.DataPropertyName = "RoomId";
            roomIdDataGridViewTextBoxColumn.HeaderText = "RoomId";
            roomIdDataGridViewTextBoxColumn.Name = "roomIdDataGridViewTextBoxColumn";
            // 
            // roomDataGridViewTextBoxColumn
            // 
            roomDataGridViewTextBoxColumn.DataPropertyName = "Room";
            roomDataGridViewTextBoxColumn.HeaderText = "Room";
            roomDataGridViewTextBoxColumn.Name = "roomDataGridViewTextBoxColumn";
            // 
            // orderDateTimeDataGridViewTextBoxColumn
            // 
            orderDateTimeDataGridViewTextBoxColumn.DataPropertyName = "OrderDateTime";
            orderDateTimeDataGridViewTextBoxColumn.HeaderText = "OrderDateTime";
            orderDateTimeDataGridViewTextBoxColumn.Name = "orderDateTimeDataGridViewTextBoxColumn";
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            totalPriceDataGridViewTextBoxColumn.HeaderText = "TotalPrice";
            totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            // 
            // orderMenuItemsDataGridViewTextBoxColumn
            // 
            orderMenuItemsDataGridViewTextBoxColumn.DataPropertyName = "OrderMenuItems";
            orderMenuItemsDataGridViewTextBoxColumn.HeaderText = "OrderMenuItems";
            orderMenuItemsDataGridViewTextBoxColumn.Name = "orderMenuItemsDataGridViewTextBoxColumn";
            // 
            // order_bd_edit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 539);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "order_bd_edit";
            Text = "order_bd_edit";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn roomIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn roomDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn orderDateTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn orderMenuItemsDataGridViewTextBoxColumn;
        private BindingSource orderBindingSource;
    }
}
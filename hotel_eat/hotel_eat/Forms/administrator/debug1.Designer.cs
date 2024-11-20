namespace hotel_eat.Forms.administrator {
    partial class debug1 {
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
            roomBindingSource = new BindingSource(components);
            dataGridView2 = new DataGridView();
            orderIdDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            orderDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            menuItemIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            menuItemDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            orderMenuItemsBindingSource = new BindingSource(components);
            ordersBindingSource = new BindingSource(components);
            dataGridView3 = new DataGridView();
            dataGridView4 = new DataGridView();
            menuItemBindingSource = new BindingSource(components);
            roomIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            roomNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isOccupiedDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            menuItemIdDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            orderIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            roomIdDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            roomDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            orderDateTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roomBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderMenuItemsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ordersBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)menuItemBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { roomIdDataGridViewTextBoxColumn, roomNumberDataGridViewTextBoxColumn, isOccupiedDataGridViewCheckBoxColumn });
            dataGridView1.DataSource = roomBindingSource;
            dataGridView1.Location = new Point(29, 35);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(343, 150);
            dataGridView1.TabIndex = 0;
            // 
            // roomBindingSource
            // 
            roomBindingSource.DataSource = typeof(Room);
            // 
            // dataGridView2
            // 
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { orderIdDataGridViewTextBoxColumn1, orderDataGridViewTextBoxColumn, menuItemIdDataGridViewTextBoxColumn, menuItemDataGridViewTextBoxColumn });
            dataGridView2.DataSource = orderMenuItemsBindingSource;
            dataGridView2.Location = new Point(474, 35);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(450, 150);
            dataGridView2.TabIndex = 1;
            // 
            // orderIdDataGridViewTextBoxColumn1
            // 
            orderIdDataGridViewTextBoxColumn1.DataPropertyName = "OrderId";
            orderIdDataGridViewTextBoxColumn1.HeaderText = "OrderId";
            orderIdDataGridViewTextBoxColumn1.Name = "orderIdDataGridViewTextBoxColumn1";
            // 
            // orderDataGridViewTextBoxColumn
            // 
            orderDataGridViewTextBoxColumn.DataPropertyName = "Order";
            orderDataGridViewTextBoxColumn.HeaderText = "Order";
            orderDataGridViewTextBoxColumn.Name = "orderDataGridViewTextBoxColumn";
            // 
            // menuItemIdDataGridViewTextBoxColumn
            // 
            menuItemIdDataGridViewTextBoxColumn.DataPropertyName = "MenuItemId";
            menuItemIdDataGridViewTextBoxColumn.HeaderText = "MenuItemId";
            menuItemIdDataGridViewTextBoxColumn.Name = "menuItemIdDataGridViewTextBoxColumn";
            // 
            // menuItemDataGridViewTextBoxColumn
            // 
            menuItemDataGridViewTextBoxColumn.DataPropertyName = "MenuItem";
            menuItemDataGridViewTextBoxColumn.HeaderText = "MenuItem";
            menuItemDataGridViewTextBoxColumn.Name = "menuItemDataGridViewTextBoxColumn";
            // 
            // orderMenuItemsBindingSource
            // 
            orderMenuItemsBindingSource.DataMember = "OrderMenuItems";
            orderMenuItemsBindingSource.DataSource = ordersBindingSource;
            // 
            // ordersBindingSource
            // 
            ordersBindingSource.DataMember = "Orders";
            ordersBindingSource.DataSource = roomBindingSource;
            // 
            // dataGridView3
            // 
            dataGridView3.AutoGenerateColumns = false;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { orderIdDataGridViewTextBoxColumn, roomIdDataGridViewTextBoxColumn1, roomDataGridViewTextBoxColumn, orderDateTimeDataGridViewTextBoxColumn, totalPriceDataGridViewTextBoxColumn });
            dataGridView3.DataSource = ordersBindingSource;
            dataGridView3.Location = new Point(29, 380);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(539, 198);
            dataGridView3.TabIndex = 2;
            // 
            // dataGridView4
            // 
            dataGridView4.AutoGenerateColumns = false;
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Columns.AddRange(new DataGridViewColumn[] { menuItemIdDataGridViewTextBoxColumn1, nameDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn });
            dataGridView4.DataSource = menuItemBindingSource;
            dataGridView4.Location = new Point(29, 217);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.Size = new Size(465, 135);
            dataGridView4.TabIndex = 3;
            // 
            // menuItemBindingSource
            // 
            menuItemBindingSource.DataSource = typeof(MenuItem);
            // 
            // roomIdDataGridViewTextBoxColumn
            // 
            roomIdDataGridViewTextBoxColumn.DataPropertyName = "RoomId";
            roomIdDataGridViewTextBoxColumn.HeaderText = "RoomId";
            roomIdDataGridViewTextBoxColumn.Name = "roomIdDataGridViewTextBoxColumn";
            roomIdDataGridViewTextBoxColumn.ReadOnly = true;
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
            // menuItemIdDataGridViewTextBoxColumn1
            // 
            menuItemIdDataGridViewTextBoxColumn1.DataPropertyName = "MenuItemId";
            menuItemIdDataGridViewTextBoxColumn1.HeaderText = "MenuItemId";
            menuItemIdDataGridViewTextBoxColumn1.Name = "menuItemIdDataGridViewTextBoxColumn1";
            menuItemIdDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // orderIdDataGridViewTextBoxColumn
            // 
            orderIdDataGridViewTextBoxColumn.DataPropertyName = "OrderId";
            orderIdDataGridViewTextBoxColumn.HeaderText = "OrderId";
            orderIdDataGridViewTextBoxColumn.Name = "orderIdDataGridViewTextBoxColumn";
            orderIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomIdDataGridViewTextBoxColumn1
            // 
            roomIdDataGridViewTextBoxColumn1.DataPropertyName = "RoomId";
            roomIdDataGridViewTextBoxColumn1.HeaderText = "RoomId";
            roomIdDataGridViewTextBoxColumn1.Name = "roomIdDataGridViewTextBoxColumn1";
            roomIdDataGridViewTextBoxColumn1.Visible = false;
            // 
            // roomDataGridViewTextBoxColumn
            // 
            roomDataGridViewTextBoxColumn.DataPropertyName = "Room";
            roomDataGridViewTextBoxColumn.HeaderText = "Room";
            roomDataGridViewTextBoxColumn.Name = "roomDataGridViewTextBoxColumn";
            roomDataGridViewTextBoxColumn.Visible = false;
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
            // debug1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(963, 603);
            Controls.Add(dataGridView4);
            Controls.Add(dataGridView3);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Name = "debug1";
            Text = "debug1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)roomBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderMenuItemsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)ordersBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ((System.ComponentModel.ISupportInitialize)menuItemBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource roomBindingSource;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn orderDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn menuItemIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn menuItemDataGridViewTextBoxColumn;
        private BindingSource orderMenuItemsBindingSource;
        private BindingSource ordersBindingSource;
        private DataGridView dataGridView3;
        private DataGridView dataGridView4;
        private BindingSource menuItemBindingSource;
        private DataGridViewTextBoxColumn roomIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn roomNumberDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isOccupiedDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn roomIdDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn roomDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn orderDateTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn menuItemIdDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    }
}
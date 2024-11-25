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
            buttonSave = new Button();
            dataGridView1 = new DataGridView();
            roomIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            roomNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isOccupiedDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            roomBindingSource = new BindingSource(components);
            dataGridView2 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            roomIdDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            roomDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            orderDateTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            orderDetailsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            orderDetailsSerializedDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ordersBindingSource = new BindingSource(components);
            dataGridView3 = new DataGridView();
            menuItemIdDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            menuItemBindingSource = new BindingSource(components);
            label1 = new Label();
            cmbCategories = new ComboBox();
            delete_string = new Button();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roomBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ordersBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)menuItemBindingSource).BeginInit();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 204);
            buttonSave.Location = new Point(715, 521);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(218, 70);
            buttonSave.TabIndex = 4;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { roomIdDataGridViewTextBoxColumn, roomNumberDataGridViewTextBoxColumn, isOccupiedDataGridViewCheckBoxColumn });
            dataGridView1.DataSource = roomBindingSource;
            dataGridView1.Location = new Point(12, 104);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(456, 146);
            dataGridView1.TabIndex = 6;
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
            // roomBindingSource
            // 
            roomBindingSource.DataSource = typeof(Room);
            // 
            // dataGridView2
            // 
            dataGridView2.Anchor = AnchorStyles.Top;
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, roomIdDataGridViewTextBoxColumn1, roomDataGridViewTextBoxColumn, orderDateTimeDataGridViewTextBoxColumn, orderDetailsDataGridViewTextBoxColumn, orderDetailsSerializedDataGridViewTextBoxColumn });
            dataGridView2.DataSource = ordersBindingSource;
            dataGridView2.Location = new Point(12, 447);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(456, 124);
            dataGridView2.TabIndex = 7;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // roomIdDataGridViewTextBoxColumn1
            // 
            roomIdDataGridViewTextBoxColumn1.DataPropertyName = "RoomId";
            roomIdDataGridViewTextBoxColumn1.HeaderText = "RoomId";
            roomIdDataGridViewTextBoxColumn1.Name = "roomIdDataGridViewTextBoxColumn1";
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
            // orderDetailsDataGridViewTextBoxColumn
            // 
            orderDetailsDataGridViewTextBoxColumn.DataPropertyName = "OrderDetails";
            orderDetailsDataGridViewTextBoxColumn.HeaderText = "OrderDetails";
            orderDetailsDataGridViewTextBoxColumn.Name = "orderDetailsDataGridViewTextBoxColumn";
            // 
            // orderDetailsSerializedDataGridViewTextBoxColumn
            // 
            orderDetailsSerializedDataGridViewTextBoxColumn.DataPropertyName = "OrderDetailsSerialized";
            orderDetailsSerializedDataGridViewTextBoxColumn.HeaderText = "OrderDetailsSerialized";
            orderDetailsSerializedDataGridViewTextBoxColumn.Name = "orderDetailsSerializedDataGridViewTextBoxColumn";
            // 
            // ordersBindingSource
            // 
            ordersBindingSource.DataMember = "Orders";
            ordersBindingSource.DataSource = roomBindingSource;
            // 
            // dataGridView3
            // 
            dataGridView3.Anchor = AnchorStyles.Top;
            dataGridView3.AutoGenerateColumns = false;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { menuItemIdDataGridViewTextBoxColumn1, nameDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, categoryDataGridViewTextBoxColumn });
            dataGridView3.DataSource = menuItemBindingSource;
            dataGridView3.Location = new Point(12, 278);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(456, 120);
            dataGridView3.TabIndex = 8;
            dataGridView3.CellContentClick += dataGridView3_CellContentClick;
            dataGridView3.DataError += dataGridView3_DataError;
            // 
            // menuItemIdDataGridViewTextBoxColumn1
            // 
            menuItemIdDataGridViewTextBoxColumn1.DataPropertyName = "MenuItemId";
            menuItemIdDataGridViewTextBoxColumn1.HeaderText = "MenuItemId";
            menuItemIdDataGridViewTextBoxColumn1.Name = "menuItemIdDataGridViewTextBoxColumn1";
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
            // categoryDataGridViewTextBoxColumn
            // 
            categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            // 
            // menuItemBindingSource
            // 
            menuItemBindingSource.DataSource = typeof(MenuItem);
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 204);
            label1.Location = new Point(270, 9);
            label1.Name = "label1";
            label1.Size = new Size(566, 37);
            label1.TabIndex = 9;
            label1.Text = "Меню для редактирования базы данных";
            // 
            // cmbCategories
            // 
            cmbCategories.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbCategories.FormattingEnabled = true;
            cmbCategories.Location = new Point(812, 211);
            cmbCategories.Name = "cmbCategories";
            cmbCategories.Size = new Size(121, 23);
            cmbCategories.TabIndex = 10;
            // 
            // delete_string
            // 
            delete_string.Anchor = AnchorStyles.Top;
            delete_string.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 204);
            delete_string.Location = new Point(565, 447);
            delete_string.Name = "delete_string";
            delete_string.Size = new Size(218, 67);
            delete_string.TabIndex = 11;
            delete_string.Text = "Удалить запись в таблице заказов";
            delete_string.UseVisualStyleBackColor = true;
            delete_string.Click += delete_string_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 204);
            button1.Location = new Point(565, 278);
            button1.Name = "button1";
            button1.Size = new Size(218, 67);
            button1.TabIndex = 12;
            button1.Text = "Удалить запись в таблице меню";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 204);
            button2.Location = new Point(565, 104);
            button2.Name = "button2";
            button2.Size = new Size(218, 67);
            button2.TabIndex = 13;
            button2.Text = "Удалить запись в таблице комнаты";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // debug1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(963, 603);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(delete_string);
            Controls.Add(cmbCategories);
            Controls.Add(label1);
            Controls.Add(dataGridView3);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(buttonSave);
            Name = "debug1";
            Text = "debug1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)roomBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)ordersBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)menuItemBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonSave;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private DataGridView dataGridView3;
        private Label label1;
        private ComboBox cmbCategories;
        private Button delete_string;
        private Button button1;
        private Button button2;
        private DataGridViewTextBoxColumn roomIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn roomNumberDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isOccupiedDataGridViewCheckBoxColumn;
        private BindingSource roomBindingSource;
        private DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn menuItemIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn menuItemDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn menuItemIdDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private BindingSource menuItemBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn roomIdDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn roomDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn orderDateTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn orderDetailsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn orderDetailsSerializedDataGridViewTextBoxColumn;
        private BindingSource ordersBindingSource;
    }
}
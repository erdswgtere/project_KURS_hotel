namespace xz {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            dgvRooms = new DataGridView();
            dgvOrders = new DataGridView();
            cmbMenuItems = new ComboBox();
            txtQuantity = new TextBox();
            btnAddOrder = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRooms).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            SuspendLayout();
            // 
            // dgvRooms
            // 
            dgvRooms.Location = new Point(453, 30);
            dgvRooms.Name = "dgvRooms";
            dgvRooms.Size = new Size(335, 150);
            dgvRooms.TabIndex = 0;
            dgvRooms.SelectionChanged += dgvRooms_SelectionChanged;
            // 
            // dgvOrders
            // 
            dgvOrders.Location = new Point(47, 30);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.Size = new Size(293, 150);
            dgvOrders.TabIndex = 1;
            // 
            // cmbMenuItems
            // 
            cmbMenuItems.Location = new Point(101, 225);
            cmbMenuItems.Name = "cmbMenuItems";
            cmbMenuItems.Size = new Size(121, 23);
            cmbMenuItems.TabIndex = 2;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(351, 264);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(148, 23);
            txtQuantity.TabIndex = 3;
            // 
            // btnAddOrder
            // 
            btnAddOrder.Location = new Point(563, 353);
            btnAddOrder.Name = "btnAddOrder";
            btnAddOrder.Size = new Size(153, 43);
            btnAddOrder.TabIndex = 4;
            btnAddOrder.Text = "add";
            btnAddOrder.Click += btnAddOrder_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvRooms);
            Controls.Add(dgvOrders);
            Controls.Add(cmbMenuItems);
            Controls.Add(txtQuantity);
            Controls.Add(btnAddOrder);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvRooms).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Button button1;
    }
}

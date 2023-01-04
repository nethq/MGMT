namespace MGMT.Forms.add_forms
{
    partial class add_medicine_orders
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_done = new System.Windows.Forms.Button();
            this.add_order = new System.Windows.Forms.Button();
            this.remove_order = new System.Windows.Forms.Button();
            this.data_grid_orders = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.metadata = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numud_price = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numud_quantity = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.date_expire = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.date_order = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_pick_medicine_id = new System.Windows.Forms.Button();
            this.medicine_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.faktura_id_box = new System.Windows.Forms.TextBox();
            this.pick_faktura = new System.Windows.Forms.Button();
            this.grp_faktura_id = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_orders)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numud_price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numud_quantity)).BeginInit();
            this.grp_faktura_id.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_done
            // 
            this.btn_done.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_done.Location = new System.Drawing.Point(672, 425);
            this.btn_done.Name = "btn_done";
            this.btn_done.Size = new System.Drawing.Size(75, 23);
            this.btn_done.TabIndex = 1;
            this.btn_done.Text = "Приключи";
            this.btn_done.UseVisualStyleBackColor = true;
            this.btn_done.Click += new System.EventHandler(this.btn_done_Click);
            // 
            // add_order
            // 
            this.add_order.Location = new System.Drawing.Point(6, 290);
            this.add_order.Name = "add_order";
            this.add_order.Size = new System.Drawing.Size(112, 39);
            this.add_order.TabIndex = 5;
            this.add_order.Text = "Добави артикул";
            this.add_order.UseVisualStyleBackColor = true;
            this.add_order.Click += new System.EventHandler(this.add_order_Click);
            // 
            // remove_order
            // 
            this.remove_order.Location = new System.Drawing.Point(124, 290);
            this.remove_order.Name = "remove_order";
            this.remove_order.Size = new System.Drawing.Size(102, 39);
            this.remove_order.TabIndex = 6;
            this.remove_order.Text = "Премахни артикул";
            this.remove_order.UseVisualStyleBackColor = true;
            this.remove_order.Click += new System.EventHandler(this.remove_order_Click);
            // 
            // data_grid_orders
            // 
            this.data_grid_orders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.data_grid_orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grid_orders.Location = new System.Drawing.Point(245, 2);
            this.data_grid_orders.Name = "data_grid_orders";
            this.data_grid_orders.Size = new System.Drawing.Size(506, 450);
            this.data_grid_orders.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.metadata);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.numud_price);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numud_quantity);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.date_expire);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.date_order);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_pick_medicine_id);
            this.groupBox1.Controls.Add(this.medicine_id);
            this.groupBox1.Controls.Add(this.remove_order);
            this.groupBox1.Controls.Add(this.add_order);
            this.groupBox1.Location = new System.Drawing.Point(7, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 335);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данни за артикул";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Доп. данни за артикул";
            // 
            // metadata
            // 
            this.metadata.Location = new System.Drawing.Point(43, 238);
            this.metadata.Multiline = true;
            this.metadata.Name = "metadata";
            this.metadata.Size = new System.Drawing.Size(156, 47);
            this.metadata.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Цена на единица :";
            // 
            // numud_price
            // 
            this.numud_price.DecimalPlaces = 2;
            this.numud_price.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numud_price.Location = new System.Drawing.Point(43, 200);
            this.numud_price.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numud_price.Name = "numud_price";
            this.numud_price.Size = new System.Drawing.Size(157, 20);
            this.numud_price.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Количество :";
            // 
            // numud_quantity
            // 
            this.numud_quantity.Location = new System.Drawing.Point(43, 160);
            this.numud_quantity.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numud_quantity.Name = "numud_quantity";
            this.numud_quantity.Size = new System.Drawing.Size(157, 20);
            this.numud_quantity.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Дата годен до: ";
            // 
            // date_expire
            // 
            this.date_expire.CustomFormat = "yyyy-MM-dd";
            this.date_expire.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_expire.Location = new System.Drawing.Point(44, 121);
            this.date_expire.Name = "date_expire";
            this.date_expire.Size = new System.Drawing.Size(156, 20);
            this.date_expire.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Дата доставка : ";
            // 
            // date_order
            // 
            this.date_order.CustomFormat = "yyyy-MM-dd";
            this.date_order.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_order.Location = new System.Drawing.Point(43, 76);
            this.date_order.Name = "date_order";
            this.date_order.Size = new System.Drawing.Size(156, 20);
            this.date_order.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Лекарство № ";
            // 
            // btn_pick_medicine_id
            // 
            this.btn_pick_medicine_id.Location = new System.Drawing.Point(124, 33);
            this.btn_pick_medicine_id.Name = "btn_pick_medicine_id";
            this.btn_pick_medicine_id.Size = new System.Drawing.Size(75, 23);
            this.btn_pick_medicine_id.TabIndex = 12;
            this.btn_pick_medicine_id.Text = "Избери фактура";
            this.btn_pick_medicine_id.UseVisualStyleBackColor = true;
            this.btn_pick_medicine_id.Click += new System.EventHandler(this.btn_pick_medicine_id_Click);
            // 
            // medicine_id
            // 
            this.medicine_id.Location = new System.Drawing.Point(43, 35);
            this.medicine_id.Name = "medicine_id";
            this.medicine_id.Size = new System.Drawing.Size(75, 20);
            this.medicine_id.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Номер фактура";
            // 
            // faktura_id_box
            // 
            this.faktura_id_box.Location = new System.Drawing.Point(93, 40);
            this.faktura_id_box.Name = "faktura_id_box";
            this.faktura_id_box.ReadOnly = true;
            this.faktura_id_box.Size = new System.Drawing.Size(56, 20);
            this.faktura_id_box.TabIndex = 10;
            // 
            // pick_faktura
            // 
            this.pick_faktura.Location = new System.Drawing.Point(83, 64);
            this.pick_faktura.Name = "pick_faktura";
            this.pick_faktura.Size = new System.Drawing.Size(75, 23);
            this.pick_faktura.TabIndex = 11;
            this.pick_faktura.Text = "Избери фактура";
            this.pick_faktura.UseVisualStyleBackColor = true;
            this.pick_faktura.Click += new System.EventHandler(this.pick_faktura_Click);
            // 
            // grp_faktura_id
            // 
            this.grp_faktura_id.Controls.Add(this.pick_faktura);
            this.grp_faktura_id.Controls.Add(this.label1);
            this.grp_faktura_id.Controls.Add(this.faktura_id_box);
            this.grp_faktura_id.Location = new System.Drawing.Point(7, 12);
            this.grp_faktura_id.Name = "grp_faktura_id";
            this.grp_faktura_id.Size = new System.Drawing.Size(232, 99);
            this.grp_faktura_id.TabIndex = 12;
            this.grp_faktura_id.TabStop = false;
            this.grp_faktura_id.Text = "Към фактура :";
            // 
            // add_medicine_orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(757, 456);
            this.Controls.Add(this.grp_faktura_id);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_done);
            this.Controls.Add(this.data_grid_orders);
            this.MaximumSize = new System.Drawing.Size(1130, 495);
            this.MinimumSize = new System.Drawing.Size(773, 495);
            this.Name = "add_medicine_orders";
            this.Text = "Добави лекарство";
            this.Load += new System.EventHandler(this.add_orders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_orders)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numud_price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numud_quantity)).EndInit();
            this.grp_faktura_id.ResumeLayout(false);
            this.grp_faktura_id.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_done;
        private System.Windows.Forms.Button add_order;
        private System.Windows.Forms.Button remove_order;
        private System.Windows.Forms.DataGridView data_grid_orders;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox faktura_id_box;
        private System.Windows.Forms.Button pick_faktura;
        private System.Windows.Forms.GroupBox grp_faktura_id;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox metadata;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numud_price;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numud_quantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker date_expire;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker date_order;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_pick_medicine_id;
        private System.Windows.Forms.TextBox medicine_id;
    }
}
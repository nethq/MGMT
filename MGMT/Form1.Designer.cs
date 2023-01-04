namespace MGMT
{
    partial class form_main
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
            this.grp_spravka = new System.Windows.Forms.GroupBox();
            this.search_box = new System.Windows.Forms.TextBox();
            this.cb_table_names = new System.Windows.Forms.ComboBox();
            this.btn_spravka = new System.Windows.Forms.Button();
            this.grp_database_login = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.port_box = new System.Windows.Forms.TextBox();
            this.btn_save_creds = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.password_box = new System.Windows.Forms.TextBox();
            this.username_box = new System.Windows.Forms.TextBox();
            this.database_box = new System.Windows.Forms.TextBox();
            this.server_box = new System.Windows.Forms.TextBox();
            this.grp_create = new System.Windows.Forms.GroupBox();
            this.add_orders_to_fakturi = new System.Windows.Forms.Button();
            this.btn_create_procedure = new System.Windows.Forms.Button();
            this.btn_create_operation = new System.Windows.Forms.Button();
            this.btn_create_type_animal = new System.Windows.Forms.Button();
            this.btn_create_status = new System.Windows.Forms.Button();
            this.btn_create_medicine = new System.Windows.Forms.Button();
            this.btn_create_faktura = new System.Windows.Forms.Button();
            this.btn_create_delivery_source = new System.Windows.Forms.Button();
            this.btn_create_animal = new System.Windows.Forms.Button();
            this.special_button_layout = new System.Windows.Forms.FlowLayoutPanel();
            this.grp_spravka.SuspendLayout();
            this.grp_database_login.SuspendLayout();
            this.grp_create.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_spravka
            // 
            this.grp_spravka.Controls.Add(this.search_box);
            this.grp_spravka.Controls.Add(this.cb_table_names);
            this.grp_spravka.Controls.Add(this.btn_spravka);
            this.grp_spravka.Location = new System.Drawing.Point(12, 12);
            this.grp_spravka.Name = "grp_spravka";
            this.grp_spravka.Size = new System.Drawing.Size(245, 78);
            this.grp_spravka.TabIndex = 0;
            this.grp_spravka.TabStop = false;
            this.grp_spravka.Text = "Справка";
            // 
            // search_box
            // 
            this.search_box.Location = new System.Drawing.Point(127, 23);
            this.search_box.Name = "search_box";
            this.search_box.Size = new System.Drawing.Size(107, 20);
            this.search_box.TabIndex = 12;
            // 
            // cb_table_names
            // 
            this.cb_table_names.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_table_names.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_table_names.FormattingEnabled = true;
            this.cb_table_names.Location = new System.Drawing.Point(10, 22);
            this.cb_table_names.Name = "cb_table_names";
            this.cb_table_names.Size = new System.Drawing.Size(108, 21);
            this.cb_table_names.Sorted = true;
            this.cb_table_names.TabIndex = 11;
            // 
            // btn_spravka
            // 
            this.btn_spravka.Location = new System.Drawing.Point(85, 49);
            this.btn_spravka.Name = "btn_spravka";
            this.btn_spravka.Size = new System.Drawing.Size(75, 23);
            this.btn_spravka.TabIndex = 1;
            this.btn_spravka.Text = "Търси";
            this.btn_spravka.UseVisualStyleBackColor = true;
            this.btn_spravka.Click += new System.EventHandler(this.btn_spravka_Click);
            // 
            // grp_database_login
            // 
            this.grp_database_login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grp_database_login.AutoSize = true;
            this.grp_database_login.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grp_database_login.Controls.Add(this.label5);
            this.grp_database_login.Controls.Add(this.port_box);
            this.grp_database_login.Controls.Add(this.btn_save_creds);
            this.grp_database_login.Controls.Add(this.btn_login);
            this.grp_database_login.Controls.Add(this.label4);
            this.grp_database_login.Controls.Add(this.label3);
            this.grp_database_login.Controls.Add(this.label2);
            this.grp_database_login.Controls.Add(this.label1);
            this.grp_database_login.Controls.Add(this.password_box);
            this.grp_database_login.Controls.Add(this.username_box);
            this.grp_database_login.Controls.Add(this.database_box);
            this.grp_database_login.Controls.Add(this.server_box);
            this.grp_database_login.Location = new System.Drawing.Point(12, 517);
            this.grp_database_login.Name = "grp_database_login";
            this.grp_database_login.Size = new System.Drawing.Size(194, 205);
            this.grp_database_login.TabIndex = 1;
            this.grp_database_login.TabStop = false;
            this.grp_database_login.Text = "Данни за базата";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(137, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Порт";
            // 
            // port_box
            // 
            this.port_box.Location = new System.Drawing.Point(116, 39);
            this.port_box.Name = "port_box";
            this.port_box.Size = new System.Drawing.Size(71, 20);
            this.port_box.TabIndex = 15;
            // 
            // btn_save_creds
            // 
            this.btn_save_creds.Location = new System.Drawing.Point(114, 163);
            this.btn_save_creds.Name = "btn_save_creds";
            this.btn_save_creds.Size = new System.Drawing.Size(74, 23);
            this.btn_save_creds.TabIndex = 14;
            this.btn_save_creds.Text = "Запази";
            this.btn_save_creds.UseVisualStyleBackColor = true;
            this.btn_save_creds.Click += new System.EventHandler(this.btn_save_creds_Click);
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(112, 122);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 13;
            this.btn_login.Text = "Вход";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Парола";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "База данни";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Име";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Сървър";
            // 
            // password_box
            // 
            this.password_box.Location = new System.Drawing.Point(10, 164);
            this.password_box.Name = "password_box";
            this.password_box.Size = new System.Drawing.Size(90, 20);
            this.password_box.TabIndex = 8;
            // 
            // username_box
            // 
            this.username_box.Location = new System.Drawing.Point(10, 123);
            this.username_box.Name = "username_box";
            this.username_box.Size = new System.Drawing.Size(90, 20);
            this.username_box.TabIndex = 7;
            // 
            // database_box
            // 
            this.database_box.Location = new System.Drawing.Point(9, 79);
            this.database_box.Name = "database_box";
            this.database_box.Size = new System.Drawing.Size(90, 20);
            this.database_box.TabIndex = 6;
            // 
            // server_box
            // 
            this.server_box.Location = new System.Drawing.Point(9, 39);
            this.server_box.Name = "server_box";
            this.server_box.Size = new System.Drawing.Size(90, 20);
            this.server_box.TabIndex = 5;
            // 
            // grp_create
            // 
            this.grp_create.AutoSize = true;
            this.grp_create.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grp_create.Controls.Add(this.add_orders_to_fakturi);
            this.grp_create.Controls.Add(this.btn_create_procedure);
            this.grp_create.Controls.Add(this.btn_create_operation);
            this.grp_create.Controls.Add(this.btn_create_type_animal);
            this.grp_create.Controls.Add(this.btn_create_status);
            this.grp_create.Controls.Add(this.btn_create_medicine);
            this.grp_create.Controls.Add(this.btn_create_faktura);
            this.grp_create.Controls.Add(this.btn_create_delivery_source);
            this.grp_create.Controls.Add(this.btn_create_animal);
            this.grp_create.Location = new System.Drawing.Point(12, 96);
            this.grp_create.Name = "grp_create";
            this.grp_create.Size = new System.Drawing.Size(106, 415);
            this.grp_create.TabIndex = 2;
            this.grp_create.TabStop = false;
            this.grp_create.Text = "Добави";
            // 
            // add_orders_to_fakturi
            // 
            this.add_orders_to_fakturi.Location = new System.Drawing.Point(4, 275);
            this.add_orders_to_fakturi.Name = "add_orders_to_fakturi";
            this.add_orders_to_fakturi.Size = new System.Drawing.Size(96, 40);
            this.add_orders_to_fakturi.TabIndex = 9;
            this.add_orders_to_fakturi.Text = "Артикули към фактура";
            this.add_orders_to_fakturi.UseVisualStyleBackColor = true;
            this.add_orders_to_fakturi.Click += new System.EventHandler(this.add_orders_to_fakturi_Click);
            // 
            // btn_create_procedure
            // 
            this.btn_create_procedure.Location = new System.Drawing.Point(4, 235);
            this.btn_create_procedure.Name = "btn_create_procedure";
            this.btn_create_procedure.Size = new System.Drawing.Size(96, 23);
            this.btn_create_procedure.TabIndex = 8;
            this.btn_create_procedure.Text = "Процедура";
            this.btn_create_procedure.UseVisualStyleBackColor = true;
            this.btn_create_procedure.Click += new System.EventHandler(this.btn_create_procedure_Click);
            // 
            // btn_create_operation
            // 
            this.btn_create_operation.Location = new System.Drawing.Point(4, 191);
            this.btn_create_operation.Name = "btn_create_operation";
            this.btn_create_operation.Size = new System.Drawing.Size(96, 23);
            this.btn_create_operation.TabIndex = 7;
            this.btn_create_operation.Text = "Операция";
            this.btn_create_operation.UseVisualStyleBackColor = true;
            this.btn_create_operation.Click += new System.EventHandler(this.btn_create_operation_Click);
            // 
            // btn_create_type_animal
            // 
            this.btn_create_type_animal.Location = new System.Drawing.Point(4, 373);
            this.btn_create_type_animal.Name = "btn_create_type_animal";
            this.btn_create_type_animal.Size = new System.Drawing.Size(96, 23);
            this.btn_create_type_animal.TabIndex = 1;
            this.btn_create_type_animal.Text = "Тип добитък";
            this.btn_create_type_animal.UseVisualStyleBackColor = true;
            this.btn_create_type_animal.Visible = false;
            // 
            // btn_create_status
            // 
            this.btn_create_status.Location = new System.Drawing.Point(4, 325);
            this.btn_create_status.Name = "btn_create_status";
            this.btn_create_status.Size = new System.Drawing.Size(96, 40);
            this.btn_create_status.TabIndex = 0;
            this.btn_create_status.Text = "Статус за добитък";
            this.btn_create_status.UseVisualStyleBackColor = true;
            this.btn_create_status.Visible = false;
            // 
            // btn_create_medicine
            // 
            this.btn_create_medicine.Location = new System.Drawing.Point(4, 147);
            this.btn_create_medicine.Name = "btn_create_medicine";
            this.btn_create_medicine.Size = new System.Drawing.Size(96, 23);
            this.btn_create_medicine.TabIndex = 6;
            this.btn_create_medicine.Text = "Лекарство";
            this.btn_create_medicine.UseVisualStyleBackColor = true;
            this.btn_create_medicine.Click += new System.EventHandler(this.btn_create_medicine_Click);
            // 
            // btn_create_faktura
            // 
            this.btn_create_faktura.Location = new System.Drawing.Point(4, 105);
            this.btn_create_faktura.Name = "btn_create_faktura";
            this.btn_create_faktura.Size = new System.Drawing.Size(96, 23);
            this.btn_create_faktura.TabIndex = 4;
            this.btn_create_faktura.Text = "Фактура";
            this.btn_create_faktura.UseVisualStyleBackColor = true;
            this.btn_create_faktura.Click += new System.EventHandler(this.btn_create_faktura_Click);
            // 
            // btn_create_delivery_source
            // 
            this.btn_create_delivery_source.Location = new System.Drawing.Point(4, 61);
            this.btn_create_delivery_source.Name = "btn_create_delivery_source";
            this.btn_create_delivery_source.Size = new System.Drawing.Size(96, 23);
            this.btn_create_delivery_source.TabIndex = 3;
            this.btn_create_delivery_source.Text = "Доставчик";
            this.btn_create_delivery_source.UseVisualStyleBackColor = true;
            this.btn_create_delivery_source.Click += new System.EventHandler(this.btn_create_delivery_source_Click);
            // 
            // btn_create_animal
            // 
            this.btn_create_animal.Location = new System.Drawing.Point(4, 17);
            this.btn_create_animal.Name = "btn_create_animal";
            this.btn_create_animal.Size = new System.Drawing.Size(96, 23);
            this.btn_create_animal.TabIndex = 2;
            this.btn_create_animal.Text = "Добитък";
            this.btn_create_animal.UseVisualStyleBackColor = true;
            this.btn_create_animal.Click += new System.EventHandler(this.btn_create_animal_Click);
            // 
            // special_button_layout
            // 
            this.special_button_layout.AutoSize = true;
            this.special_button_layout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.special_button_layout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.special_button_layout.Location = new System.Drawing.Point(133, 97);
            this.special_button_layout.Name = "special_button_layout";
            this.special_button_layout.Size = new System.Drawing.Size(0, 0);
            this.special_button_layout.TabIndex = 11;
            // 
            // form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(568, 741);
            this.Controls.Add(this.special_button_layout);
            this.Controls.Add(this.grp_create);
            this.Controls.Add(this.grp_database_login);
            this.Controls.Add(this.grp_spravka);
            this.Name = "form_main";
            this.Text = "MGMT";
            this.Load += new System.EventHandler(this.form_main_Load);
            this.grp_spravka.ResumeLayout(false);
            this.grp_spravka.PerformLayout();
            this.grp_database_login.ResumeLayout(false);
            this.grp_database_login.PerformLayout();
            this.grp_create.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_spravka;
        private System.Windows.Forms.Button btn_spravka;
        private System.Windows.Forms.GroupBox grp_database_login;
        private System.Windows.Forms.Button btn_save_creds;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox password_box;
        private System.Windows.Forms.TextBox username_box;
        private System.Windows.Forms.TextBox database_box;
        private System.Windows.Forms.TextBox server_box;
        private System.Windows.Forms.GroupBox grp_create;
        private System.Windows.Forms.Button btn_create_procedure;
        private System.Windows.Forms.Button btn_create_operation;
        private System.Windows.Forms.Button btn_create_medicine;
        private System.Windows.Forms.Button btn_create_faktura;
        private System.Windows.Forms.Button btn_create_delivery_source;
        private System.Windows.Forms.Button btn_create_animal;
        private System.Windows.Forms.ComboBox cb_table_names;
        private System.Windows.Forms.Button add_orders_to_fakturi;
        private System.Windows.Forms.Button btn_create_type_animal;
        private System.Windows.Forms.Button btn_create_status;
        private System.Windows.Forms.TextBox search_box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox port_box;
        private System.Windows.Forms.FlowLayoutPanel special_button_layout;
    }
}


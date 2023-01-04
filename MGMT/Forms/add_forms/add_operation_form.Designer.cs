namespace MGMT.Forms.add_forms
{
    partial class add_operation_form
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
            this.animal_id_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pick_animal = new System.Windows.Forms.Button();
            this.pick_procedure = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.procedure_id_box = new System.Windows.Forms.TextBox();
            this.pick_order = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.source_order_id_box = new System.Windows.Forms.TextBox();
            this.complete_operation = new System.Windows.Forms.Button();
            this.data_grid = new System.Windows.Forms.DataGridView();
            this.date_time_picker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // animal_id_box
            // 
            this.animal_id_box.Enabled = false;
            this.animal_id_box.Location = new System.Drawing.Point(25, 58);
            this.animal_id_box.Name = "animal_id_box";
            this.animal_id_box.Size = new System.Drawing.Size(70, 20);
            this.animal_id_box.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Животно";
            // 
            // pick_animal
            // 
            this.pick_animal.Location = new System.Drawing.Point(101, 58);
            this.pick_animal.Name = "pick_animal";
            this.pick_animal.Size = new System.Drawing.Size(75, 20);
            this.pick_animal.TabIndex = 2;
            this.pick_animal.Text = "Избери";
            this.pick_animal.UseVisualStyleBackColor = true;
            this.pick_animal.Click += new System.EventHandler(this.pick_animal_Click);
            // 
            // pick_procedure
            // 
            this.pick_procedure.Location = new System.Drawing.Point(101, 110);
            this.pick_procedure.Name = "pick_procedure";
            this.pick_procedure.Size = new System.Drawing.Size(75, 20);
            this.pick_procedure.TabIndex = 5;
            this.pick_procedure.Text = "Избери";
            this.pick_procedure.UseVisualStyleBackColor = true;
            this.pick_procedure.Click += new System.EventHandler(this.pick_procedure_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Вид процедура";
            // 
            // procedure_id_box
            // 
            this.procedure_id_box.Enabled = false;
            this.procedure_id_box.Location = new System.Drawing.Point(25, 110);
            this.procedure_id_box.Name = "procedure_id_box";
            this.procedure_id_box.Size = new System.Drawing.Size(70, 20);
            this.procedure_id_box.TabIndex = 3;
            // 
            // pick_order
            // 
            this.pick_order.Location = new System.Drawing.Point(101, 161);
            this.pick_order.Name = "pick_order";
            this.pick_order.Size = new System.Drawing.Size(75, 20);
            this.pick_order.TabIndex = 8;
            this.pick_order.Text = "Избери";
            this.pick_order.UseVisualStyleBackColor = true;
            this.pick_order.Click += new System.EventHandler(this.pick_order_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Фактура на изпълнение";
            // 
            // source_order_id_box
            // 
            this.source_order_id_box.Enabled = false;
            this.source_order_id_box.Location = new System.Drawing.Point(25, 161);
            this.source_order_id_box.Name = "source_order_id_box";
            this.source_order_id_box.Size = new System.Drawing.Size(70, 20);
            this.source_order_id_box.TabIndex = 6;
            // 
            // complete_operation
            // 
            this.complete_operation.Location = new System.Drawing.Point(61, 192);
            this.complete_operation.Name = "complete_operation";
            this.complete_operation.Size = new System.Drawing.Size(75, 23);
            this.complete_operation.TabIndex = 9;
            this.complete_operation.Text = "Създай";
            this.complete_operation.UseVisualStyleBackColor = true;
            this.complete_operation.Click += new System.EventHandler(this.complete_operation_Click);
            // 
            // data_grid
            // 
            this.data_grid.AllowUserToAddRows = false;
            this.data_grid.AllowUserToDeleteRows = false;
            this.data_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grid.Location = new System.Drawing.Point(206, 1);
            this.data_grid.Name = "data_grid";
            this.data_grid.ReadOnly = true;
            this.data_grid.Size = new System.Drawing.Size(872, 214);
            this.data_grid.TabIndex = 10;
            this.data_grid.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.data_grid_RowsAdded);
            // 
            // date_time_picker
            // 
            this.date_time_picker.CustomFormat = "yyyy-MM-dd";
            this.date_time_picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_time_picker.Location = new System.Drawing.Point(25, 14);
            this.date_time_picker.Name = "date_time_picker";
            this.date_time_picker.Size = new System.Drawing.Size(151, 20);
            this.date_time_picker.TabIndex = 11;
            this.date_time_picker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // add_operation_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(199, 217);
            this.Controls.Add(this.date_time_picker);
            this.Controls.Add(this.data_grid);
            this.Controls.Add(this.complete_operation);
            this.Controls.Add(this.pick_order);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.source_order_id_box);
            this.Controls.Add(this.pick_procedure);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.procedure_id_box);
            this.Controls.Add(this.pick_animal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.animal_id_box);
            this.MaximumSize = new System.Drawing.Size(1095, 256);
            this.MinimumSize = new System.Drawing.Size(215, 256);
            this.Name = "add_operation_form";
            this.Text = "Добави операция";
            this.Load += new System.EventHandler(this.add_operation_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox animal_id_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button pick_animal;
        private System.Windows.Forms.Button pick_procedure;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox procedure_id_box;
        private System.Windows.Forms.Button pick_order;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox source_order_id_box;
        private System.Windows.Forms.Button complete_operation;
        private System.Windows.Forms.DataGridView data_grid;
        private System.Windows.Forms.DateTimePicker date_time_picker;
    }
}
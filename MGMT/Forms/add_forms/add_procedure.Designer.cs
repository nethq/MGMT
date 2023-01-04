namespace MGMT.Forms.add_forms
{
    partial class add_procedure
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
            this.name_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.medicine_id_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_pick_medicine = new System.Windows.Forms.Button();
            this.medicine_quantity = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_add_procedure = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.medicine_quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // name_box
            // 
            this.name_box.Location = new System.Drawing.Point(26, 30);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(195, 20);
            this.name_box.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Име";
            // 
            // medicine_id_box
            // 
            this.medicine_id_box.Enabled = false;
            this.medicine_id_box.Location = new System.Drawing.Point(26, 73);
            this.medicine_id_box.Name = "medicine_id_box";
            this.medicine_id_box.Size = new System.Drawing.Size(85, 20);
            this.medicine_id_box.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Номер лекарство";
            // 
            // btn_pick_medicine
            // 
            this.btn_pick_medicine.Location = new System.Drawing.Point(130, 73);
            this.btn_pick_medicine.Name = "btn_pick_medicine";
            this.btn_pick_medicine.Size = new System.Drawing.Size(91, 20);
            this.btn_pick_medicine.TabIndex = 4;
            this.btn_pick_medicine.Text = "Избери";
            this.btn_pick_medicine.UseVisualStyleBackColor = true;
            this.btn_pick_medicine.Click += new System.EventHandler(this.btn_pick_medicine_Click);
            // 
            // medicine_quantity
            // 
            this.medicine_quantity.Location = new System.Drawing.Point(26, 117);
            this.medicine_quantity.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.medicine_quantity.Name = "medicine_quantity";
            this.medicine_quantity.Size = new System.Drawing.Size(195, 20);
            this.medicine_quantity.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Количество";
            // 
            // btn_add_procedure
            // 
            this.btn_add_procedure.Location = new System.Drawing.Point(26, 154);
            this.btn_add_procedure.Name = "btn_add_procedure";
            this.btn_add_procedure.Size = new System.Drawing.Size(195, 23);
            this.btn_add_procedure.TabIndex = 7;
            this.btn_add_procedure.Text = "Създай процедура";
            this.btn_add_procedure.UseVisualStyleBackColor = true;
            this.btn_add_procedure.Click += new System.EventHandler(this.btn_add_procedure_Click);
            // 
            // add_procedure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(247, 188);
            this.Controls.Add(this.btn_add_procedure);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.medicine_quantity);
            this.Controls.Add(this.btn_pick_medicine);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.medicine_id_box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name_box);
            this.MaximumSize = new System.Drawing.Size(263, 227);
            this.MinimumSize = new System.Drawing.Size(263, 227);
            this.Name = "add_procedure";
            this.Text = "Добави процедура";
            ((System.ComponentModel.ISupportInitialize)(this.medicine_quantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox medicine_id_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_pick_medicine;
        private System.Windows.Forms.NumericUpDown medicine_quantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_add_procedure;
    }
}
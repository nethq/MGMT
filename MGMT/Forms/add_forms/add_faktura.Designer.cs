namespace MGMT.Forms.add_forms
{
    partial class add_faktura
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
            this.metadata_box = new System.Windows.Forms.TextBox();
            this.btn_proceed = new System.Windows.Forms.Button();
            this.pick_dostavchik = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dostavchik_id_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.date_time = new System.Windows.Forms.DateTimePicker();
            this.txt_faktura_ref_num = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // metadata_box
            // 
            this.metadata_box.Location = new System.Drawing.Point(25, 148);
            this.metadata_box.MaxLength = 255;
            this.metadata_box.Multiline = true;
            this.metadata_box.Name = "metadata_box";
            this.metadata_box.Size = new System.Drawing.Size(184, 84);
            this.metadata_box.TabIndex = 42;
            // 
            // btn_proceed
            // 
            this.btn_proceed.Location = new System.Drawing.Point(25, 247);
            this.btn_proceed.Name = "btn_proceed";
            this.btn_proceed.Size = new System.Drawing.Size(184, 25);
            this.btn_proceed.TabIndex = 41;
            this.btn_proceed.Text = "Продължи";
            this.btn_proceed.UseVisualStyleBackColor = true;
            this.btn_proceed.Click += new System.EventHandler(this.btn_proceed_Click);
            // 
            // pick_dostavchik
            // 
            this.pick_dostavchik.Location = new System.Drawing.Point(89, 112);
            this.pick_dostavchik.Name = "pick_dostavchik";
            this.pick_dostavchik.Size = new System.Drawing.Size(121, 20);
            this.pick_dostavchik.TabIndex = 38;
            this.pick_dostavchik.Text = "Избери доставчик";
            this.pick_dostavchik.UseVisualStyleBackColor = true;
            this.pick_dostavchik.Click += new System.EventHandler(this.pick_dostavchik_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Номер доставчик";
            // 
            // dostavchik_id_box
            // 
            this.dostavchik_id_box.Enabled = false;
            this.dostavchik_id_box.Location = new System.Drawing.Point(25, 112);
            this.dostavchik_id_box.Name = "dostavchik_id_box";
            this.dostavchik_id_box.Size = new System.Drawing.Size(52, 20);
            this.dostavchik_id_box.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Дата";
            // 
            // date_time
            // 
            this.date_time.CustomFormat = "yyyy-MM-dd";
            this.date_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_time.Location = new System.Drawing.Point(25, 69);
            this.date_time.Name = "date_time";
            this.date_time.Size = new System.Drawing.Size(184, 20);
            this.date_time.TabIndex = 34;
            // 
            // txt_faktura_ref_num
            // 
            this.txt_faktura_ref_num.Location = new System.Drawing.Point(25, 29);
            this.txt_faktura_ref_num.Name = "txt_faktura_ref_num";
            this.txt_faktura_ref_num.Size = new System.Drawing.Size(184, 20);
            this.txt_faktura_ref_num.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Реф. Номер";
            // 
            // add_faktura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(234, 277);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_faktura_ref_num);
            this.Controls.Add(this.metadata_box);
            this.Controls.Add(this.btn_proceed);
            this.Controls.Add(this.pick_dostavchik);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dostavchik_id_box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.date_time);
            this.MinimumSize = new System.Drawing.Size(250, 280);
            this.Name = "add_faktura";
            this.Text = "Добави фактура";
            this.Load += new System.EventHandler(this.add_faktura_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox metadata_box;
        private System.Windows.Forms.Button btn_proceed;
        private System.Windows.Forms.Button pick_dostavchik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dostavchik_id_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker date_time;
        private System.Windows.Forms.TextBox txt_faktura_ref_num;
        private System.Windows.Forms.Label label3;
    }
}
namespace MGMT.Forms.add_forms
{
    partial class add_animal
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
            this.btn_submit = new System.Windows.Forms.Button();
            this.metadata_box = new System.Windows.Forms.TextBox();
            this.ref_num_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.type_box = new System.Windows.Forms.TextBox();
            this.status_box = new System.Windows.Forms.TextBox();
            this.btn_pick_type = new System.Windows.Forms.Button();
            this.btn_pick_status = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(72, 210);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 1;
            this.btn_submit.Text = "Създай";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // metadata_box
            // 
            this.metadata_box.Location = new System.Drawing.Point(26, 146);
            this.metadata_box.Multiline = true;
            this.metadata_box.Name = "metadata_box";
            this.metadata_box.Size = new System.Drawing.Size(170, 54);
            this.metadata_box.TabIndex = 3;
            // 
            // ref_num_box
            // 
            this.ref_num_box.Location = new System.Drawing.Point(26, 25);
            this.ref_num_box.Name = "ref_num_box";
            this.ref_num_box.Size = new System.Drawing.Size(170, 20);
            this.ref_num_box.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Реф. номер";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Тип";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Статус";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Допълнителни данни";
            // 
            // type_box
            // 
            this.type_box.Enabled = false;
            this.type_box.Location = new System.Drawing.Point(26, 64);
            this.type_box.Name = "type_box";
            this.type_box.Size = new System.Drawing.Size(92, 20);
            this.type_box.TabIndex = 9;
            // 
            // status_box
            // 
            this.status_box.Enabled = false;
            this.status_box.Location = new System.Drawing.Point(26, 104);
            this.status_box.Name = "status_box";
            this.status_box.Size = new System.Drawing.Size(92, 20);
            this.status_box.TabIndex = 10;
            // 
            // btn_pick_type
            // 
            this.btn_pick_type.Location = new System.Drawing.Point(124, 63);
            this.btn_pick_type.Name = "btn_pick_type";
            this.btn_pick_type.Size = new System.Drawing.Size(75, 21);
            this.btn_pick_type.TabIndex = 11;
            this.btn_pick_type.Text = "Избери";
            this.btn_pick_type.UseVisualStyleBackColor = true;
            this.btn_pick_type.Click += new System.EventHandler(this.btn_pick_type_Click);
            // 
            // btn_pick_status
            // 
            this.btn_pick_status.Location = new System.Drawing.Point(124, 104);
            this.btn_pick_status.Name = "btn_pick_status";
            this.btn_pick_status.Size = new System.Drawing.Size(75, 21);
            this.btn_pick_status.TabIndex = 12;
            this.btn_pick_status.Text = "Избери";
            this.btn_pick_status.UseVisualStyleBackColor = true;
            this.btn_pick_status.Click += new System.EventHandler(this.btn_pick_status_Click);
            // 
            // add_animal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(229, 241);
            this.Controls.Add(this.btn_pick_status);
            this.Controls.Add(this.btn_pick_type);
            this.Controls.Add(this.status_box);
            this.Controls.Add(this.type_box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ref_num_box);
            this.Controls.Add(this.metadata_box);
            this.Controls.Add(this.btn_submit);
            this.MaximumSize = new System.Drawing.Size(245, 280);
            this.MinimumSize = new System.Drawing.Size(245, 280);
            this.Name = "add_animal";
            this.Text = "Създай добитък";
            this.Load += new System.EventHandler(this.add_animal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.TextBox metadata_box;
        private System.Windows.Forms.TextBox ref_num_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox type_box;
        private System.Windows.Forms.TextBox status_box;
        private System.Windows.Forms.Button btn_pick_type;
        private System.Windows.Forms.Button btn_pick_status;
    }
}
namespace MGMT.Forms.add_forms
{
    partial class add_medicine
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
            this.btn_create = new System.Windows.Forms.Button();
            this.name_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(53, 64);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(130, 23);
            this.btn_create.TabIndex = 0;
            this.btn_create.Text = "Добави";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // name_box
            // 
            this.name_box.Location = new System.Drawing.Point(39, 29);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(155, 20);
            this.name_box.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Име";
            // 
            // add_medicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(234, 99);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name_box);
            this.Controls.Add(this.btn_create);
            this.MaximumSize = new System.Drawing.Size(250, 138);
            this.MinimumSize = new System.Drawing.Size(250, 138);
            this.Name = "add_medicine";
            this.Text = "Добави лекарство";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.Label label1;
    }
}
namespace MGMT.Forms.input_forms
{
    partial class input_form
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
            this.txt_string_input = new System.Windows.Forms.TextBox();
            this.date_time_picker = new System.Windows.Forms.DateTimePicker();
            this.num_up_down_int = new System.Windows.Forms.NumericUpDown();
            this.btn_done = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_up_down_int)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_string_input
            // 
            this.txt_string_input.Location = new System.Drawing.Point(62, 28);
            this.txt_string_input.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_string_input.Name = "txt_string_input";
            this.txt_string_input.Size = new System.Drawing.Size(148, 26);
            this.txt_string_input.TabIndex = 0;
            this.txt_string_input.Visible = false;
            // 
            // date_time_picker
            // 
            this.date_time_picker.CustomFormat = "yyyy-MM-dd";
            this.date_time_picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_time_picker.Location = new System.Drawing.Point(62, 28);
            this.date_time_picker.Name = "date_time_picker";
            this.date_time_picker.Size = new System.Drawing.Size(148, 26);
            this.date_time_picker.TabIndex = 1;
            this.date_time_picker.Visible = false;
            // 
            // num_up_down_int
            // 
            this.num_up_down_int.Location = new System.Drawing.Point(62, 28);
            this.num_up_down_int.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.num_up_down_int.Name = "num_up_down_int";
            this.num_up_down_int.Size = new System.Drawing.Size(148, 26);
            this.num_up_down_int.TabIndex = 2;
            this.num_up_down_int.Visible = false;
            // 
            // btn_done
            // 
            this.btn_done.Location = new System.Drawing.Point(94, 75);
            this.btn_done.Name = "btn_done";
            this.btn_done.Size = new System.Drawing.Size(78, 29);
            this.btn_done.TabIndex = 3;
            this.btn_done.Text = "Въведи";
            this.btn_done.UseVisualStyleBackColor = true;
            this.btn_done.Click += new System.EventHandler(this.btn_done_Click);
            // 
            // input_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(272, 116);
            this.Controls.Add(this.btn_done);
            this.Controls.Add(this.num_up_down_int);
            this.Controls.Add(this.date_time_picker);
            this.Controls.Add(this.txt_string_input);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "input_form";
            this.Text = "Въведи.";
            this.Load += new System.EventHandler(this.input_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_up_down_int)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_string_input;
        private System.Windows.Forms.DateTimePicker date_time_picker;
        private System.Windows.Forms.NumericUpDown num_up_down_int;
        private System.Windows.Forms.Button btn_done;
    }
}
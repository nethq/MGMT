namespace MGMT.Forms
{
    partial class data_grid_select
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
            this.data_grid = new System.Windows.Forms.DataGridView();
            this.btn_select = new System.Windows.Forms.Button();
            this.search_box = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // data_grid
            // 
            this.data_grid.AllowUserToAddRows = false;
            this.data_grid.AllowUserToDeleteRows = false;
            this.data_grid.BackgroundColor = System.Drawing.Color.Teal;
            this.data_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_grid.Location = new System.Drawing.Point(0, 0);
            this.data_grid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.data_grid.MultiSelect = false;
            this.data_grid.Name = "data_grid";
            this.data_grid.ReadOnly = true;
            this.data_grid.Size = new System.Drawing.Size(658, 343);
            this.data_grid.TabIndex = 0;
            this.data_grid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.data_grid_KeyDown);
            // 
            // btn_select
            // 
            this.btn_select.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_select.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn_select.Location = new System.Drawing.Point(282, 295);
            this.btn_select.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(99, 37);
            this.btn_select.TabIndex = 1;
            this.btn_select.Text = "Избери";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // search_box
            // 
            this.search_box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.search_box.Location = new System.Drawing.Point(492, 301);
            this.search_box.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.search_box.Name = "search_box";
            this.search_box.Size = new System.Drawing.Size(148, 26);
            this.search_box.TabIndex = 2;
            this.search_box.TextChanged += new System.EventHandler(this.search_box_TextChanged);
            // 
            // data_grid_select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(658, 343);
            this.Controls.Add(this.search_box);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.data_grid);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "data_grid_select";
            this.Load += new System.EventHandler(this.data_grid_select_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_grid;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.TextBox search_box;
    }
}
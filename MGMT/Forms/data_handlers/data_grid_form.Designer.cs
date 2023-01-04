namespace MGMT
{
    partial class data_grid_form
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
            this.components = new System.ComponentModel.Container();
            this.data_grid = new System.Windows.Forms.DataGridView();
            this.data_grid_context_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cntxtmenu_export = new System.Windows.Forms.ToolStripMenuItem();
            this.search_box = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid)).BeginInit();
            this.data_grid_context_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // data_grid
            // 
            this.data_grid.AllowUserToAddRows = false;
            this.data_grid.AllowUserToDeleteRows = false;
            this.data_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.data_grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.data_grid.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.data_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_grid.Location = new System.Drawing.Point(0, 0);
            this.data_grid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.data_grid.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.data_grid.Name = "data_grid";
            this.data_grid.ReadOnly = true;
            this.data_grid.Size = new System.Drawing.Size(697, 190);
            this.data_grid.TabIndex = 0;
            this.data_grid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.data_grid_KeyDown);
            // 
            // data_grid_context_menu
            // 
            this.data_grid_context_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cntxtmenu_export});
            this.data_grid_context_menu.Name = "contextMenuStrip1";
            this.data_grid_context_menu.Size = new System.Drawing.Size(194, 26);
            // 
            // cntxtmenu_export
            // 
            this.cntxtmenu_export.Name = "cntxtmenu_export";
            this.cntxtmenu_export.Size = new System.Drawing.Size(193, 22);
            this.cntxtmenu_export.Text = "Експортирай таблица";
            this.cntxtmenu_export.Click += new System.EventHandler(this.cntxtmenu_export_Click);
            // 
            // search_box
            // 
            this.search_box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.search_box.Location = new System.Drawing.Point(538, 149);
            this.search_box.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.search_box.Name = "search_box";
            this.search_box.Size = new System.Drawing.Size(148, 26);
            this.search_box.TabIndex = 1;
            this.search_box.TextChanged += new System.EventHandler(this.search_box_TextChanged);
            // 
            // data_grid_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(697, 190);
            this.Controls.Add(this.search_box);
            this.Controls.Add(this.data_grid);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "data_grid_form";
            this.Text = "Заявка";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.data_grid_form_FormClosing);
            this.Load += new System.EventHandler(this.data_grid_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_grid)).EndInit();
            this.data_grid_context_menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip data_grid_context_menu;
        private System.Windows.Forms.ToolStripMenuItem cntxtmenu_export;
        private System.Windows.Forms.TextBox search_box;
        public System.Windows.Forms.DataGridView data_grid;
    }
}
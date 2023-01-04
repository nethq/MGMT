using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Navigation;

namespace MGMT.Forms
{
    public partial class data_grid_select : Form
    {
        DataTable dt_source;
        string return_string = null;
        public data_grid_select(DataTable dt, string title)
        {
            InitializeComponent();
            this.Text = title;
            data_grid.DataSource = dt;
            dt_source = dt;
        }
        private void data_grid_select_Load(object sender, EventArgs e)
        {
            data_grid.AutoSize = true;
            data_grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            if (dt_source.Rows.Count == 0)
            {
                btn_select.Enabled = false;
            }
            if (dt_source.Rows.Count > 0)
            {
                data_grid.Rows[0].Selected = true;
            }
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            //make the data_grid select only whole rows
            //get the selected row
            if (data_grid.SelectedRows.Count > 0)
            {
                return_string = data_grid.SelectedRows[0].Cells[0].Value.ToString();
                this.Close();
            }
            else
            {
                MessageBox.Show("Моля изберете ред.");
            }
        }
        public string GetReturnString()
        {
            if (return_string != null) { return return_string; }
            else return null;
        }
        
        private void search_box_TextChanged(object sender, EventArgs e)
        {
            if (search_box.Text == "") data_grid.DataSource = dt_source;
            else
            {
                var dt = dt_source.Clone();
                foreach (DataRow row in dt_source.Rows)
                {
                    if (row.ItemArray.Any(x => x.ToString().ToLower().Contains(search_box.Text.ToLower())))
                    {
                        dt.ImportRow(row);
                    }
                }
                data_grid.DataSource = dt;
            }
        }

        private void data_grid_KeyDown(object sender, KeyEventArgs e)
        {
            //check if enter has been pressed
            if (e.KeyCode == Keys.F && e.Control)
            {
                search_box.Focus();
            }
            if (e.KeyCode == Keys.F5)
            {
                data_grid.DataSource = dt_source;
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.Enter)
            {
                btn_select.PerformClick();
            }
        }
    }
}

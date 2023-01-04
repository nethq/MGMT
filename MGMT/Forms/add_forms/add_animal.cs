using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MGMT.Forms.add_forms
{
    public partial class add_animal : Form
    {
        private credentials creds;
        public add_animal(credentials creds)
        {
            InitializeComponent();
            this.creds = creds;
        }

        private void add_animal_Load(object sender, EventArgs e)
        {

        }

        private void btn_pick_type_Click(object sender, EventArgs e)
        {
            string query = "Select * from animal_types";
            data_grid_select selector = new data_grid_select(creds.QueryTranslateHeaders(query), "Изберете тип");
            selector.ShowDialog();
            type_box.Text = selector.GetReturnString();
        }

        private void btn_pick_status_Click(object sender, EventArgs e)
        {
            string query = "Select * from animal_status";
            data_grid_select selector = new data_grid_select(creds.QueryTranslateHeaders(query), "Изберете статус");
            selector.ShowDialog();
            status_box.Text = selector.GetReturnString();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (ref_num_box.Text != "" && type_box.Text != "" && status_box.Text != "")
            {
                string query = "INSERT INTO animals (ref_num, type_id, status_id) VALUES ('" + ref_num_box.Text + "', '" + type_box.Text + "', '" + status_box.Text + "')";
                if (creds.AtomicMultiQuery(new string[] { query }))
                {
                    MessageBox.Show("Успешно добавихте животно!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Възникна проблем при добавянето на животно!");
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Моля попълнете всички полета.");
            }
        }
    }
}

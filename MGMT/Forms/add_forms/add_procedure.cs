using Org.BouncyCastle.Tls.Crypto.Impl.BC;
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
    public partial class add_procedure : Form
    {
        credentials global_creds;
        public add_procedure(credentials creds)
        {
            InitializeComponent();
            global_creds = creds;
        }

        private void btn_add_procedure_Click(object sender, EventArgs e)
        {
            //if all input fields are filled, and no errors are thrown, add the procedure to the database
            if (name_box.Text != "" && medicine_id_box.Text != "" && medicine_quantity.Value > 0)
            {
                try
                {
                    string query = $"INSERT INTO procedures (name, medicine_id, medicine_quantity) VALUES ('{name_box.Text}', {medicine_id_box.Text}, {medicine_quantity.Value})";
                    global_creds.Query(query);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Възникна грешка при добавянето на процедурата в базата данни! " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Моля, попълнете всички полета!");
            }
            
        }

        private void btn_pick_medicine_Click(object sender, EventArgs e)
        {
            data_grid_select medicine_ids = new data_grid_select(global_creds.Query($"select * from medicines"),"Избери лекарство за процедурата");
            medicine_ids.ShowDialog();
            if (medicine_ids.GetReturnString() == null) return;
            medicine_id_box.Text = medicine_ids.GetReturnString();
        }
    }
}

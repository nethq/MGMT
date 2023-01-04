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
    public partial class add_faktura : Form
    {
        private credentials creds;
        public add_faktura(credentials creds)
        {
            InitializeComponent();
            this.creds = creds;
        }

        private void add_faktura_Load(object sender, EventArgs e)
        {
        }
        private void btn_proceed_Click(object sender, EventArgs e)
        {
            if (dostavchik_id_box.Text == "")
            {
                MessageBox.Show("Не сте избрали доставчик!");
                return;
            }
            if (txt_faktura_ref_num.Text == "")
            {
                MessageBox.Show("Моля въведете номер на фактурата!");
                return;
            }
            //check if such a name exists

            string insert_query = $"INSERT INTO fakturi (ref_num,date,delivery_agent_id,metadata) VALUES ('{txt_faktura_ref_num.Text}','{date_time.Value.ToString("yyyy-MM-dd")}',{dostavchik_id_box.Text},'{metadata_box.Text}')";
            if (creds.AtomicMultiQuery(new string[] { insert_query})) {
                add_medicine_orders x = new add_medicine_orders(creds, creds.Query($"SELECT id FROM fakturi WHERE ref_num='{txt_faktura_ref_num.Text}'").Rows[0][0].ToString());
                x.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Възникна проблем при добавянето на фактурата!");
            }

        }

        private void pick_dostavchik_Click_1(object sender, EventArgs e)
        {
            data_grid_select x = new data_grid_select(creds.QueryTranslateHeaders($"SELECT * FROM delivery_agent"), "Избери доставчик");
            x.ShowDialog();
            dostavchik_id_box.Text = x.GetReturnString();
        }
    }
}

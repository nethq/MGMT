using Org.BouncyCastle.Asn1.Cms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace MGMT.Forms.add_forms
{
    public partial class add_medicine_orders : Form
    {
        private credentials creds;
        private DataTable global_table;
        public add_medicine_orders(credentials creds, string faktura_id)
        {
            InitializeComponent();
            this.creds = creds;
            global_table = new DataTable();
            CheckPushState = false;
            grp_faktura_id.Enabled = false;
            faktura_id_box.Text = faktura_id;
        }
        public add_medicine_orders(credentials creds)
        {
            InitializeComponent();
            this.creds = creds;
            global_table = new DataTable();
            CheckPushState = false;
        }
        public bool CheckPushState { get; set; }

        private void add_orders_Load(object sender, EventArgs e)
        {
            data_grid_orders.AutoSize = true;
            data_grid_orders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            data_grid_orders.ReadOnly = true;
            data_grid_orders.AllowUserToDeleteRows = false;
            data_grid_orders.AllowUserToAddRows = false;
            data_grid_orders.AllowUserToDeleteRows = false;
            data_grid_orders.AllowUserToOrderColumns = false;
            data_grid_orders.AllowUserToResizeColumns = false;
            data_grid_orders.AllowUserToResizeRows = false;
            
        }
        private void btn_done_Click(object sender, EventArgs e)
        {
            CheckPushState = true;
            string[] queries = new string[global_table.Rows.Count];
            for (int i = 0; i < data_grid_orders.Rows.Count; i++)
            {
                if (data_grid_orders.Rows[i].Cells[0].Value == null)
                {
                    MessageBox.Show("Не сте въвели лекарство на артикул");
                    CheckPushState = false;
                    return;
                }
                if (data_grid_orders.Rows[i].Cells[1].Value == null)
                {
                    MessageBox.Show("Не сте въвели количество на артикул");
                    CheckPushState = false;
                    return;
                }
                string query = $"Insert into medicine_orders (faktura_id,medicine_id,date_arrival,date_expire,stock_quantity,current_quantity,price_per_unit,metadata) Values ({faktura_id_box.Text},{data_grid_orders.Rows[i].Cells[1].Value.ToString()},'{data_grid_orders.Rows[i].Cells[2].Value.ToString()}','{data_grid_orders.Rows[i].Cells[3].Value.ToString()}',{data_grid_orders.Rows[i].Cells[4].Value.ToString()},{data_grid_orders.Rows[i].Cells[5].Value.ToString()},{data_grid_orders.Rows[i].Cells[6].Value.ToString()},'{data_grid_orders.Rows[i].Cells[7].Value.ToString()}')";
                queries[i] = query;
            }
            if (creds.AtomicMultiQuery(queries))
            {
                MessageBox.Show("Успешно добавихте поръчките");
                this.Close();
            }
            else
            {
                MessageBox.Show("Неуспешно добавяне на поръчки");
            }
        }

        private void pick_faktura_Click(object sender, EventArgs e)
        {
            var x = new data_grid_select(creds.QueryTranslateHeaders($"SELECT * FROM fakturi"), "Избери фактура, към която да добавям.");
            x.ShowDialog();
            faktura_id_box.Text = x.GetReturnString();
        }

        private void btn_pick_medicine_id_Click(object sender, EventArgs e)
        {
            var x = new data_grid_select(creds.QueryTranslateHeaders($"SELECT * FROM medicines"), "Избери лекарство.");
            x.ShowDialog();
            medicine_id.Text = x.GetReturnString();
            
        }

        private void add_order_Click(object sender, EventArgs e)
        {
            if (faktura_id_box.Text.Contains("'") || faktura_id_box.Text == null || faktura_id_box.Text == "") { MessageBox.Show("Изберете фактура от съществуващите или създайте нова"); return; }
            if (medicine_id.Text.Contains("'") || medicine_id.Text == null || medicine_id.Text == "") { MessageBox.Show("Изберете лекарство от съществуващите типове или създайте ново."); return; }
            if (numud_quantity.Value == 0) { MessageBox.Show("Моля използвайте реална стойност за количество."); return; }
            if (numud_price.Value == 0) { MessageBox.Show("Моля използвайте реална стойност за цена."); return; }
            if (data_grid_orders.DataSource == null)
            {
                //add all columns
                global_table.Columns.Add("faktura_id");
                global_table.Columns.Add("medicine_id");
                global_table.Columns.Add("date_arrival");
                global_table.Columns.Add("date_expire");
                global_table.Columns.Add("stock_quantity");
                global_table.Columns.Add("current_quantity");
                global_table.Columns.Add("price_per_unit");
                global_table.Columns.Add("metadata");
                data_grid_orders.DataSource = global_table;
            }
                //add row
                global_table.Rows.Add(faktura_id_box.Text, medicine_id.Text, date_order.Value.ToString("yyyy-MM-dd"), date_expire.Value.ToString("yyyy-MM-dd"), numud_quantity.Value.ToString(), numud_quantity.Value.ToString(), numud_price.Value.ToString(), metadata.Text);
                data_grid_orders.DataSource = global_table;
            //clear the input fields
            medicine_id.Text = "";
            numud_price.Value = 0;
            numud_quantity.Value = 0;
            metadata.Text = "";
        }

        private void remove_order_Click(object sender, EventArgs e)
        {
            if (data_grid_orders.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in data_grid_orders.SelectedRows)
                {
                    data_grid_orders.Rows.RemoveAt(row.Index);
                }
            }
        }
    }
}

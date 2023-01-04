using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace MGMT.Forms.add_forms
{
    public partial class add_operation_form : Form
    {
        credentials global_creds;
        public add_operation_form(credentials creds)
        {
            InitializeComponent();
            global_creds = creds;
        }

        private void add_operation_form_Load(object sender, EventArgs e)
        {
            data_grid.Visible = false;
            data_grid.ReadOnly = true;
            data_grid.AllowUserToAddRows = false;
            data_grid.AllowUserToDeleteRows = false;
            data_grid.AllowUserToResizeRows = false;
            data_grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void pick_animal_Click(object sender, EventArgs e)
        {
            data_grid_select sel = new data_grid_select(global_creds.Query(global_creds.BuildSuperSearchQuery("animals", ""), global_creds.GetTableHeaderNamesTranslated("animals")), "animals");
            sel.ShowDialog();
            if (sel.GetReturnString() == null) return;
            animal_id_box.Text = sel.GetReturnString();
            string query = $"SELECT * from operations o,medicines m,procedures p WHERE o.procedure_id=p.id and p.medicine_id = m.id AND o.animal_id = {animal_id_box.Text} ORDER BY o.date DESC";
            var selected_animal_operations_sorted_by_date = global_creds.QueryTranslateHeaders(query);
            selected_animal_operations_sorted_by_date.TableName = $"Операции върху добитък №{animal_id_box.Text} (сортирани по дата)";
            data_grid.DataSource = selected_animal_operations_sorted_by_date;
            data_grid.Visible = true;
            this.Size = new Size(this.MaximumSize.Width, this.MaximumSize.Height);
        }

        private void pick_procedure_Click(object sender, EventArgs e)
        {
            data_grid_select sel = new data_grid_select(global_creds.Query(global_creds.BuildSuperSearchQuery("procedures", ""), global_creds.GetTableHeaderNamesTranslated("procedures")), "procedures");
            sel.ShowDialog();
            if (sel.GetReturnString() == null) return;
            procedure_id_box.Text = sel.GetReturnString();
            
        }

        private void pick_order_Click(object sender, EventArgs e)
        {
            if (procedure_id_box.Text == "")
            {
                MessageBox.Show("Не сте избрали процедура!");
                return;
            }
            string query = $"Select * from medicine_orders where current_quantity >= (select medicine_quantity from procedures where id = {procedure_id_box.Text}) and medicine_id = (select medicine_id from procedures where id = {procedure_id_box.Text})";
            data_grid_select sel = new data_grid_select(global_creds.Query(query, global_creds.GetTableHeaderNamesTranslated("medicine_orders")), "Избери поръчка, от която ще се изпълни тази операция.");
            sel.ShowDialog();
            if (sel.GetReturnString() == null) return;
            source_order_id_box.Text = sel.GetReturnString();
        }

        private void complete_operation_Click(object sender, EventArgs e)
        {
            if (date_time_picker.Value == null || animal_id_box.Text == "" || procedure_id_box.Text == "" || source_order_id_box.Text == "")
            {
                MessageBox.Show("Не сте попълнили всички полета!");
                return;
            }
            if (animal_id_box.Text != "" && procedure_id_box.Text != "" && source_order_id_box.Text != "")
            {
                string query1 = $"insert into operations (date,animal_id, procedure_id, source_order_id) values ('{date_time_picker.Value.ToString("yyyy-MM-dd")}',{animal_id_box.Text}, {procedure_id_box.Text}, {source_order_id_box.Text})";
                string query2 = $"update medicine_orders set current_quantity = current_quantity - (select medicine_quantity from procedures where id = {procedure_id_box.Text}) where id = {source_order_id_box.Text}";
                if (global_creds.AtomicMultiQuery(new string[] {query1,query2 }))MessageBox.Show("Успешно добавихте операция!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Не сте попълнили всички полета!");
            }
        }

        private void data_grid_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

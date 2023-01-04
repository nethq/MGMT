using MGMT.Forms;
using MGMT.Forms.add_forms;
using System;
using System.Drawing;
using System.Security.RightsManagement;
using System.Windows.Forms;

namespace MGMT
{
    
    public partial class form_main : Form
    {
        credentials global_credentials;
        special_executor spec_ex;
        public form_main()
        {            
            InitializeComponent();
            credentials creds = new credentials();
            if (creds.TestConnection(true))
            {
                global_credentials = creds;
                creds.ExportCredentialsToFile();
                spec_ex = new special_executor(global_credentials);
                grp_database_login.Visible = false;
            }
        }
        private void btn_spravka_Click(object sender, EventArgs e)
        {
            if (global_credentials == null)
            {
                MessageBox.Show("Не сте влезли в системата!");
                return;
            }
            if (cb_table_names.Text.Contains("'")) return;
            if (cb_table_names.Text == "") return;
            string table = cb_table_names.Text;
            string search_value = search_box.Text;
            System.Threading.Thread t = new System.Threading.Thread(() => new data_grid_form(global_credentials.QueryTranslateHeaders(global_credentials.BuildSuperSearchQuery(table,search_value)),"Справка").ShowDialog());
            t.Start();
        }
        private void form_main_Load(object sender, EventArgs e)
        {
            if(global_credentials != null && global_credentials.TestConnection() && spec_ex != null)
            {
                cb_table_names.Items.AddRange(global_credentials.GetTablesFromDatabase());
                cb_table_names.SelectedIndex = 0;
                foreach (var item in spec_ex.SpecialFunctions.Keys)
                {
                    Button btn = new Button();
                    btn.Text = item; 
                    btn.Font = this.Font;
                    btn.ForeColor = Color.FromArgb(0, 0, 0);
                    btn.BackColor = Color.FromArgb(255, 255, 255);
                    btn.AutoEllipsis = true;
                    btn.AutoSize = true;
                    btn.Size = new Size(10, 10);
                    btn.Click += Btn_Click;
                    special_button_layout.Controls.Add(btn);
                }
                
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn == null) return;
            string special_request = spec_ex.PopulateSpecialRequest(spec_ex.SpecialFunctions[btn.Text]);
            if (special_request == null) return;
            data_grid_form show = new data_grid_form(global_credentials.QueryTranslateHeaders(special_request), btn.Text);
            if (special_request.ToUpper().Contains("SELECT"))
            {
                show.ShowDialog();  
            }
        }
        
        private void btn_login_Click(object sender, EventArgs e)
        {
            credentials test = new credentials(server_box.Text, database_box.Text, username_box.Text, password_box.Text,port_box.Text);
            if (test.TestConnection(true ))
            {
                global_credentials = test;
                MessageBox.Show("Успешна връзка с базата данни!");
            }
            else
            {
                MessageBox.Show("Възникна проблем при връзката с базата данни!");
            }
        }

        private void btn_save_creds_Click(object sender, EventArgs e)
        {
            credentials test = new credentials(server_box.Text, database_box.Text, username_box.Text, password_box.Text,port_box.Text);
            if (test.TestConnection())
            {
                global_credentials = test;
                MessageBox.Show("Успешна връзка с базата данни!");
                test.ExportCredentialsToFile();
            }
            else
            {
                MessageBox.Show("Възникна проблем при връзката с базата данни!");
            }
        }

        private void btn_create_animal_Click(object sender, EventArgs e)
        {
            var thread = new System.Threading.Thread(() => new add_animal(global_credentials).ShowDialog());
            thread.Start();
        }

        private void btn_create_delivery_source_Click(object sender, EventArgs e)
        {
            var thread = new System.Threading.Thread(() => new add_delivery_source(global_credentials).ShowDialog());
            thread.Start();
            
        }
        private void btn_create_medicine_Click(object sender, EventArgs e)
        {
            //create medicine
            var thread = new System.Threading.Thread(() => new add_medicine(global_credentials).ShowDialog());
            thread.Start();
        }

        private void btn_create_faktura_Click(object sender, EventArgs e)
        {
            var thread = new System.Threading.Thread(() => new add_faktura(global_credentials).ShowDialog());
            thread.Start();
        }

        private void add_orders_to_fakturi_Click(object sender, EventArgs e)
        {
            var thread = new System.Threading.Thread(() => new add_medicine_orders(global_credentials).ShowDialog());
            thread.Start();
        }

        private void btn_create_procedure_Click(object sender, EventArgs e)
        {
            var thread = new System.Threading.Thread(() => new add_procedure(global_credentials).ShowDialog());
            thread.Start();
        }

        private void btn_create_operation_Click(object sender, EventArgs e)
        {
            var thread = new System.Threading.Thread(() => new add_operation_form(global_credentials).ShowDialog());
            thread.Start();
        }
    }
}

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
    public partial class add_medicine : Form
    {
        private credentials creds;
        public add_medicine(credentials creds)
        {
            InitializeComponent();
            this.creds = creds;
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            if (name_box.Text.Length > 0)
            {
                string query = $"select count(id) from medicines where name = '{name_box.Text.ToLower()}'";
                if (creds.QuerySingleReturn(query) == 0)
                {
                    var x = name_box.Text;
                    string insert_query = $"Insert into medicines (name) values ('{x.ToLower()}')";
                    if (creds.AtomicMultiQuery(new string[] { insert_query })) {
                        MessageBox.Show("Успешно добавихте лекарство!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Възникна проблем при добавянето на лекарство!");
                    }
                }
                else
                {
                    MessageBox.Show("Вече съществува лекарство с такова име.");
                }
            }
        }
    }
}

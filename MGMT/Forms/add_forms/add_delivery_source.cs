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
    public partial class add_delivery_source : Form
    {
        private credentials creds;
        public add_delivery_source(credentials creds)
        {
            InitializeComponent();
            this.creds = creds;
        }

        private void add_delivery_source_Load(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string name = name_box.Text;
            string metadata = metadata_box.Text;
            string query = "INSERT INTO delivery_agent (name, metadata) VALUES ('" + name + "', '" + metadata + "')";
            if(creds.AtomicMultiQuery(new string[] { query }))
            {
                MessageBox.Show("Успешно добавихте доставчик!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Неуспешно добавяне на доставчик!");
            }
            this.Close();
        }
    }
}

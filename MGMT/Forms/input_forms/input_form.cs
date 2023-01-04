using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MGMT.Forms.input_forms
{
    public partial class input_form : Form
    {
        private string global_picked_type;
        private string returnValue;
        public string GetReturnValue()
        {
            return returnValue;
        }
        //a constructor that lets the user pick from an enumerable object containing "string","int","date" and "double"
        public input_form(string type,string title="Въведи ...")
        {
            //string , int , date , double
            InitializeComponent();
            this.Text = title;
            //depending on the specified type, unhide the box that allows the user to input the value
            switch (type) {
                case "string": {txt_string_input.Visible = true;}break;
                case "int": { num_up_down_int.Visible = true; }break;
                case "date": { date_time_picker.Visible= true; }break;
                case "double": { num_up_down_int.Visible = true;num_up_down_int.Increment = 0.01m;num_up_down_int.DecimalPlaces = 2; }break;
                default: { this.Dispose(); break; }
            }
            global_picked_type = type;
        }

        private void input_form_Load(object sender, EventArgs e)
        {

        }

        private void btn_done_Click(object sender, EventArgs e)
        {
            switch (global_picked_type)
            {
                case "string": { returnValue = txt_string_input.Text; } break;
                case "int": { returnValue = num_up_down_int.Value.ToString(); } break;
                case "date": { returnValue = date_time_picker.Value.ToString("yyyy-MM-dd"); } break;
                case "double": { returnValue = num_up_down_int.Value.ToString(); } break;
                default: { this.Dispose(); break; }
            }
            this.Close();
        }
    }
}

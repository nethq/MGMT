using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using Microsoft.Office.Interop;
using Org.BouncyCastle.Tls.Crypto.Impl.BC;

namespace MGMT
{
    public partial class data_grid_form : Form
    {
        private DataTable dt_source;
        private void ExportFunction()
        {

            if (data_grid.DataSource == null)
            {
                MessageBox.Show("Няма данни за изнасяне!");
                return;
            }
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Екселски файл(*.xlsx)|*.xlsx|Разделен с запетая формат (*.csv)|*.csv";
            saveFileDialog1.Title = "Изберете файл за запис";
            saveFileDialog1.FileName = $"{this.Text}_{DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss")}";
            saveFileDialog1.ShowDialog();

            //if selected file is .xlsx
            if (saveFileDialog1.FileName.Contains(".xlsx"))
            {
                //create a new excel file
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;
                Microsoft.Office.Interop.Excel.Workbook workbook = excel.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel.Worksheet worksheet = null;
                try
                {
                    worksheet = workbook.ActiveSheet;
                    worksheet.Name = "Справка";
                    for (int i = 1; i < data_grid.Columns.Count + 1; i++)
                    {
                        worksheet.Cells[1, i] = data_grid.Columns[i - 1].HeaderText;
                    }
                    for (int i = 0; i < data_grid.Rows.Count; i++)
                    {
                        for (int j = 0; j < data_grid.Columns.Count; j++)
                        {
                            worksheet.Cells[i + 2, j + 1] = data_grid.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    workbook.SaveAs(saveFileDialog1.FileName);
                    MessageBox.Show("Успешно записахте справката във файл!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    workbook.Close();
                    excel.Quit();
                }
            }
            //if selected file is .csv
            else if (saveFileDialog1.FileName.Contains(".csv"))
            {
                //create a new csv file
                string csv = string.Empty;
                //add the column names
                for (int i = 0; i < data_grid.Columns.Count; i++)
                {
                    csv += data_grid.Columns[i].HeaderText + ',';
                }
                //add new line
                csv += "\n";
                //add the rows
                for (int i = 0; i < data_grid.Rows.Count; i++)
                {
                    for (int j = 0; j < data_grid.Columns.Count; j++)
                    {
                        csv += data_grid.Rows[i].Cells[j].Value.ToString().Replace(",", ";") + ',';
                    }
                    //add new line
                    csv += "\n";
                }
                //write the file
                System.IO.File.WriteAllText(saveFileDialog1.FileName, csv);
            }
        }
        public data_grid_form(DataTable table)
        {
            InitializeComponent();
            data_grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            data_grid.DataSource = table;
            dt_source = table;
        }
        public data_grid_form(DataTable table, string title)
        {
            InitializeComponent();
            data_grid.DataSource = table;
            //make the table autosize
            data_grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.Text = title;
            dt_source = table;
        }
        private void data_grid_form_Load(object sender, EventArgs e)
        {
            data_grid.AutoSize = true;
            data_grid.ContextMenuStrip = data_grid_context_menu;
            //resize the form to the columns width
            this.Width = data_grid.Columns.Cast<DataGridViewColumn>().Sum(x => x.Width);
        }

        private void cntxtmenu_export_Click(object sender, EventArgs e)
        {
            var thread = new System.Threading.Thread(ExportFunction);
            thread.SetApartmentState(System.Threading.ApartmentState.STA);
            thread.Start();
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
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            //if control + f is pressed
            if (e.KeyCode == Keys.F && e.Control)
            {
                search_box.Focus();
            }
            if (e.KeyCode == Keys.F5)
            {
                data_grid.DataSource = dt_source;
            }
        }

        private void data_grid_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            //free the data
            try {
                data_grid.Dispose();
            }
            catch(Exception ex) { }
        }
    }
}

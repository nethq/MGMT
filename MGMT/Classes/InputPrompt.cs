//C#
//type : library - to be compiled into a dll
//Function : take a string, if a defined structure of "<{function}_{data_type}_{prompt}>" has been encountered, prompt the user to input the specified data, with the specified prompt , and replace in the original string. The prompts should be done dynamically. Samples : "<INPUT_string_What is your name?>" - will pop up a dialogbox, that will take the input and if the user closed the box, the the whole process halts, and returns null.
//The function should be able to handle multiple prompts in the same string.

using System;
using System.Windows.Forms;

namespace InputPrompt
{
    public class InputPrompt
    {
        public static string Prompt(string input)
        {
            if (input == null) return null;
            string output = "";
            //check if the string contains any sequence of <{function}_{datatype}_{prompt}>
            while (input.Contains("<INPUT") && input.Contains(">"))
            {
                //check if all opening '<' have a closing '>'
                if (input.IndexOf("<") > input.IndexOf(">"))
                {
                    //if not, return null
                    return null;
                }
                //if yes, extract the string between the first '<' and the first '>'
                string prompt = input.Substring(input.IndexOf("<"), input.IndexOf(">") - input.IndexOf("<") + 1);
                //check if the string is in the correct format, being <{function}_{datatype}_{prompt}>

                //split the prompt
                string prompt_text = prompt.Split('_')[2].Replace(">", "");
                string data_type = prompt.Split('_')[1];

                string input_text = "";
                if (data_type.ToLower() == "string")
                {
                    input_text = PromptString(prompt_text);
                }
                else if (data_type.ToLower() == "int")
                {
                    input_text = PromptInt(prompt_text).ToString();
                }
                else if (data_type.ToLower() == "double")
                {
                    input_text = PromptDouble(prompt_text).ToString();
                }
                else if (data_type.ToLower() == "bool")
                {
                    input_text = PromptBool(prompt_text).ToString();
                }
                else if (data_type.ToLower() == "date")
                {
                    input_text = PromptDate(prompt_text).ToString("yyyy-MM-dd");
                }
                else
                {
                    input_text = PromptString(prompt_text);
                }
                //replace the prompt with the input
                input = input.Replace(prompt, input_text);
            }
            output = input;
            return output;
        }

        public static string PromptString(string prompt)
        {
            string result = "";
            Form prompt_form = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = prompt,
                StartPosition = FormStartPosition.CenterScreen
            };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt_form.Close(); };
            prompt_form.Controls.Add(textBox);
            prompt_form.Controls.Add(confirmation);
            prompt_form.AcceptButton = confirmation;

            if (prompt_form.ShowDialog() == DialogResult.OK)
            {
                result = textBox.Text;
            }
            else
            {
                result = null;
            }
            return result;
        }

        public static int PromptInt(string prompt)
        {
            //a new form with a numeric_up_down control, set with int parameters
            int result = 0;
            Form prompt_form = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = prompt,
                StartPosition = FormStartPosition.CenterScreen
            };
            NumericUpDown numericUpDown = new NumericUpDown() { Left = 50, Top = 50, Width = 400, Minimum = int.MinValue, Maximum = int.MaxValue };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt_form.Close(); };
            prompt_form.Controls.Add(numericUpDown);
            prompt_form.Controls.Add(confirmation);
            prompt_form.AcceptButton = confirmation;
            if (prompt_form.ShowDialog() == DialogResult.OK)
            {
                result = (int)numericUpDown.Value;
            }
            else
            {
                result = 0;
            }
            return result;
        }

        public static double PromptDouble(string prompt)
        {
            //A new form with a numeric_up_down control, set with double parameters
            double result = 0;
            Form prompt_form = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = prompt,
                StartPosition = FormStartPosition.CenterScreen
            };
            NumericUpDown numericUpDown = new NumericUpDown() { Left = 50, Top = 50, Width = 400, Minimum = decimal.MinValue, Maximum = decimal.MaxValue };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt_form.Close(); };
            prompt_form.Controls.Add(numericUpDown);
            prompt_form.Controls.Add(confirmation);
            prompt_form.AcceptButton = confirmation;
            if (prompt_form.ShowDialog() == DialogResult.OK)
            {
                result = (double)numericUpDown.Value;
            }
            else
            {
                result = 0;
            }
            return result;
        }

        public static bool PromptBool(string prompt)
        {
            //2 radiobuttons with yes and no
            bool result = false;
            Form prompt_form = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = prompt,
                StartPosition = FormStartPosition.CenterScreen
            };
            RadioButton yes = new RadioButton() { Left = 50, Top = 50, Text = "Yes" };
            RadioButton no = new RadioButton() { Left = 50, Top = 70, Text = "No" };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt_form.Close(); };
            prompt_form.Controls.Add(yes);
            prompt_form.Controls.Add(no);
            prompt_form.Controls.Add(confirmation);
            prompt_form.AcceptButton = confirmation;
            if (prompt_form.ShowDialog() == DialogResult.OK)
            {
                if (yes.Checked)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            else
            {
                result = false;
            }
            return result;
        }

        public static DateTime PromptDate(string prompt)
        {
            //A new form with a date time picker control
            DateTime result = DateTime.Now;
            Form prompt_form = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = prompt,
                StartPosition = FormStartPosition.CenterScreen
            };
            //set the datetime picker to show only the date/month/year
            DateTimePicker dateTimePicker = new DateTimePicker() { Left = 50, Top = 50, Width = 400, Format = DateTimePickerFormat.Custom, CustomFormat = "dd/MM/yyyy HH:mm:ss" };
            dateTimePicker.Format = DateTimePickerFormat.Short;
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt_form.Close(); };
            prompt_form.Controls.Add(dateTimePicker);
            prompt_form.Controls.Add(confirmation);
            prompt_form.AcceptButton = confirmation;
            if (prompt_form.ShowDialog() == DialogResult.OK)
            {
                result = dateTimePicker.Value;
            }
            else
            {
                result = DateTime.Now;
            }
            return result;
        }
    }
}
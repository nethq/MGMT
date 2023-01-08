using MGMT.Forms.input_forms;
using MGMT.Forms;
using MGMT;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System;
using System.Windows.Forms;
using System.Data;
using InputPrompt;
public class special_executor
{
    private credentials generic_creds;
    private credentials special_creds;
    public Dictionary<string, string> SpecialFunctions;
    public int priv_cap = 10;
    public special_executor(credentials S_Credentials)
    {
        generic_creds = new credentials(S_Credentials.Server, S_Credentials.Database, S_Credentials.Username, S_Credentials.Password, S_Credentials.Port);
        special_creds = new credentials(S_Credentials.Server, "special_actions_mgmt", S_Credentials.Username, S_Credentials.Password, S_Credentials.Port);
        if (special_creds.TestConnection())
        {
            priv_cap = GetUserQueryLevel();
            GetPreBuiltQueries();
            return;
        }
        else special_creds = null;
    }

    private int GetUserQueryLevel()
    {
        if (special_creds == null) return -1;
        var query = "SELECT `priv_cap` FROM `users` WHERE `user_name` = '" + generic_creds.Username + "'";
        var result = special_creds.Query(query);
        if (result.Rows.Count == 0) return -1;
        return Convert.ToInt32(result.Rows[0][0]);
    }
    /// <summary>
    /// </summary>
    /// <returns>Gets a dictionary of names:sql_queries from special_actions_mgmt schema</returns>
    public void GetPreBuiltQueries()
    {
        try
        {
            Dictionary<string, string> return_dictionary;
            return_dictionary = new Dictionary<string, string>();
            string query = $"select name,query from pre_built_queries where control < {priv_cap}";
            //make a request and write the data to a datasetca
            var connection = new MySqlConnection(special_creds.GetConnectionString());
            connection.Open();
            var command = new MySqlCommand(query, connection);
            var adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            //from the table get every pair of first column to second column
            for (int i = 0; i < table.Rows.Count; i++)
            {
                return_dictionary.Add(table.Rows[i][0].ToString(), table.Rows[i][1].ToString());
            }
            SpecialFunctions = return_dictionary;
        }
        catch (Exception ex)
        {
            MessageBox.Show("Възникна проблем при изпълняването на заявката от базата данни !" + ex.Message);
        }
    }
    public string PopulateSpecialRequest(string special_request)
    {
        //check if string contains "<pick_from_" and has a closing ">" and get the string that is to be picked from
        special_request = PickFrom(special_request);
        special_request = InputPrompt.InputPrompt.Prompt(special_request);
        if(special_request == null) return null;
        return special_request;
    }

    private string PickFrom(string special_request)
    {
        while (special_request.ToLower().Contains("<pick_from_") && special_request.Contains(">"))
        {
            string pick_from;
            pick_from = special_request.Substring(special_request.IndexOf("<pick_from_") + 11, special_request.IndexOf(">") - (special_request.IndexOf("<pick_from_") + 11));
            try
            {
                data_grid_select select = new data_grid_select(generic_creds.QueryTranslateHeaders(generic_creds.BuildSuperSearchQuery(pick_from, "")), "Избери");
                select.ShowDialog();
                var picked_index = select.GetReturnString();
                if (picked_index == null)
                {
                    return null;
                }
                if (picked_index != null && Int32.Parse(picked_index) > 0)
                {
                    special_request = special_request.Replace($"<pick_from_{pick_from}>", picked_index);
                }
            }
            catch (Exception ex) { }
        }
        return special_request;
    }
}
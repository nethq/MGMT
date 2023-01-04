using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;
using System.Runtime.Remoting.Channels;
using MySql.Data;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Media.Media3D;
using System.CodeDom;
using System.Collections;
using MGMT.Forms;
using MGMT;
using MGMT.Forms.input_forms;

namespace MGMT
{
    public class credentials
    {   
        public credentials(string server , string database, string username, string password,string port)
        {
            this.Server = server;
            this.Database = database;
            this.Username = username;
            this.Password = password;
            this.Port = port;
        }

        public credentials()
        {
            try
            {
                ImportCredentialsFromFile();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
        }
        public DataTable Query(string query, string[] headerNames = null)
        {
            try
            {
                //make a request and write the data to a dataset
                var connection = new MySqlConnection(GetConnectionString());
                connection.Open();
                var command = new MySqlCommand(query, connection);
                var adapter = new MySqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                if (headerNames != null)
                {
                    for (int i = 0; i < headerNames.Length; i++)
                    {
                        table.Columns[i].ColumnName = headerNames[i];
                    }
                    if (headerNames.Length < table.Columns.Count)
                    {
                        //if less headerNames are given than the number of columns, the remaining will be deleted
                        for (int i = headerNames.Length; i < table.Columns.Count; i++)
                        {
                            table.Columns.RemoveAt(i);
                        }
                    }
                }
                return table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Възникна проблем при изпълняването на заявката от базата данни!" + ex.Message);
                return null;
            }
        }
        public DataTable QueryTranslateHeaders(string query)
        {
            try
            {
                //make a request and write the data to a dataset
                var connection = new MySqlConnection(GetConnectionString());
                connection.Open();
                var command = new MySqlCommand(query, connection);
                var adapter = new MySqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                for (int i = 0; i < table.Columns.Count; i++)
                {
                    table.Columns[i].ColumnName = Translate(table.Columns[i].ColumnName);
                }
                return table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Възникна проблем при изпълняването на заявката от базата данни!" + ex.Message);
                return null;
            }
        }
        public bool AtomicMultiQuery(string[] queries, bool showErrors = true)
        {
            try
            {
                var connection = new MySqlConnection(GetConnectionString());
                connection.Open();
                var command = new MySqlCommand();
                command.Connection = connection;
                foreach (string query in queries)
                {
                    command.CommandText = query;
                    command.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                if (showErrors)
                {
                    MessageBox.Show("Възникна проблем при изпълняването на заявката от базата данни!" + ex.Message);
                }
                return false;
            }
        }
        public int QuerySingleReturn(string query)
        {
            try
            {
                //make a request and write the data to a dataset
                var connection = new MySqlConnection(GetConnectionString());
                connection.Open();
                var command = new MySqlCommand(query, connection);
                var adapter = new MySqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                
                if (table.Rows.Count == 0)
                {
                    return 0;
                }
                else
                {
                    return Convert.ToInt32(table.Rows[0][0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Възникна проблем при изпълняването на заявката от базата данни!" + ex.Message);
                return 0;
            }
        }
        public bool TestConnection(bool Warning=false)
        {
            //make a request to the server to check if the connection is valid
            try
            {
                var connection = new MySql.Data.MySqlClient.MySqlConnection();
                connection.ConnectionString = String.Format("server={0};user id={1}; password={2}; database={3}", Server, Username, Password, Database);
                connection.Open();
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                if (Warning) MessageBox.Show("Възникна проблем при връзката с базата данни!\n" + ex.Message);
                return false;
            }
        }
        public string Server { get; set; }
        public string Database{ get; set; }
        public string Username { get; set; }
        public string Password{ get; set; }
        public string Port { get;set; }
        public IDictionary<string, string> Locale { get; set; }
        public string[] GetTablesFromDatabase()
        {            
            string query = "show tables";
            MySqlDataAdapter data = new MySqlDataAdapter(query, new MySqlConnection(GetConnectionString()));
            DataTable dt = new DataTable();
            data.Fill(dt);
            //return the string in the first cell of each row from dt
            return dt.AsEnumerable().Select(x => x[0].ToString()).ToArray();
        }

        public string[] GetColumnsOfTableFromDatabase(string table_name)
        {
            string query = $"SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{table_name}' ORDER BY ORDINAL_POSITION";
            MySqlDataAdapter data = new MySqlDataAdapter(query, new MySqlConnection(GetConnectionString()));
            DataTable dt = new DataTable();
            data.Fill(dt);
            //return the string in the first cell of each row from dt
            return dt.AsEnumerable().Select(x => x[0].ToString()).ToArray();
        }
        
        public string[] GetTableHeaderNamesTranslated(string table_name)
        {
            string[] headerNames = GetColumnsOfTableFromDatabase(table_name);
            
            for (int i = 0; i < headerNames.Length; i++)
            {
                headerNames[i] = Translate(headerNames[i]);
            }
            return headerNames;
        }
        
        public void LoadLocale()
        {
            try
            {
                string[] lines = System.IO.File.ReadAllLines("bg-locale.txt");
                Locale = new Dictionary<string, string>();
                foreach (string line in lines)
                {
                    string[] split = line.Split(new char[] { '=' }, 2);
                    Locale.Add(split[0], split[1]);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Грешка при зареждането на превода: " + e.Message);
            }
        }
        public string Translate(string source_string)
        {
            if (Locale == null)
            {
                LoadLocale();
            }
            if (Locale == null)
            {
                return source_string;
            }
            if (Locale.ContainsKey(source_string))
            {
                return Locale[source_string];
            }
            else
            {
                return source_string;
            }
        }
            public string BuildSuperSearchQuery(string table,string value)
        {
            string query = "SELECT * FROM " + table + " WHERE ";
            //get table column names
            string[] column_names = GetColumnsOfTableFromDatabase(table);
            //build query with the column names
            for (int i = 0; i < column_names.Length; i++)
            {
                query += column_names[i] + " LIKE '%" + value + "%'";
                if (i != column_names.Length - 1)
                {
                    query += " OR ";
                }
            }
            return query;
        }
        public string BuildSearchQuery(string table, string[] columns, string[] values)
        {
            string query = "SELECT * FROM " + table + " WHERE ";
            for (int i = 0; i < columns.Length; i++)
            {
                query += columns[i] + " LIKE '%" + values[i] + "%'";
                if (i != columns.Length - 1)
                {
                    query += " AND ";
                }
            }
            return query;
        }
        public string BuildQuery(string table, string[] columns)
        {
            if (table == null || columns == null) return null;
            string query = "SELECT ";
            for (int i = 0; i < columns.Length; i++)
            {
                query += columns[i];
                if (i != columns.Length - 1) query += ", ";
            }
            query += " FROM " + table;
            return query;
        }
        public string GetConnectionString()
        {
            return String.Format("server={0};user id={1}; password={2}; database={3};port={4};", Server, Username, Password, Database, Port);
        }
        public void ImportCredentialsFromFile(string filepath)//line1 = server, line2 = database, line3 = username, line4 = password
        {
            try
            {
                string[] lines = System.IO.File.ReadAllLines(filepath);
                Server = lines[0];
                Database = lines[1];
                Username = lines[2];
                Password = lines[3];
                Port = lines[4];
            }
            catch (Exception ex) { MessageBox.Show("Възникна проблем при импортирането на настройките!\n" + ex.Message); }
        }
        public void ImportCredentialsFromFile()//line1 = server, line2 = database, line3 = username, line4 = password
        {
            ImportCredentialsFromFile(Application.StartupPath + "\\settings.ini");
        }
        public void ExportCredentialsToFile(string filepath)//line1=server,line2=database,line3=username,line4=password
        {
            if (!TestConnection()) return;
            try
            {
                string[] lines = { Server, Database, Username, Password, Port};
                System.IO.File.WriteAllLines(filepath, lines);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Възникна проблем при запазването на данните за връзка с базата данни." + ex.Message);
            }
        }
        public void ExportCredentialsToFile()//line1=server,line2=database,line3=username,line4=password
        {
            ExportCredentialsToFile(Application.StartupPath + "\\settings.ini");
        }
    }
    
    public class database_functions 
    {
        credentials class_credentials;
        database_functions(string server, string database, string username, string password,string port)
        {
            credentials temp_credentials = new credentials(server,database,username,password,port);
            if (temp_credentials.TestConnection()) class_credentials = temp_credentials;
        }
        database_functions()
        {
            credentials temp_credentials= new credentials();
            if (temp_credentials.TestConnection()) class_credentials = temp_credentials; 
        }



    }
}

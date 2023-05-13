using System;
using System.Data;
using System.Data.SqlClient;

namespace DatabaseTest
{
    public partial class Form1 : Form
    {
        SqlConnection sqlConnection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Ignác\\source\\repos\\DatabaseTest\\DatabaseTest\\Database1.mdf;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }
        private IEnumerable<string[]> ExecuteQuery(string cmd)
        {
            SqlCommand sqlCommand = new SqlCommand(cmd, sqlConnection);
            IDataReader dataReader = sqlCommand.ExecuteReader();

            string[] columnNames = new string[dataReader.FieldCount];
            for (int i = 0; i < dataReader.FieldCount; i++)
            {
                columnNames[i] = dataReader.GetName(i);
            }
            yield return columnNames;

            while (dataReader.Read())
            {
                string[] rowData = new string[dataReader.FieldCount];
                for (int i = 0; i < dataReader.FieldCount; i++)
                {
                    rowData[i] = dataReader.GetValue(i).ToString()!;
                }
                yield return rowData;
            }
            dataReader.Close();
            yield break;
        }
        private string GetQueryCommand(string filePath)
        {
            var fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            var sr = new StreamReader(fs);
            string query = sr.ReadToEnd();
            sr.Close();
            fs.Close();
            return query;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            sqlConnection.Open();
            FillScriptsComboBox();
        }
        private void FillScriptsComboBox()
        {
            string folder = @"../../../database/queries";
            var scripts = Directory.EnumerateFiles(folder).ToArray();
            foreach (var script in scripts)
            {
                comboBox_scripts.Items.Add(script);
            }
        }
        private void button_executeScript_Click(object sender, EventArgs e)
        {
            string? filePath = comboBox_scripts.SelectedItem as string;
            if (filePath is null) return;

            string queryCommand = GetQueryCommand(filePath);
            IEnumerable<string[]> queryResult = ExecuteQuery(queryCommand);
            richTextBox_queryResult.Text = string.Empty;
            dataGridView_scriptResult.Rows.Clear();
            dataGridView_scriptResult.Columns.Clear();

            int itemCount = 0;
            foreach (var item in queryResult)
            {
                if (itemCount != 0)
                {
                    dataGridView_scriptResult.Rows.Add(item.ToArray());
                }
                else
                {
                    foreach (var columnName in item)
                    {
                        dataGridView_scriptResult.Columns.Add(
                                new DataGridViewTextBoxColumn()
                                {
                                    HeaderText = columnName,
                                    DataPropertyName = columnName
                                }
                            );
                    }
                }
                richTextBox_queryResult.Text += string.Join(" ", item) + 
                    Environment.NewLine + new string('=', 40) + Environment.NewLine;
                itemCount++;
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            sqlConnection.Close();
        }
    }
}
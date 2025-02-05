﻿using GeoProject.Database;
using GeoProject.Models;
using System.Data.SqlClient;


namespace GeoProject
{
    public partial class ConnectDBForm : Form
    {
        public ConnectDBForm()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {

            string server = txtServerName.Text;
            string databaseName = txtDBName.Text;

            string connectionString = $"Data Source={server};Integrated Security=True;Connect Timeout=5;";

            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    var query = $"SELECT COUNT(*) FROM sys.databases WHERE name = '{databaseName}'";
                    using (var command = new SqlCommand(query, connection))
                    {
                        var result = command.ExecuteScalar();
                        int databaseCount = Convert.ToInt32(result);

                        MessageBox.Show($"Количество баз данных с именем '{databaseName}': {databaseCount}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при подключении к базе данных: {ex.Message}");
                return;
            }

            Singleton.Instance.NameServer = server;
            Singleton.Instance.NameDatabase = databaseName;

            ListProjectsForm listProjectsForm = new ListProjectsForm();
            listProjectsForm.ShowDialog();
            this.Close();
        }
    }
}

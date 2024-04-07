using GeoProject.Database;
using GeoProject.Models;
using System.Data.SqlClient;


namespace GeoProject
{
    public partial class ConnectDBForm : Form
    {
        public ConnectDBForm()
        {
            InitializeComponent();
            LoadServers();
        }
        private void LoadServers()
        {
            comboBoxServers.Items.Add("DESKTOP-591T9LE");
            comboBoxServers.Items.Add("DESKTOP");
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {

            string server = comboBoxServers.SelectedItem?.ToString();
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
                        if (databaseCount <= 0)
                        {
                            MessageBox.Show("База данных не существует или отсутствует подключение.");
                            return;
                        }

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

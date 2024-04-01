using GeoProject.Database;
using GeoProject.ManageDB;
namespace GeoProject
{
    public partial class ListProjectsForm : Form
    {
        public ListProjectsForm()
        {
            InitializeComponent();
            ControlHelper.RoundControl(btnListProjects, 15);
        }

        private void ListProjectsForm_Load(object sender, EventArgs e)
        {
            using (var db = new database())
            {
                var projects = db.Projects.ToList();
                foreach (var project in projects)
                {
                    var listProjectsControl = new ListProjects();
                    listProjectsControl.SetProject(project);
                    listProjectsControl.MoreDetailsClicked += ListProjectsControl_MoreDetailsClicked;
                    listProjectsPanel.Controls.Add(listProjectsControl);
                }
            }
        }
        private void ListProjectsControl_MoreDetailsClicked(object sender, ProjectEventArgs e)
        {
            SelectedProjectForm selectedProjectForm = new SelectedProjectForm(e.Project);
            selectedProjectForm.Show();
        }

        private void btnCleanDB_Click(object sender, EventArgs e)
        {
            DatabaseCleaner.Clean();
            listProjectsPanel.Update();
        }

        private void btnSeedDB_Click(object sender, EventArgs e)
        {
            DatabaseSeeder.Seed();
            this.listProjectsPanel.Update();
        }
    }
}

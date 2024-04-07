using GeoProject.Models;

namespace GeoProject
{
    public partial class ListProjects : UserControl
    {
        public event EventHandler<ProjectEventArgs> MoreDetailsClicked;

        private ProjectModel _project;

        public ListProjects()
        {
            InitializeComponent();
            ControlHelper.RoundControl(this, 15);
            ControlHelper.RoundControl(btnDetails, 15);
            btnDetails.Click += btnDetails_Click;
        }

        public void SetProject(ProjectModel project)
        {
            _project = project;
            lblNameProject.Text = project.ProjectName;
            lblDescProject.Text = project.Description;
        }
        protected virtual void OnMoreDetailsClicked(ProjectModel project)
        {
            MoreDetailsClicked?.Invoke(this, new ProjectEventArgs(project));
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            OnMoreDetailsClicked(_project);
        }
    }
}
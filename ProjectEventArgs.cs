using GeoProject.Models;

namespace GeoProject
{
    public class ProjectEventArgs : EventArgs
    {
        public ProjectModel Project { get; }

        public ProjectEventArgs(ProjectModel project)
        {
            Project = project;
        }
    }
}

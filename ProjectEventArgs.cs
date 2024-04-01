using GeoProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

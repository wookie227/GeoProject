using GeoProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeoProject.Database;

namespace GeoProject
{
    public partial class addArea : Form
    {
        private ProjectModel _selectedProject;
        public addArea(ProjectModel selectedProject)
        {
            InitializeComponent();
            ControlHelper.RoundControl(btnAddArea, 15);
            _selectedProject = selectedProject;
        }

        private void btnAddArea_Click(object sender, EventArgs e)
        {
            using (var db = new database())
            {
                var newArea = new AreaModel
                {
                    AreaType = txtTypeArea.Text,
                    Coordinates = txtAreaCoords.Text,
                    ProjectId = _selectedProject.ProjectId,
                };
                // Добавляем профиль в базу данных
                db.Areas.Add(newArea);
                db.SaveChanges();
            }
            MessageBox.Show("Площадь успешно добавлена.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}

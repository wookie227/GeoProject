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
    public partial class addProfile : Form
    {
        private AreaModel _selectedArea;
        public addProfile(AreaModel selectedArea)
        {
            InitializeComponent();
            ControlHelper.RoundControl(btnAddProfile, 15);
            _selectedArea = selectedArea;
        }

        private void btnAddProfile_Click(object sender, EventArgs e)
        {
            using (var db = new database())
            {
                // Создаем новый профиль
                var newProfile = new ProfileModel
                {
                    Coordinates = txtProfileCoords.Text,
                    // Другие поля профиля

                    AreaId = _selectedArea.AreaId // Устанавливаем площадь для профиля
                };

                // Добавляем профиль в базу данных
                db.Profiles.Add(newProfile);
                db.SaveChanges();
            }

            MessageBox.Show("Профиль успешно добавлен.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}

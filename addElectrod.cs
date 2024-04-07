using GeoProject.Models;
using GeoProject.Database;
using System.Globalization;


namespace GeoProject
{
    public partial class addElectrod : Form
    {
        private ProfileModel _selectedProfile;
        public addElectrod(ProfileModel selectedProfile)
        {
            InitializeComponent();
            ControlHelper.RoundControl(btnAddElectrod, 15);
            _selectedProfile = selectedProfile;
        }

        private void btnAddElectrod_Click(object sender, EventArgs e)
        {
            
            using (var db = new MyDBContext(Singleton.Instance.NameServer, Singleton.Instance.NameDatabase))
            {
                // Создаем новый электрод
                double value;
                DateTime dateTime;
                if (!double.TryParse(txtValueElectrod.Text, out value))
                {
                    MessageBox.Show("Введите корректное числовое значение для поля Значение в формате XX,XX.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!DateTime.TryParseExact(txtDate.Text, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTime))
                {
                    MessageBox.Show("Введите корректное значение времени в формате DD.MM.YYYY HH:mm:ss.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var newElectrode = new ElectrodeModel
                {
                    Coordinates = txtElectrodCoords.Text,
                    ElectrodeType = txtTypeElectrod.Text,
                    Value = value,
                    DateTime = dateTime,
                    ProfileId = _selectedProfile.ProfileId // Устанавливаем профиль для электрода
                };

                // Добавляем электрод в базу данных
                db.ElectrodesCoordinates.Add(newElectrode);
                db.SaveChanges();
            }

            MessageBox.Show("Электрод успешно добавлен.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}

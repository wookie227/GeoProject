
using System.Data;
using GeoProject.Models;
using GeoProject.Database;


namespace GeoProject
{
    public partial class SelectedProjectForm : Form
    {
        private ProjectModel project;
        private List<ElectrodeModel> electrodes =  new List<ElectrodeModel>();
        public SelectedProjectForm(ProjectModel project)
        {
            InitializeComponent();
            this.project = project;
            ControlHelper.RoundControl(activePanel, 15);
            ControlHelper.RoundControl(cmbListAreas, 15);
            ControlHelper.RoundControl(cmbListProfiles, 15);
            ControlHelper.RoundControl(btnGraphs, 15);
            ControlHelper.RoundControl(btnAddArea, 15);
            ControlHelper.RoundControl(btnAddProfile, 15);
            ControlHelper.RoundControl(ListElectrods, 15);
        }

        private void SelectedProjectForm_Load(object sender, EventArgs e)
        {
            lblTitleProject.Text = project.ProjectName;
            int projectId = project.ProjectId;
            using (var db = new MyDBContext(Singleton.Instance.NameServer, Singleton.Instance.NameDatabase))
            {
                var areaIds = db.Areas
                                .Where(a => a.ProjectId == projectId)
                                .Select(a => a.AreaId)
                                .ToList();
                cmbListAreas.DataSource = areaIds;
            }
        }

        private void cmbListAreas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedAreaId = Convert.ToInt32(cmbListAreas.SelectedValue);
            using (var db = new MyDBContext(Singleton.Instance.NameServer, Singleton.Instance.NameDatabase))
            {
                var profileIds = db.Profiles
                                    .Where(p => p.AreaId == selectedAreaId)
                                    .Select(p => p.ProfileId)
                                    .ToList();


                cmbListProfiles.DataSource = profileIds;
            }
        }

        private void LoadElectrodes(int profileId)
        {
            using (var db = new MyDBContext(Singleton.Instance.NameServer, Singleton.Instance.NameDatabase))
            {
                // Получаем электроды для выбранного профиля
                var electrodes = db.ElectrodesCoordinates
                                    .Where(ec => ec.ProfileId == profileId)
                                    .ToList();

                // Очищаем FlowLayoutPanel перед добавлением новых контролов
                ListElectrods.Controls.Clear();

                // Для каждого электрода создаем пользовательский контрол и добавляем его в FlowLayoutPanel
                foreach (var electrode in electrodes)
                {
                    var listElectrodeControl = new ListElectods();
                    listElectrodeControl.SetElectrode(electrode);
                    ListElectrods.Controls.Add(listElectrodeControl);
                }
            }
        }

        private void cmbListProfiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            int profileId = (int)cmbListProfiles.SelectedValue;
            LoadElectrodes(profileId);
        }

        private void btnAddElectod_Click(object sender, EventArgs e)
        {
            // Проверяем, выбран ли профиль
            if (cmbListProfiles.SelectedItem == null)
            {
                MessageBox.Show("Сначала выберите профиль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ProfileModel selectedProfile;
            // Получаем выбранный профиль
            using (var db = new MyDBContext(Singleton.Instance.NameServer, Singleton.Instance.NameDatabase))
            {
                int profileId = (int)cmbListProfiles.SelectedValue;
                selectedProfile = db.Profiles.FirstOrDefault(p => p.ProfileId == profileId);
            }


            // Открываем форму для добавления электрода и передаем информацию о выбранном профиле
            var addElectrodeForm = new addElectrod(selectedProfile);
            addElectrodeForm.ShowDialog();
        }

        private void btnAddProfile_Click(object sender, EventArgs e)
        {
            if (cmbListAreas.SelectedItem == null)
            {
                MessageBox.Show("Выберите площадь.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            AreaModel selectedArea;
            using (var db = new MyDBContext(Singleton.Instance.NameServer, Singleton.Instance.NameDatabase))
            {
                int areaId = (int)cmbListAreas.SelectedValue;
                selectedArea = db.Areas.FirstOrDefault(a => a.AreaId == areaId);
            }

            var addProfileForm = new addProfile(selectedArea);
            addProfileForm.ShowDialog();
        }

        private void btnAddArea_Click(object sender, EventArgs e)
        {
            ProjectModel selectedProject = project;
            var addAreaForm = new addArea(selectedProject);
            addAreaForm.ShowDialog();
        }

        private void btnGraphs_Click(object sender, EventArgs e)
        {
            ProfileModel selectedProfile;
            using (var db = new MyDBContext(Singleton.Instance.NameServer, Singleton.Instance.NameDatabase))
            {
                int profileId = (int)cmbListProfiles.SelectedValue;
                selectedProfile = db.Profiles.FirstOrDefault(p => p.ProfileId == profileId);
                var electrodeList = db.ElectrodesCoordinates
                    .Where(e => e.ProfileId == selectedProfile.ProfileId)
                    .ToList();
                foreach (var electrode in electrodeList)
                {
                    electrodes.Add(electrode);
                    Console.WriteLine($"Electrode ID: {electrode.ElectrodeCoordinateId}, Coordinates: {electrode.Coordinates}, DateTime: {electrode.DateTime}");
                }
            }
            GraphicForm graphicForm = new GraphicForm(electrodes);
            graphicForm.ShowDialog();
            
        }
    }
}

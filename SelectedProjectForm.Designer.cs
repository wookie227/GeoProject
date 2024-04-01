namespace GeoProject
{
    partial class SelectedProjectForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            activePanel = new Panel();
            btnAddElectod = new Button();
            ListElectrods = new FlowLayoutPanel();
            lblTitleProject = new Label();
            cmbListProfiles = new ComboBox();
            cmbListAreas = new ComboBox();
            btnAddProfile = new Button();
            btnAddArea = new Button();
            btnGraphs = new Button();
            btnGeoInfo = new Button();
            activePanel.SuspendLayout();
            SuspendLayout();
            // 
            // activePanel
            // 
            activePanel.BackColor = SystemColors.ControlDark;
            activePanel.Controls.Add(btnAddElectod);
            activePanel.Controls.Add(ListElectrods);
            activePanel.Controls.Add(lblTitleProject);
            activePanel.Controls.Add(cmbListProfiles);
            activePanel.Controls.Add(cmbListAreas);
            activePanel.Controls.Add(btnAddProfile);
            activePanel.Controls.Add(btnAddArea);
            activePanel.Controls.Add(btnGraphs);
            activePanel.Controls.Add(btnGeoInfo);
            activePanel.Location = new Point(44, 77);
            activePanel.Margin = new Padding(0);
            activePanel.Name = "activePanel";
            activePanel.Size = new Size(1183, 583);
            activePanel.TabIndex = 0;
            // 
            // btnAddElectod
            // 
            btnAddElectod.Font = new Font("Segoe UI", 14F);
            btnAddElectod.Location = new Point(642, 545);
            btnAddElectod.Name = "btnAddElectod";
            btnAddElectod.Size = new Size(107, 35);
            btnAddElectod.TabIndex = 10;
            btnAddElectod.Text = "Добавить";
            btnAddElectod.UseVisualStyleBackColor = true;
            btnAddElectod.Click += btnAddElectod_Click;
            // 
            // ListElectrods
            // 
            ListElectrods.AutoScroll = true;
            ListElectrods.BackColor = SystemColors.ButtonFace;
            ListElectrods.FlowDirection = FlowDirection.TopDown;
            ListElectrods.Location = new Point(294, 82);
            ListElectrods.Name = "ListElectrods";
            ListElectrods.Padding = new Padding(20);
            ListElectrods.Size = new Size(850, 457);
            ListElectrods.TabIndex = 9;
            ListElectrods.WrapContents = false;
            // 
            // lblTitleProject
            // 
            lblTitleProject.AutoSize = true;
            lblTitleProject.Font = new Font("Segoe UI", 30F);
            lblTitleProject.Location = new Point(446, 20);
            lblTitleProject.Name = "lblTitleProject";
            lblTitleProject.Size = new Size(355, 54);
            lblTitleProject.TabIndex = 8;
            lblTitleProject.Text = "Название проекта";
            // 
            // cmbListProfiles
            // 
            cmbListProfiles.BackColor = SystemColors.ActiveBorder;
            cmbListProfiles.Font = new Font("Segoe UI", 17F);
            cmbListProfiles.FormattingEnabled = true;
            cmbListProfiles.Location = new Point(20, 149);
            cmbListProfiles.Name = "cmbListProfiles";
            cmbListProfiles.Size = new Size(231, 39);
            cmbListProfiles.TabIndex = 7;
            cmbListProfiles.Text = "Список профилей";
            cmbListProfiles.SelectedIndexChanged += cmbListProfiles_SelectedIndexChanged;
            // 
            // cmbListAreas
            // 
            cmbListAreas.BackColor = SystemColors.ActiveBorder;
            cmbListAreas.DisplayMember = "null";
            cmbListAreas.Font = new Font("Segoe UI", 17F);
            cmbListAreas.FormattingEnabled = true;
            cmbListAreas.Location = new Point(20, 82);
            cmbListAreas.Name = "cmbListAreas";
            cmbListAreas.Size = new Size(231, 39);
            cmbListAreas.TabIndex = 6;
            cmbListAreas.Text = "Список площадей";
            cmbListAreas.ValueMember = "AreaId";
            cmbListAreas.SelectedIndexChanged += cmbListAreas_SelectedIndexChanged;
            // 
            // btnAddProfile
            // 
            btnAddProfile.FlatAppearance.BorderSize = 0;
            btnAddProfile.Font = new Font("Segoe UI", 17F);
            btnAddProfile.Location = new Point(20, 517);
            btnAddProfile.Name = "btnAddProfile";
            btnAddProfile.Size = new Size(231, 55);
            btnAddProfile.TabIndex = 5;
            btnAddProfile.Text = "Добавить профиль";
            btnAddProfile.UseVisualStyleBackColor = true;
            btnAddProfile.Click += btnAddProfile_Click;
            // 
            // btnAddArea
            // 
            btnAddArea.FlatAppearance.BorderSize = 0;
            btnAddArea.Font = new Font("Segoe UI", 17F);
            btnAddArea.Location = new Point(20, 442);
            btnAddArea.Name = "btnAddArea";
            btnAddArea.Size = new Size(231, 55);
            btnAddArea.TabIndex = 4;
            btnAddArea.Text = "Добавить площадь";
            btnAddArea.UseVisualStyleBackColor = true;
            btnAddArea.Click += btnAddArea_Click;
            // 
            // btnGraphs
            // 
            btnGraphs.FlatAppearance.BorderSize = 0;
            btnGraphs.Font = new Font("Segoe UI", 15F);
            btnGraphs.Location = new Point(20, 291);
            btnGraphs.Name = "btnGraphs";
            btnGraphs.Size = new Size(231, 55);
            btnGraphs.TabIndex = 3;
            btnGraphs.Text = "График по профилю";
            btnGraphs.UseVisualStyleBackColor = true;
            btnGraphs.Click += btnGraphs_Click;
            // 
            // btnGeoInfo
            // 
            btnGeoInfo.FlatAppearance.BorderSize = 0;
            btnGeoInfo.Font = new Font("Segoe UI", 15F);
            btnGeoInfo.Location = new Point(20, 212);
            btnGeoInfo.Name = "btnGeoInfo";
            btnGeoInfo.Size = new Size(231, 53);
            btnGeoInfo.TabIndex = 2;
            btnGeoInfo.Text = "Геологические данные";
            btnGeoInfo.UseVisualStyleBackColor = true;
            // 
            // SelectedProjectForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(activePanel);
            Name = "SelectedProjectForm";
            Text = "SelectedProjectForm";
            Load += SelectedProjectForm_Load;
            activePanel.ResumeLayout(false);
            activePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel activePanel;
        private Button btnAddProfile;
        private Button btnAddArea;
        private Button btnGraphs;
        private Button btnGeoInfo;
        private ComboBox cmbListAreas;
        private ComboBox cmbListProfiles;
        private Label lblTitleProject;
        private FlowLayoutPanel ListElectrods;
        private Button btnAddElectod;
    }
}
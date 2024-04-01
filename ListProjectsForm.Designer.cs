namespace GeoProject
{
    partial class ListProjectsForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnListProjects = new Button();
            listProjectsPanel = new FlowLayoutPanel();
            btnCleanDB = new Button();
            btnSeedDB = new Button();
            SuspendLayout();
            // 
            // btnListProjects
            // 
            btnListProjects.BackColor = SystemColors.ActiveBorder;
            btnListProjects.FlatAppearance.BorderSize = 0;
            btnListProjects.FlatStyle = FlatStyle.Flat;
            btnListProjects.Font = new Font("Segoe UI", 12F);
            btnListProjects.ForeColor = SystemColors.ActiveCaptionText;
            btnListProjects.Location = new Point(41, 25);
            btnListProjects.Name = "btnListProjects";
            btnListProjects.Size = new Size(174, 42);
            btnListProjects.TabIndex = 0;
            btnListProjects.Text = "Список проектов";
            btnListProjects.UseVisualStyleBackColor = false;
            // 
            // listProjectsPanel
            // 
            listProjectsPanel.AutoScroll = true;
            listProjectsPanel.BackColor = Color.SlateGray;
            listProjectsPanel.Location = new Point(23, 99);
            listProjectsPanel.Name = "listProjectsPanel";
            listProjectsPanel.Padding = new Padding(20);
            listProjectsPanel.Size = new Size(1240, 557);
            listProjectsPanel.TabIndex = 1;
            // 
            // btnCleanDB
            // 
            btnCleanDB.Font = new Font("Segoe UI", 12F);
            btnCleanDB.Location = new Point(852, 25);
            btnCleanDB.Name = "btnCleanDB";
            btnCleanDB.Size = new Size(124, 49);
            btnCleanDB.TabIndex = 2;
            btnCleanDB.Text = "Очистить БД";
            btnCleanDB.UseVisualStyleBackColor = true;
            btnCleanDB.Click += btnCleanDB_Click;
            // 
            // btnSeedDB
            // 
            btnSeedDB.Font = new Font("Segoe UI", 12F);
            btnSeedDB.Location = new Point(1010, 25);
            btnSeedDB.Name = "btnSeedDB";
            btnSeedDB.Size = new Size(143, 49);
            btnSeedDB.TabIndex = 3;
            btnSeedDB.Text = "Заполнить БД";
            btnSeedDB.UseVisualStyleBackColor = true;
            btnSeedDB.Click += btnSeedDB_Click;
            // 
            // ListProjectsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(btnSeedDB);
            Controls.Add(btnCleanDB);
            Controls.Add(listProjectsPanel);
            Controls.Add(btnListProjects);
            Name = "ListProjectsForm";
            Text = "Form1";
            Load += ListProjectsForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnListProjects;
        private FlowLayoutPanel listProjectsPanel;
        private Button btnCleanDB;
        private Button btnSeedDB;
    }
}

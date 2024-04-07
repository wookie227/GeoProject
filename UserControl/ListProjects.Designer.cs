namespace GeoProject
{
    partial class ListProjects
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            btnDetails = new Button();
            lblNameProject = new Label();
            lblDescProject = new Label();
            SuspendLayout();
            // 
            // btnDetails
            // 
            btnDetails.Font = new Font("Segoe UI", 17F);
            btnDetails.Location = new Point(474, 165);
            btnDetails.Name = "btnDetails";
            btnDetails.Size = new Size(224, 40);
            btnDetails.TabIndex = 0;
            btnDetails.Text = "Подробнее";
            btnDetails.UseVisualStyleBackColor = true;
            // 
            // lblNameProject
            // 
            lblNameProject.AutoSize = true;
            lblNameProject.Font = new Font("Segoe UI", 20F);
            lblNameProject.Location = new Point(30, 18);
            lblNameProject.Name = "lblNameProject";
            lblNameProject.Size = new Size(90, 37);
            lblNameProject.TabIndex = 1;
            lblNameProject.Text = "label1";
            // 
            // lblDescProject
            // 
            lblDescProject.AutoSize = true;
            lblDescProject.Font = new Font("Segoe UI", 17F);
            lblDescProject.Location = new Point(30, 62);
            lblDescProject.Name = "lblDescProject";
            lblDescProject.Size = new Size(76, 31);
            lblDescProject.TabIndex = 2;
            lblDescProject.Text = "label1";
            // 
            // ListProjects
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            Controls.Add(lblDescProject);
            Controls.Add(lblNameProject);
            Controls.Add(btnDetails);
            Margin = new Padding(0, 0, 10, 10);
            Name = "ListProjects";
            Size = new Size(1183, 221);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDetails;
        private Label lblNameProject;
        private Label lblDescProject;
    }
}

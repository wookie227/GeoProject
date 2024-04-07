namespace GeoProject
{
    partial class ListElectods
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
            lblNameElectrod = new Label();
            lblCoords = new Label();
            lblType = new Label();
            lblMeaning = new Label();
            lblDate = new Label();
            SuspendLayout();
            // 
            // lblNameElectrod
            // 
            lblNameElectrod.AutoSize = true;
            lblNameElectrod.Font = new Font("Segoe UI", 17F);
            lblNameElectrod.Location = new Point(15, 10);
            lblNameElectrod.Name = "lblNameElectrod";
            lblNameElectrod.Size = new Size(130, 31);
            lblNameElectrod.TabIndex = 0;
            lblNameElectrod.Text = "Электрод 1";
            // 
            // lblCoords
            // 
            lblCoords.AutoSize = true;
            lblCoords.Font = new Font("Segoe UI", 17F);
            lblCoords.Location = new Point(162, 10);
            lblCoords.Name = "lblCoords";
            lblCoords.Size = new Size(143, 31);
            lblCoords.TabIndex = 1;
            lblCoords.Text = "Координаты";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Font = new Font("Segoe UI", 17F);
            lblType.Location = new Point(323, 10);
            lblType.Name = "lblType";
            lblType.Size = new Size(165, 31);
            lblType.TabIndex = 2;
            lblType.Text = "Тип электрода";
            // 
            // lblMeaning
            // 
            lblMeaning.AutoSize = true;
            lblMeaning.Font = new Font("Segoe UI", 17F);
            lblMeaning.Location = new Point(444, 10);
            lblMeaning.Name = "lblMeaning";
            lblMeaning.Size = new Size(114, 31);
            lblMeaning.TabIndex = 3;
            lblMeaning.Text = "Значение";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 17F);
            lblDate.Location = new Point(580, 10);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(154, 31);
            lblDate.TabIndex = 4;
            lblDate.Text = "Дата и время";
            // 
            // ListElectods
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            Controls.Add(lblDate);
            Controls.Add(lblMeaning);
            Controls.Add(lblType);
            Controls.Add(lblCoords);
            Controls.Add(lblNameElectrod);
            Margin = new Padding(10);
            Name = "ListElectods";
            Size = new Size(791, 60);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNameElectrod;
        private Label lblCoords;
        private Label lblType;
        private Label lblMeaning;
        private Label lblDate;
    }
}

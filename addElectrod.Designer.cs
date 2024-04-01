namespace GeoProject
{
    partial class addElectrod
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
            label1 = new Label();
            txtElectrodCoords = new TextBox();
            txtTypeElectrod = new TextBox();
            txtValueElectrod = new TextBox();
            txtDate = new TextBox();
            btnAddElectrod = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(17, 9);
            label1.Name = "label1";
            label1.Size = new Size(255, 37);
            label1.TabIndex = 0;
            label1.Text = "Добавить электрод";
            // 
            // txtElectrodCoords
            // 
            txtElectrodCoords.Font = new Font("Segoe UI", 20F);
            txtElectrodCoords.Location = new Point(38, 72);
            txtElectrodCoords.Name = "txtElectrodCoords";
            txtElectrodCoords.PlaceholderText = "Координаты";
            txtElectrodCoords.Size = new Size(224, 43);
            txtElectrodCoords.TabIndex = 1;
            // 
            // txtTypeElectrod
            // 
            txtTypeElectrod.Font = new Font("Segoe UI", 20F);
            txtTypeElectrod.Location = new Point(38, 142);
            txtTypeElectrod.Name = "txtTypeElectrod";
            txtTypeElectrod.PlaceholderText = "Тип электрода";
            txtTypeElectrod.Size = new Size(224, 43);
            txtTypeElectrod.TabIndex = 2;
            // 
            // txtValueElectrod
            // 
            txtValueElectrod.Font = new Font("Segoe UI", 20F);
            txtValueElectrod.Location = new Point(38, 210);
            txtValueElectrod.Name = "txtValueElectrod";
            txtValueElectrod.PlaceholderText = "Значение";
            txtValueElectrod.Size = new Size(224, 43);
            txtValueElectrod.TabIndex = 3;
            // 
            // txtDate
            // 
            txtDate.Font = new Font("Segoe UI", 20F);
            txtDate.Location = new Point(39, 281);
            txtDate.Name = "txtDate";
            txtDate.PlaceholderText = "Дата и время";
            txtDate.Size = new Size(224, 43);
            txtDate.TabIndex = 4;
            // 
            // btnAddElectrod
            // 
            btnAddElectrod.Location = new Point(63, 330);
            btnAddElectrod.Name = "btnAddElectrod";
            btnAddElectrod.Size = new Size(168, 49);
            btnAddElectrod.TabIndex = 9;
            btnAddElectrod.Text = "ДОБАВИТЬ";
            btnAddElectrod.UseVisualStyleBackColor = true;
            btnAddElectrod.Click += btnAddElectrod_Click;
            // 
            // addElectrod
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 384);
            Controls.Add(btnAddElectrod);
            Controls.Add(txtDate);
            Controls.Add(txtValueElectrod);
            Controls.Add(txtTypeElectrod);
            Controls.Add(txtElectrodCoords);
            Controls.Add(label1);
            Name = "addElectrod";
            Text = "addElectrod";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtElectrodCoords;
        private TextBox txtTypeElectrod;
        private TextBox txtValueElectrod;
        private TextBox txtDate;
        private Button btnAddElectrod;
    }
}
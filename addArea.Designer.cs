namespace GeoProject
{
    partial class addArea
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
            txtAreaCoords = new TextBox();
            txtTypeArea = new TextBox();
            btnAddArea = new Button();
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
            label1.Text = "Добавить площадь";
            // 
            // txtAreaCoords
            // 
            txtAreaCoords.Font = new Font("Segoe UI", 20F);
            txtAreaCoords.Location = new Point(38, 64);
            txtAreaCoords.Name = "txtAreaCoords";
            txtAreaCoords.PlaceholderText = "Координаты";
            txtAreaCoords.Size = new Size(224, 43);
            txtAreaCoords.TabIndex = 1;
            // 
            // txtTypeArea
            // 
            txtTypeArea.Font = new Font("Segoe UI", 20F);
            txtTypeArea.Location = new Point(38, 126);
            txtTypeArea.Name = "txtTypeArea";
            txtTypeArea.PlaceholderText = "Тип площади";
            txtTypeArea.Size = new Size(224, 43);
            txtTypeArea.TabIndex = 2;
            // 
            // btnAddArea
            // 
            btnAddArea.Font = new Font("Segoe UI", 20F);
            btnAddArea.Location = new Point(57, 290);
            btnAddArea.Name = "btnAddArea";
            btnAddArea.Size = new Size(173, 59);
            btnAddArea.TabIndex = 3;
            btnAddArea.Text = "ДОБАВИТЬ";
            btnAddArea.UseVisualStyleBackColor = true;
            btnAddArea.Click += btnAddArea_Click;
            // 
            // addArea
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 361);
            Controls.Add(btnAddArea);
            Controls.Add(txtTypeArea);
            Controls.Add(txtAreaCoords);
            Controls.Add(label1);
            Name = "addArea";
            Text = "addArea";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtAreaCoords;
        private TextBox txtTypeArea;
        private Button btnAddArea;
    }
}
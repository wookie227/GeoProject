﻿namespace GeoProject
{
    partial class addProfile
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
            txtProfileCoords = new TextBox();
            btnAddProfile = new Button();
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
            label1.Text = "Добавить профиль";
            // 
            // txtProfileCoords
            // 
            txtProfileCoords.Font = new Font("Segoe UI", 20F);
            txtProfileCoords.Location = new Point(38, 64);
            txtProfileCoords.Name = "txtProfileCoords";
            txtProfileCoords.PlaceholderText = "Координаты";
            txtProfileCoords.Size = new Size(224, 43);
            txtProfileCoords.TabIndex = 1;
            // 
            // btnAddProfile
            // 
            btnAddProfile.Font = new Font("Segoe UI", 20F);
            btnAddProfile.Location = new Point(54, 290);
            btnAddProfile.Name = "btnAddProfile";
            btnAddProfile.Size = new Size(173, 59);
            btnAddProfile.TabIndex = 2;
            btnAddProfile.Text = "ДОБАВИТЬ";
            btnAddProfile.UseVisualStyleBackColor = true;
            btnAddProfile.Click += btnAddProfile_Click;
            // 
            // addProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 361);
            Controls.Add(btnAddProfile);
            Controls.Add(txtProfileCoords);
            Controls.Add(label1);
            Name = "addProfile";
            Text = "addProfile";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtProfileCoords;
        private Button btnAddProfile;
    }
}
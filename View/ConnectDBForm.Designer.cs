namespace GeoProject
{
    partial class ConnectDBForm
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
            txtDBName = new TextBox();
            btnConnect = new Button();
            txtServerName = new TextBox();
            SuspendLayout();
            // 
            // txtDBName
            // 
            txtDBName.Font = new Font("Segoe UI", 15F);
            txtDBName.Location = new Point(41, 117);
            txtDBName.Name = "txtDBName";
            txtDBName.PlaceholderText = "Название БД";
            txtDBName.Size = new Size(169, 34);
            txtDBName.TabIndex = 1;
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(67, 170);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(115, 49);
            btnConnect.TabIndex = 2;
            btnConnect.Text = "Подключиться";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // txtServerName
            // 
            txtServerName.Font = new Font("Segoe UI", 15F);
            txtServerName.Location = new Point(41, 59);
            txtServerName.Name = "txtServerName";
            txtServerName.PlaceholderText = "Название сервера";
            txtServerName.Size = new Size(169, 34);
            txtServerName.TabIndex = 3;
            // 
            // ConnectDBForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(253, 254);
            Controls.Add(txtServerName);
            Controls.Add(btnConnect);
            Controls.Add(txtDBName);
            Name = "ConnectDBForm";
            Text = "ConnectDBForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnConnect;
        public TextBox txtDBName;
        protected TextBox txtServerName;
    }
}
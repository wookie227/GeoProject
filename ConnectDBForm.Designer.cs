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
            comboBoxServers = new ComboBox();
            txtDBName = new TextBox();
            btnConnect = new Button();
            SuspendLayout();
            // 
            // comboBoxServers
            // 
            comboBoxServers.Font = new Font("Segoe UI", 15F);
            comboBoxServers.FormattingEnabled = true;
            comboBoxServers.Location = new Point(285, 127);
            comboBoxServers.Name = "comboBoxServers";
            comboBoxServers.Size = new Size(169, 36);
            comboBoxServers.TabIndex = 0;
            // 
            // txtDBName
            // 
            txtDBName.Font = new Font("Segoe UI", 15F);
            txtDBName.Location = new Point(285, 200);
            txtDBName.Name = "txtDBName";
            txtDBName.Size = new Size(169, 34);
            txtDBName.TabIndex = 1;
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(339, 260);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(75, 23);
            btnConnect.TabIndex = 2;
            btnConnect.Text = "button1";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // ConnectDBForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnConnect);
            Controls.Add(txtDBName);
            Controls.Add(comboBoxServers);
            Name = "ConnectDBForm";
            Text = "ConnectDBForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnConnect;
        public ComboBox comboBoxServers;
        public TextBox txtDBName;
    }
}
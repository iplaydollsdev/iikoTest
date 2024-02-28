namespace iikoTestServer
{
    partial class MainWindow
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
            this.responseLabel = new System.Windows.Forms.Label();
            this.sidebarPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.statusPanel = new System.Windows.Forms.Panel();
            this.loginLabel = new System.Windows.Forms.Label();
            this.loginImage = new System.Windows.Forms.PictureBox();
            this.logoutButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.taskButton1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.taskButton2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.taskButton3 = new System.Windows.Forms.Button();
            this.taskPanel1 = new System.Windows.Forms.Panel();
            this.taskButton4 = new System.Windows.Forms.Button();
            this.controlContainerPanel = new System.Windows.Forms.Panel();
            this.sidebarPanel.SuspendLayout();
            this.statusPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.taskPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // responseLabel
            // 
            this.responseLabel.AutoSize = true;
            this.responseLabel.Location = new System.Drawing.Point(429, 117);
            this.responseLabel.Name = "responseLabel";
            this.responseLabel.Size = new System.Drawing.Size(35, 13);
            this.responseLabel.TabIndex = 0;
            this.responseLabel.Text = "label1";
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.BackColor = System.Drawing.Color.Gray;
            this.sidebarPanel.Controls.Add(this.statusPanel);
            this.sidebarPanel.Controls.Add(this.panel1);
            this.sidebarPanel.Controls.Add(this.panel2);
            this.sidebarPanel.Controls.Add(this.panel3);
            this.sidebarPanel.Controls.Add(this.taskPanel1);
            this.sidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarPanel.Location = new System.Drawing.Point(0, 0);
            this.sidebarPanel.MinimumSize = new System.Drawing.Size(200, 600);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.Size = new System.Drawing.Size(200, 600);
            this.sidebarPanel.TabIndex = 5;
            // 
            // statusPanel
            // 
            this.statusPanel.BackColor = System.Drawing.Color.Transparent;
            this.statusPanel.Controls.Add(this.loginLabel);
            this.statusPanel.Controls.Add(this.loginImage);
            this.statusPanel.Controls.Add(this.logoutButton);
            this.statusPanel.Controls.Add(this.loginButton);
            this.statusPanel.Location = new System.Drawing.Point(0, 0);
            this.statusPanel.Margin = new System.Windows.Forms.Padding(0);
            this.statusPanel.Name = "statusPanel";
            this.statusPanel.Size = new System.Drawing.Size(200, 100);
            this.statusPanel.TabIndex = 0;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.ForeColor = System.Drawing.Color.White;
            this.loginLabel.Location = new System.Drawing.Point(38, 70);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(77, 16);
            this.loginLabel.TabIndex = 1;
            this.loginLabel.Text = "Logged Out";
            // 
            // loginImage
            // 
            this.loginImage.BackColor = System.Drawing.Color.Gray;
            this.loginImage.Image = global::iikoTestServer.Properties.Resources.redIcon;
            this.loginImage.Location = new System.Drawing.Point(12, 68);
            this.loginImage.Name = "loginImage";
            this.loginImage.Size = new System.Drawing.Size(20, 20);
            this.loginImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loginImage.TabIndex = 0;
            this.loginImage.TabStop = false;
            // 
            // logoutButton
            // 
            this.logoutButton.Enabled = false;
            this.logoutButton.FlatAppearance.BorderSize = 0;
            this.logoutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Image = global::iikoTestServer.Properties.Resources.logout;
            this.logoutButton.Location = new System.Drawing.Point(146, 12);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(40, 40);
            this.logoutButton.TabIndex = 11;
            this.logoutButton.TabStop = false;
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Enabled = false;
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Image = global::iikoTestServer.Properties.Resources.login;
            this.loginButton.Location = new System.Drawing.Point(12, 12);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(40, 40);
            this.loginButton.TabIndex = 10;
            this.loginButton.TabStop = false;
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.taskButton1);
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 50);
            this.panel1.TabIndex = 7;
            // 
            // taskButton1
            // 
            this.taskButton1.BackColor = System.Drawing.Color.Gray;
            this.taskButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.taskButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskButton1.FlatAppearance.BorderSize = 0;
            this.taskButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.taskButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.taskButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.taskButton1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.taskButton1.Image = global::iikoTestServer.Properties.Resources.entities;
            this.taskButton1.Location = new System.Drawing.Point(0, 0);
            this.taskButton1.Margin = new System.Windows.Forms.Padding(0);
            this.taskButton1.Name = "taskButton1";
            this.taskButton1.Size = new System.Drawing.Size(200, 50);
            this.taskButton1.TabIndex = 1;
            this.taskButton1.Text = "Task 1";
            this.taskButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.taskButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.taskButton1.UseVisualStyleBackColor = false;
            this.taskButton1.Click += new System.EventHandler(this.TaskButton1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.taskButton2);
            this.panel2.ForeColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(0, 150);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 50);
            this.panel2.TabIndex = 8;
            // 
            // taskButton2
            // 
            this.taskButton2.BackColor = System.Drawing.Color.Gray;
            this.taskButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.taskButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskButton2.FlatAppearance.BorderSize = 0;
            this.taskButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.taskButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.taskButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.taskButton2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.taskButton2.Image = global::iikoTestServer.Properties.Resources.product1;
            this.taskButton2.Location = new System.Drawing.Point(0, 0);
            this.taskButton2.Margin = new System.Windows.Forms.Padding(0);
            this.taskButton2.Name = "taskButton2";
            this.taskButton2.Size = new System.Drawing.Size(200, 50);
            this.taskButton2.TabIndex = 2;
            this.taskButton2.Text = "Task 2";
            this.taskButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.taskButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.taskButton2.UseVisualStyleBackColor = false;
            this.taskButton2.Click += new System.EventHandler(this.TaskButton2_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.taskButton3);
            this.panel3.ForeColor = System.Drawing.Color.Transparent;
            this.panel3.Location = new System.Drawing.Point(0, 200);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 50);
            this.panel3.TabIndex = 9;
            // 
            // taskButton3
            // 
            this.taskButton3.BackColor = System.Drawing.Color.Gray;
            this.taskButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.taskButton3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskButton3.FlatAppearance.BorderSize = 0;
            this.taskButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.taskButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.taskButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.taskButton3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.taskButton3.Image = global::iikoTestServer.Properties.Resources.employee;
            this.taskButton3.Location = new System.Drawing.Point(0, 0);
            this.taskButton3.Margin = new System.Windows.Forms.Padding(0);
            this.taskButton3.Name = "taskButton3";
            this.taskButton3.Size = new System.Drawing.Size(200, 50);
            this.taskButton3.TabIndex = 3;
            this.taskButton3.Text = "Task 3";
            this.taskButton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.taskButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.taskButton3.UseVisualStyleBackColor = false;
            this.taskButton3.Click += new System.EventHandler(this.TaskButton3_Click);
            // 
            // taskPanel1
            // 
            this.taskPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.taskPanel1.Controls.Add(this.taskButton4);
            this.taskPanel1.ForeColor = System.Drawing.Color.Transparent;
            this.taskPanel1.Location = new System.Drawing.Point(0, 250);
            this.taskPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.taskPanel1.Name = "taskPanel1";
            this.taskPanel1.Size = new System.Drawing.Size(200, 50);
            this.taskPanel1.TabIndex = 6;
            // 
            // taskButton4
            // 
            this.taskButton4.BackColor = System.Drawing.Color.Gray;
            this.taskButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.taskButton4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskButton4.FlatAppearance.BorderSize = 0;
            this.taskButton4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.taskButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.taskButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.taskButton4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.taskButton4.Image = global::iikoTestServer.Properties.Resources.recipe;
            this.taskButton4.Location = new System.Drawing.Point(0, 0);
            this.taskButton4.Margin = new System.Windows.Forms.Padding(0);
            this.taskButton4.Name = "taskButton4";
            this.taskButton4.Size = new System.Drawing.Size(200, 50);
            this.taskButton4.TabIndex = 4;
            this.taskButton4.Text = "Task 4";
            this.taskButton4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.taskButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.taskButton4.UseVisualStyleBackColor = false;
            this.taskButton4.Click += new System.EventHandler(this.TaskButton4_Click);
            // 
            // controlContainerPanel
            // 
            this.controlContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlContainerPanel.Location = new System.Drawing.Point(200, 0);
            this.controlContainerPanel.Name = "controlContainerPanel";
            this.controlContainerPanel.Size = new System.Drawing.Size(684, 561);
            this.controlContainerPanel.TabIndex = 6;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.controlContainerPanel);
            this.Controls.Add(this.sidebarPanel);
            this.Controls.Add(this.responseLabel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iikoTest";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.sidebarPanel.ResumeLayout(false);
            this.statusPanel.ResumeLayout(false);
            this.statusPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.taskPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label responseLabel;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.FlowLayoutPanel sidebarPanel;
        private System.Windows.Forms.Panel statusPanel;
        private System.Windows.Forms.PictureBox loginImage;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Panel taskPanel1;
        private System.Windows.Forms.Button taskButton4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button taskButton1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button taskButton2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button taskButton3;
        private System.Windows.Forms.Panel controlContainerPanel;
    }
}


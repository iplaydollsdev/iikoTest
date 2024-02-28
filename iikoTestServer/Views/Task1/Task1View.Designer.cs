namespace iikoTestServer.Views
{
    partial class Task1View
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.viewName = new System.Windows.Forms.Label();
            this.descripritionLabel = new System.Windows.Forms.Label();
            this.entitiesDropdown = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // viewName
            // 
            this.viewName.AutoSize = true;
            this.viewName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.viewName.Location = new System.Drawing.Point(25, 19);
            this.viewName.Name = "viewName";
            this.viewName.Size = new System.Drawing.Size(254, 25);
            this.viewName.TabIndex = 0;
            this.viewName.Text = "TASK 1 ENTITIES LIST";
            // 
            // descripritionLabel
            // 
            this.descripritionLabel.AutoSize = true;
            this.descripritionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descripritionLabel.Location = new System.Drawing.Point(27, 93);
            this.descripritionLabel.Name = "descripritionLabel";
            this.descripritionLabel.Size = new System.Drawing.Size(507, 20);
            this.descripritionLabel.TabIndex = 1;
            this.descripritionLabel.Text = "Cписок счетов, в которые можно создавать кастомные проводки";
            // 
            // entitiesDropdown
            // 
            this.entitiesDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.entitiesDropdown.FormattingEnabled = true;
            this.entitiesDropdown.Location = new System.Drawing.Point(30, 132);
            this.entitiesDropdown.Name = "entitiesDropdown";
            this.entitiesDropdown.Size = new System.Drawing.Size(301, 21);
            this.entitiesDropdown.TabIndex = 2;
            // 
            // Task1View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.entitiesDropdown);
            this.Controls.Add(this.descripritionLabel);
            this.Controls.Add(this.viewName);
            this.MinimumSize = new System.Drawing.Size(680, 560);
            this.Name = "Task1View";
            this.Size = new System.Drawing.Size(680, 560);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label viewName;
        private System.Windows.Forms.Label descripritionLabel;
        private System.Windows.Forms.ComboBox entitiesDropdown;
    }
}

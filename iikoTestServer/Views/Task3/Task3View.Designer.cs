namespace iikoTestServer.Views
{
    partial class Task3View
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
            this.oldSalaryLabel = new System.Windows.Forms.Label();
            this.oldSalaryText = new System.Windows.Forms.Label();
            this.newSalaryLabel = new System.Windows.Forms.Label();
            this.newSalaryInput = new System.Windows.Forms.TextBox();
            this.employeeIdText = new System.Windows.Forms.Label();
            this.setNewSalaryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // viewName
            // 
            this.viewName.AutoSize = true;
            this.viewName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.viewName.Location = new System.Drawing.Point(25, 19);
            this.viewName.Name = "viewName";
            this.viewName.Size = new System.Drawing.Size(208, 25);
            this.viewName.TabIndex = 0;
            this.viewName.Text = "TASK 3 SALARIES";
            // 
            // descripritionLabel
            // 
            this.descripritionLabel.AutoSize = true;
            this.descripritionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descripritionLabel.Location = new System.Drawing.Point(27, 93);
            this.descripritionLabel.Name = "descripritionLabel";
            this.descripritionLabel.Size = new System.Drawing.Size(115, 20);
            this.descripritionLabel.TabIndex = 1;
            this.descripritionLabel.Text = "Id сотрудника";
            // 
            // oldSalaryLabel
            // 
            this.oldSalaryLabel.AutoSize = true;
            this.oldSalaryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oldSalaryLabel.Location = new System.Drawing.Point(27, 172);
            this.oldSalaryLabel.Name = "oldSalaryLabel";
            this.oldSalaryLabel.Size = new System.Drawing.Size(140, 20);
            this.oldSalaryLabel.TabIndex = 3;
            this.oldSalaryLabel.Text = "Зарплата сейчас";
            // 
            // oldSalaryText
            // 
            this.oldSalaryText.AutoSize = true;
            this.oldSalaryText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oldSalaryText.Location = new System.Drawing.Point(27, 211);
            this.oldSalaryText.Name = "oldSalaryText";
            this.oldSalaryText.Size = new System.Drawing.Size(0, 20);
            this.oldSalaryText.TabIndex = 4;
            // 
            // newSalaryLabel
            // 
            this.newSalaryLabel.AutoSize = true;
            this.newSalaryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newSalaryLabel.Location = new System.Drawing.Point(26, 254);
            this.newSalaryLabel.Name = "newSalaryLabel";
            this.newSalaryLabel.Size = new System.Drawing.Size(133, 20);
            this.newSalaryLabel.TabIndex = 5;
            this.newSalaryLabel.Text = "Новая зарплата";
            // 
            // newSalaryInput
            // 
            this.newSalaryInput.Location = new System.Drawing.Point(30, 303);
            this.newSalaryInput.Name = "newSalaryInput";
            this.newSalaryInput.Size = new System.Drawing.Size(312, 20);
            this.newSalaryInput.TabIndex = 6;
            // 
            // employeeIdText
            // 
            this.employeeIdText.AutoSize = true;
            this.employeeIdText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.employeeIdText.Location = new System.Drawing.Point(27, 132);
            this.employeeIdText.Name = "employeeIdText";
            this.employeeIdText.Size = new System.Drawing.Size(0, 20);
            this.employeeIdText.TabIndex = 7;
            // 
            // setNewSalaryButton
            // 
            this.setNewSalaryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.setNewSalaryButton.Location = new System.Drawing.Point(30, 355);
            this.setNewSalaryButton.Name = "setNewSalaryButton";
            this.setNewSalaryButton.Size = new System.Drawing.Size(129, 30);
            this.setNewSalaryButton.TabIndex = 8;
            this.setNewSalaryButton.Text = "Установить";
            this.setNewSalaryButton.UseVisualStyleBackColor = true;
            this.setNewSalaryButton.Click += new System.EventHandler(this.SetNewSalaryButton_Click);
            // 
            // Task3View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.setNewSalaryButton);
            this.Controls.Add(this.employeeIdText);
            this.Controls.Add(this.newSalaryInput);
            this.Controls.Add(this.newSalaryLabel);
            this.Controls.Add(this.oldSalaryText);
            this.Controls.Add(this.oldSalaryLabel);
            this.Controls.Add(this.descripritionLabel);
            this.Controls.Add(this.viewName);
            this.MinimumSize = new System.Drawing.Size(680, 560);
            this.Name = "Task3View";
            this.Size = new System.Drawing.Size(680, 560);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label viewName;
        private System.Windows.Forms.Label descripritionLabel;
        private System.Windows.Forms.Label oldSalaryLabel;
        private System.Windows.Forms.Label oldSalaryText;
        private System.Windows.Forms.Label newSalaryLabel;
        private System.Windows.Forms.TextBox newSalaryInput;
        private System.Windows.Forms.Label employeeIdText;
        private System.Windows.Forms.Button setNewSalaryButton;
    }
}

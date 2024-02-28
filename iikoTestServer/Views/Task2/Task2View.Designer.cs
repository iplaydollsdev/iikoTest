namespace iikoTestServer.Views
{
    partial class Task2View
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
            this.productIdLabel = new System.Windows.Forms.Label();
            this.oldNameLabel = new System.Windows.Forms.Label();
            this.oldNameText = new System.Windows.Forms.Label();
            this.newSalaryLabel = new System.Windows.Forms.Label();
            this.newNameInput = new System.Windows.Forms.TextBox();
            this.productIdText = new System.Windows.Forms.Label();
            this.updateProductButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // viewName
            // 
            this.viewName.AutoSize = true;
            this.viewName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.viewName.Location = new System.Drawing.Point(25, 19);
            this.viewName.Name = "viewName";
            this.viewName.Size = new System.Drawing.Size(306, 25);
            this.viewName.TabIndex = 0;
            this.viewName.Text = "TASK 2 UPDATE PRODUCT";
            // 
            // productIdLabel
            // 
            this.productIdLabel.AutoSize = true;
            this.productIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productIdLabel.Location = new System.Drawing.Point(27, 93);
            this.productIdLabel.Name = "productIdLabel";
            this.productIdLabel.Size = new System.Drawing.Size(81, 20);
            this.productIdLabel.TabIndex = 1;
            this.productIdLabel.Text = "Id товара";
            // 
            // oldNameLabel
            // 
            this.oldNameLabel.AutoSize = true;
            this.oldNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oldNameLabel.Location = new System.Drawing.Point(27, 172);
            this.oldNameLabel.Name = "oldNameLabel";
            this.oldNameLabel.Size = new System.Drawing.Size(180, 20);
            this.oldNameLabel.TabIndex = 3;
            this.oldNameLabel.Text = "Наименование товара";
            // 
            // oldNameText
            // 
            this.oldNameText.AutoSize = true;
            this.oldNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oldNameText.Location = new System.Drawing.Point(27, 211);
            this.oldNameText.Name = "oldNameText";
            this.oldNameText.Size = new System.Drawing.Size(0, 20);
            this.oldNameText.TabIndex = 4;
            // 
            // newSalaryLabel
            // 
            this.newSalaryLabel.AutoSize = true;
            this.newSalaryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newSalaryLabel.Location = new System.Drawing.Point(26, 254);
            this.newSalaryLabel.Name = "newSalaryLabel";
            this.newSalaryLabel.Size = new System.Drawing.Size(229, 20);
            this.newSalaryLabel.TabIndex = 5;
            this.newSalaryLabel.Text = "Новое наименование товара";
            // 
            // newNameInput
            // 
            this.newNameInput.Location = new System.Drawing.Point(30, 303);
            this.newNameInput.Name = "newNameInput";
            this.newNameInput.Size = new System.Drawing.Size(312, 20);
            this.newNameInput.TabIndex = 6;
            this.newNameInput.TextChanged += new System.EventHandler(this.NewNameInput_TextChanged);
            // 
            // productIdText
            // 
            this.productIdText.AutoSize = true;
            this.productIdText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productIdText.Location = new System.Drawing.Point(27, 132);
            this.productIdText.Name = "productIdText";
            this.productIdText.Size = new System.Drawing.Size(0, 20);
            this.productIdText.TabIndex = 7;
            // 
            // updateProductButton
            // 
            this.updateProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateProductButton.Location = new System.Drawing.Point(30, 355);
            this.updateProductButton.Name = "updateProductButton";
            this.updateProductButton.Size = new System.Drawing.Size(129, 30);
            this.updateProductButton.TabIndex = 8;
            this.updateProductButton.Text = "Изменить";
            this.updateProductButton.UseVisualStyleBackColor = true;
            this.updateProductButton.Click += new System.EventHandler(this.UpdateProductButton_Click);
            // 
            // Task2View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.updateProductButton);
            this.Controls.Add(this.productIdText);
            this.Controls.Add(this.newNameInput);
            this.Controls.Add(this.newSalaryLabel);
            this.Controls.Add(this.oldNameText);
            this.Controls.Add(this.oldNameLabel);
            this.Controls.Add(this.productIdLabel);
            this.Controls.Add(this.viewName);
            this.MinimumSize = new System.Drawing.Size(680, 560);
            this.Name = "Task2View";
            this.Size = new System.Drawing.Size(680, 560);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label viewName;
        private System.Windows.Forms.Label productIdLabel;
        private System.Windows.Forms.Label oldNameLabel;
        private System.Windows.Forms.Label oldNameText;
        private System.Windows.Forms.Label newSalaryLabel;
        private System.Windows.Forms.TextBox newNameInput;
        private System.Windows.Forms.Label productIdText;
        private System.Windows.Forms.Button updateProductButton;
    }
}

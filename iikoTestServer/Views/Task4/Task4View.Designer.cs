namespace iikoTestServer.Views
{
    partial class Task4View
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
            this.recipeNameLabel = new System.Windows.Forms.Label();
            this.recipeNameText = new System.Windows.Forms.Label();
            this.ingredientsLabel = new System.Windows.Forms.Label();
            this.ingredientsListBox = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // viewName
            // 
            this.viewName.AutoSize = true;
            this.viewName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.viewName.Location = new System.Drawing.Point(25, 19);
            this.viewName.Name = "viewName";
            this.viewName.Size = new System.Drawing.Size(181, 25);
            this.viewName.TabIndex = 0;
            this.viewName.Text = "TASK 4 RECIPE";
            // 
            // recipeNameLabel
            // 
            this.recipeNameLabel.AutoSize = true;
            this.recipeNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.recipeNameLabel.Location = new System.Drawing.Point(27, 93);
            this.recipeNameLabel.Name = "recipeNameLabel";
            this.recipeNameLabel.Size = new System.Drawing.Size(158, 20);
            this.recipeNameLabel.TabIndex = 1;
            this.recipeNameLabel.Text = "Название продукта";
            // 
            // recipeNameText
            // 
            this.recipeNameText.AutoSize = true;
            this.recipeNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.recipeNameText.Location = new System.Drawing.Point(27, 139);
            this.recipeNameText.Name = "recipeNameText";
            this.recipeNameText.Size = new System.Drawing.Size(0, 20);
            this.recipeNameText.TabIndex = 2;
            // 
            // ingredientsLabel
            // 
            this.ingredientsLabel.AutoSize = true;
            this.ingredientsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ingredientsLabel.Location = new System.Drawing.Point(27, 170);
            this.ingredientsLabel.Name = "ingredientsLabel";
            this.ingredientsLabel.Size = new System.Drawing.Size(116, 20);
            this.ingredientsLabel.TabIndex = 3;
            this.ingredientsLabel.Text = "Ингредиенты:";
            // 
            // ingredientsListBox
            // 
            this.ingredientsListBox.HideSelection = false;
            this.ingredientsListBox.Location = new System.Drawing.Point(31, 211);
            this.ingredientsListBox.Name = "ingredientsListBox";
            this.ingredientsListBox.Size = new System.Drawing.Size(314, 319);
            this.ingredientsListBox.TabIndex = 4;
            this.ingredientsListBox.UseCompatibleStateImageBehavior = false;
            // 
            // Task4View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.ingredientsListBox);
            this.Controls.Add(this.ingredientsLabel);
            this.Controls.Add(this.recipeNameText);
            this.Controls.Add(this.recipeNameLabel);
            this.Controls.Add(this.viewName);
            this.MinimumSize = new System.Drawing.Size(680, 560);
            this.Name = "Task4View";
            this.Size = new System.Drawing.Size(680, 560);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label viewName;
        private System.Windows.Forms.Label recipeNameLabel;
        private System.Windows.Forms.Label recipeNameText;
        private System.Windows.Forms.Label ingredientsLabel;
        private System.Windows.Forms.ListView ingredientsListBox;
    }
}

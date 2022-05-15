namespace ModelSystemRPG
{
    partial class ListItem
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnShowProperties = new System.Windows.Forms.Button();
            this.txtModel = new System.Windows.Forms.Label();
            this.btnCategory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(498, 9);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(86, 41);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(590, 9);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 41);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnShowProperties
            // 
            this.btnShowProperties.Location = new System.Drawing.Point(267, 15);
            this.btnShowProperties.Name = "btnShowProperties";
            this.btnShowProperties.Size = new System.Drawing.Size(158, 28);
            this.btnShowProperties.TabIndex = 3;
            this.btnShowProperties.Text = "Properties";
            this.btnShowProperties.UseVisualStyleBackColor = true;
            // 
            // txtModel
            // 
            this.txtModel.AutoSize = true;
            this.txtModel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtModel.Location = new System.Drawing.Point(152, 18);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(53, 20);
            this.txtModel.TabIndex = 4;
            this.txtModel.Text = "Model";
            // 
            // btnCategory
            // 
            this.btnCategory.Location = new System.Drawing.Point(23, 16);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(71, 26);
            this.btnCategory.TabIndex = 5;
            this.btnCategory.Text = "Kategoria";
            this.btnCategory.UseVisualStyleBackColor = true;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // ListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCategory);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.btnShowProperties);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Name = "ListItem";
            this.Size = new System.Drawing.Size(693, 59);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnEdit;
        private Button btnDelete;
        private Button btnShowProperties;
        private Label txtModel;
        private Button btnCategory;
    }
}

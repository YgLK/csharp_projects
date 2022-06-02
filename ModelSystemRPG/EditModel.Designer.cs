namespace ModelSystemRPG
{
    partial class EditModel
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRemove = new System.Windows.Forms.Button();
            this.txtPropValue1 = new System.Windows.Forms.TextBox();
            this.txtPropName1 = new System.Windows.Forms.TextBox();
            this.hCategory = new System.Windows.Forms.Label();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.hModel = new System.Windows.Forms.Label();
            this.lblModelName = new System.Windows.Forms.Label();
            this.lblProperty = new System.Windows.Forms.Label();
            this.lblPValue = new System.Windows.Forms.Label();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAddProp = new System.Windows.Forms.Button();
            this.lblLoggedInUsername = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.53374F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.46626F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(136, 183);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.Size = new System.Drawing.Size(739, 278);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(618, 3);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(118, 30);
            this.btnRemove.TabIndex = 11;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // txtPropValue1
            // 
            this.txtPropValue1.Location = new System.Drawing.Point(320, 3);
            this.txtPropValue1.Name = "txtPropValue1";
            this.txtPropValue1.Size = new System.Drawing.Size(292, 23);
            this.txtPropValue1.TabIndex = 1;
            this.txtPropValue1.Text = "czesc";
            this.txtPropValue1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPropName1
            // 
            this.txtPropName1.Location = new System.Drawing.Point(3, 3);
            this.txtPropName1.Name = "txtPropName1";
            this.txtPropName1.Size = new System.Drawing.Size(311, 23);
            this.txtPropName1.TabIndex = 0;
            this.txtPropName1.Text = "czesc";
            this.txtPropName1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // hCategory
            // 
            this.hCategory.AutoSize = true;
            this.hCategory.Location = new System.Drawing.Point(96, 67);
            this.hCategory.Name = "hCategory";
            this.hCategory.Size = new System.Drawing.Size(58, 15);
            this.hCategory.TabIndex = 2;
            this.hCategory.Text = "Category:";
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Location = new System.Drawing.Point(252, 67);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(58, 15);
            this.lblCategoryName.TabIndex = 3;
            this.lblCategoryName.Text = "_category";
            // 
            // hModel
            // 
            this.hModel.AutoSize = true;
            this.hModel.Location = new System.Drawing.Point(96, 34);
            this.hModel.Name = "hModel";
            this.hModel.Size = new System.Drawing.Size(44, 15);
            this.hModel.TabIndex = 4;
            this.hModel.Text = "Model:";
            // 
            // lblModelName
            // 
            this.lblModelName.AutoSize = true;
            this.lblModelName.Location = new System.Drawing.Point(252, 34);
            this.lblModelName.Name = "lblModelName";
            this.lblModelName.Size = new System.Drawing.Size(46, 15);
            this.lblModelName.TabIndex = 5;
            this.lblModelName.Text = "_model";
            // 
            // lblProperty
            // 
            this.lblProperty.AutoSize = true;
            this.lblProperty.Location = new System.Drawing.Point(269, 153);
            this.lblProperty.Name = "lblProperty";
            this.lblProperty.Size = new System.Drawing.Size(52, 15);
            this.lblProperty.TabIndex = 6;
            this.lblProperty.Text = "Property";
            // 
            // lblPValue
            // 
            this.lblPValue.AutoSize = true;
            this.lblPValue.Location = new System.Drawing.Point(582, 153);
            this.lblPValue.Name = "lblPValue";
            this.lblPValue.Size = new System.Drawing.Size(35, 15);
            this.lblPValue.TabIndex = 7;
            this.lblPValue.Text = "Value";
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(737, 487);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(89, 37);
            this.btnSaveChanges.TabIndex = 8;
            this.btnSaveChanges.Text = "Save changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(862, 487);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(91, 37);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAddProp
            // 
            this.btnAddProp.Location = new System.Drawing.Point(911, 185);
            this.btnAddProp.Name = "btnAddProp";
            this.btnAddProp.Size = new System.Drawing.Size(42, 31);
            this.btnAddProp.TabIndex = 10;
            this.btnAddProp.Text = "+";
            this.btnAddProp.UseVisualStyleBackColor = true;
            this.btnAddProp.Click += new System.EventHandler(this.btnAddProp_Click);
            // 
            // lblLoggedInUsername
            // 
            this.lblLoggedInUsername.AutoSize = true;
            this.lblLoggedInUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLoggedInUsername.Location = new System.Drawing.Point(988, 4);
            this.lblLoggedInUsername.Name = "lblLoggedInUsername";
            this.lblLoggedInUsername.Size = new System.Drawing.Size(84, 21);
            this.lblLoggedInUsername.TabIndex = 15;
            this.lblLoggedInUsername.Text = "Unknown";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(876, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Logged in as:";
            // 
            // EditModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 557);
            this.Controls.Add(this.lblLoggedInUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddProp);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.lblPValue);
            this.Controls.Add(this.lblProperty);
            this.Controls.Add(this.lblModelName);
            this.Controls.Add(this.hModel);
            this.Controls.Add(this.lblCategoryName);
            this.Controls.Add(this.hCategory);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EditModel";
            this.Text = "Edit model properties";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lblCategory;
        private Label label2;
        private Label lblModelName;
        private Label label4;
        private Label lblProperty;
        private Label lblPValue;
        private Button btnSaveChanges;
        private Button btnBack;
        private Button btnAddProp;
        private Button btnRemove;
        private TextBox txtPropValue1;
        private TextBox txtPropName1;
        private Label hCategory;
        private Label lblCategoryName;
        private Label hModelName;
        private Label hModel;
        private Label lblLoggedInUsername;
        private Label label3;
    }
}
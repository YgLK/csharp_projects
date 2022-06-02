namespace ModelSystemRPG
{
    partial class AddCategory
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
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.txtCategoryDescription = new System.Windows.Forms.TextBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelHeader = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblLoggedInUsername = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddProperty = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDefCatProp = new System.Windows.Forms.Label();
            this.cboxEnvironment = new System.Windows.Forms.ComboBox();
            this.lblEnv = new System.Windows.Forms.Label();
            this.txtNewEnvName = new System.Windows.Forms.TextBox();
            this.lblNewEnvName = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(539, 161);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(232, 23);
            this.txtCategoryName.TabIndex = 0;
            // 
            // txtCategoryDescription
            // 
            this.txtCategoryDescription.Location = new System.Drawing.Point(539, 190);
            this.txtCategoryDescription.Name = "txtCategoryDescription";
            this.txtCategoryDescription.Size = new System.Drawing.Size(232, 23);
            this.txtCategoryDescription.TabIndex = 1;
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(372, 164);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(91, 15);
            this.labelCategory.TabIndex = 2;
            this.labelCategory.Text = "Category name:";
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Location = new System.Drawing.Point(603, 32);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(105, 15);
            this.labelHeader.TabIndex = 3;
            this.labelHeader.Text = "Add new Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(371, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Category description:";
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(497, 555);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(182, 35);
            this.btnAddCategory.TabIndex = 5;
            this.btnAddCategory.Text = "CONFIRM";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(497, 596);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(182, 35);
            this.btnBack.TabIndex = 25;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblLoggedInUsername
            // 
            this.lblLoggedInUsername.AutoSize = true;
            this.lblLoggedInUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLoggedInUsername.Location = new System.Drawing.Point(1042, 4);
            this.lblLoggedInUsername.Name = "lblLoggedInUsername";
            this.lblLoggedInUsername.Size = new System.Drawing.Size(84, 21);
            this.lblLoggedInUsername.TabIndex = 27;
            this.lblLoggedInUsername.Text = "Unknown";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(930, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 26;
            this.label3.Text = "Logged in as:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(421, 302);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(536, 236);
            this.flowLayoutPanel1.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(822, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 35;
            this.label4.Text = "Type";
            this.label4.Visible = false;
            // 
            // btnAddProperty
            // 
            this.btnAddProperty.Location = new System.Drawing.Point(380, 302);
            this.btnAddProperty.Name = "btnAddProperty";
            this.btnAddProperty.Size = new System.Drawing.Size(35, 23);
            this.btnAddProperty.TabIndex = 34;
            this.btnAddProperty.Text = "+";
            this.btnAddProperty.UseVisualStyleBackColor = true;
            this.btnAddProperty.Click += new System.EventHandler(this.btnAddProperty_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(477, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 33;
            this.label2.Text = "Property name";
            // 
            // lblDefCatProp
            // 
            this.lblDefCatProp.AutoSize = true;
            this.lblDefCatProp.Location = new System.Drawing.Point(579, 255);
            this.lblDefCatProp.Name = "lblDefCatProp";
            this.lblDefCatProp.Size = new System.Drawing.Size(150, 15);
            this.lblDefCatProp.TabIndex = 32;
            this.lblDefCatProp.Text = "Default category properties";
            // 
            // cboxEnvironment
            // 
            this.cboxEnvironment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxEnvironment.FormattingEnabled = true;
            this.cboxEnvironment.Location = new System.Drawing.Point(539, 53);
            this.cboxEnvironment.Name = "cboxEnvironment";
            this.cboxEnvironment.Size = new System.Drawing.Size(232, 23);
            this.cboxEnvironment.TabIndex = 37;
            // 
            // lblEnv
            // 
            this.lblEnv.AutoSize = true;
            this.lblEnv.Location = new System.Drawing.Point(371, 53);
            this.lblEnv.Name = "lblEnv";
            this.lblEnv.Size = new System.Drawing.Size(75, 15);
            this.lblEnv.TabIndex = 38;
            this.lblEnv.Text = "Environment";
            // 
            // txtNewEnvName
            // 
            this.txtNewEnvName.Location = new System.Drawing.Point(539, 118);
            this.txtNewEnvName.Name = "txtNewEnvName";
            this.txtNewEnvName.Size = new System.Drawing.Size(232, 23);
            this.txtNewEnvName.TabIndex = 39;
            // 
            // lblNewEnvName
            // 
            this.lblNewEnvName.AutoSize = true;
            this.lblNewEnvName.Location = new System.Drawing.Point(371, 121);
            this.lblNewEnvName.Name = "lblNewEnvName";
            this.lblNewEnvName.Size = new System.Drawing.Size(135, 15);
            this.lblNewEnvName.TabIndex = 40;
            this.lblNewEnvName.Text = "New environment name";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(541, 79);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(156, 19);
            this.checkBox1.TabIndex = 41;
            this.checkBox1.Text = "Create new environment";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // AddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 668);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lblNewEnvName);
            this.Controls.Add(this.txtNewEnvName);
            this.Controls.Add(this.lblEnv);
            this.Controls.Add(this.cboxEnvironment);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAddProperty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDefCatProp);
            this.Controls.Add(this.lblLoggedInUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.txtCategoryDescription);
            this.Controls.Add(this.txtCategoryName);
            this.Name = "AddCategory";
            this.Text = "Add new category";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtCategoryName;
        private TextBox txtCategoryDescription;
        private Label labelCategory;
        private Label labelHeader;
        private Label label1;
        private Button btnAddCategory;
        private Button btnBack;
        private Label lblLoggedInUsername;
        private Label label3;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label4;
        private Button btnAddProperty;
        private Label label2;
        private Label lblDefCatProp;
        private ComboBox cboxEnvironment;
        private Label lblEnv;
        private TextBox txtNewEnvName;
        private Label lblNewEnvName;
        private CheckBox checkBox1;
    }
}
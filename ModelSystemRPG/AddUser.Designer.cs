namespace ModelSystemRPG
{
    partial class AddUser
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
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelHeader = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.txtCategoryDescription = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(511, 321);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(182, 35);
            this.btnAddCategory.TabIndex = 18;
            this.btnAddCategory.Text = "CONFIRM";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(367, 196);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(30, 15);
            this.labelName.TabIndex = 17;
            this.labelName.Text = "Role";
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Location = new System.Drawing.Point(562, 66);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(80, 15);
            this.labelHeader.TabIndex = 16;
            this.labelHeader.Text = "Add new User";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(367, 167);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(60, 15);
            this.labelUser.TabIndex = 15;
            this.labelUser.Text = "Username";
            // 
            // txtCategoryDescription
            // 
            this.txtCategoryDescription.Location = new System.Drawing.Point(547, 193);
            this.txtCategoryDescription.Name = "txtCategoryDescription";
            this.txtCategoryDescription.Size = new System.Drawing.Size(230, 23);
            this.txtCategoryDescription.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(547, 164);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(230, 23);
            this.textBox1.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(367, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "Email";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(547, 222);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(230, 23);
            this.textBox2.TabIndex = 22;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(511, 362);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(182, 35);
            this.btnBack.TabIndex = 24;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 668);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.txtCategoryDescription);
            this.Name = "AddUser";
            this.Text = "Add new User";
            this.Load += new System.EventHandler(this.AddUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnAddCategory;
        private Label labelName;
        private Label labelHeader;
        private Label labelUser;
        private TextBox txtCategoryDescription;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Button btnBack;
    }
}
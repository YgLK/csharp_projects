namespace ModelSystemRPG
{
    partial class ManageUsers
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.cboxDelUser = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRepeatPassword = new System.Windows.Forms.TextBox();
            this.checkListBoxDelCategories = new System.Windows.Forms.CheckedListBox();
            this.btnDeleteCategories = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(193, 390);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(153, 43);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(193, 349);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(153, 32);
            this.btnDeleteUser.TabIndex = 1;
            this.btnDeleteUser.Text = "DELETE USER";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // cboxDelUser
            // 
            this.cboxDelUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxDelUser.FormattingEnabled = true;
            this.cboxDelUser.Location = new System.Drawing.Point(160, 63);
            this.cboxDelUser.Name = "cboxDelUser";
            this.cboxDelUser.Size = new System.Drawing.Size(248, 23);
            this.cboxDelUser.TabIndex = 2;
            this.cboxDelUser.SelectedIndexChanged += new System.EventHandler(this.cboxDelUser_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose user to manage";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(160, 108);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(248, 23);
            this.comboBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Change role";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(160, 170);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(248, 23);
            this.txtNewPassword.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Change password";
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(193, 298);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(153, 45);
            this.btnSaveChanges.TabIndex = 8;
            this.btnSaveChanges.Text = "SAVE CHANGES";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Set new password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Repeat password";
            // 
            // txtRepeatPassword
            // 
            this.txtRepeatPassword.Location = new System.Drawing.Point(160, 210);
            this.txtRepeatPassword.Name = "txtRepeatPassword";
            this.txtRepeatPassword.Size = new System.Drawing.Size(248, 23);
            this.txtRepeatPassword.TabIndex = 10;
            // 
            // checkListBoxDelCategories
            // 
            this.checkListBoxDelCategories.FormattingEnabled = true;
            this.checkListBoxDelCategories.Location = new System.Drawing.Point(540, 63);
            this.checkListBoxDelCategories.Name = "checkListBoxDelCategories";
            this.checkListBoxDelCategories.Size = new System.Drawing.Size(207, 220);
            this.checkListBoxDelCategories.TabIndex = 12;
            // 
            // btnDeleteCategories
            // 
            this.btnDeleteCategories.Location = new System.Drawing.Point(540, 308);
            this.btnDeleteCategories.Name = "btnDeleteCategories";
            this.btnDeleteCategories.Size = new System.Drawing.Size(207, 35);
            this.btnDeleteCategories.TabIndex = 13;
            this.btnDeleteCategories.Text = "DELETE CATEGORIES";
            this.btnDeleteCategories.UseVisualStyleBackColor = true;
            this.btnDeleteCategories.Click += new System.EventHandler(this.btnDeleteCategories_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(561, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Choose categories to delete";
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDeleteCategories);
            this.Controls.Add(this.checkListBoxDelCategories);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRepeatPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboxDelUser);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.btnBack);
            this.Name = "ManageUsers";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnExit;
        private Button btnDeleteUser;
        private ComboBox cboxDelUser;
        private Label label1;
        private Button btnBack;
        private ComboBox comboBox1;
        private Label label2;
        private TextBox txtNewPassword;
        private Label label3;
        private Button btnSaveChanges;
        private Label label4;
        private Label label5;
        private TextBox txtRepeatPassword;
        private CheckedListBox checkListBoxDelCategories;
        private Button btnDeleteCategories;
        private Label label6;
    }
}
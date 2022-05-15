namespace ModelSystemRPG
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddModel = new System.Windows.Forms.Button();
            this.btnCatalog = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddCategory.AutoSize = true;
            this.btnAddCategory.Location = new System.Drawing.Point(276, 146);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(590, 56);
            this.btnAddCategory.TabIndex = 0;
            this.btnAddCategory.Text = "ADD NEW CATEGORY";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExit.AutoSize = true;
            this.btnExit.Location = new System.Drawing.Point(276, 482);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(590, 56);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "BACK";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddModel
            // 
            this.btnAddModel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddModel.AutoSize = true;
            this.btnAddModel.Location = new System.Drawing.Point(276, 220);
            this.btnAddModel.Name = "btnAddModel";
            this.btnAddModel.Size = new System.Drawing.Size(590, 56);
            this.btnAddModel.TabIndex = 2;
            this.btnAddModel.Text = "ADD NEW MODEL";
            this.btnAddModel.UseVisualStyleBackColor = true;
            this.btnAddModel.Click += new System.EventHandler(this.btnAddModel_Click);
            // 
            // btnCatalog
            // 
            this.btnCatalog.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCatalog.AutoSize = true;
            this.btnCatalog.Location = new System.Drawing.Point(276, 70);
            this.btnCatalog.Name = "btnCatalog";
            this.btnCatalog.Size = new System.Drawing.Size(590, 56);
            this.btnCatalog.TabIndex = 3;
            this.btnCatalog.Text = "CATALOG";
            this.btnCatalog.UseVisualStyleBackColor = true;
            this.btnCatalog.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(53, 42);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 4;
            this.btnTest.Text = "TestButton";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(276, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(590, 71);
            this.button1.TabIndex = 5;
            this.button1.Text = "new_user_add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(552, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "TEST";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 668);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnCatalog);
            this.Controls.Add(this.btnAddModel);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddCategory);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAddCategory;
        private Button btnExit;
        private Button btnAddModel;
        private Button btnCatalog;
        private Button btnTest;
        private Button btnAddUser;
        private Button button1;
        private Label label1;
    }
}
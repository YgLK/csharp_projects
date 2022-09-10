namespace WeekSchedulerControl
{
    partial class AddTask
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
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxPriority = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbStart = new System.Windows.Forms.ComboBox();
            this.cbbEnd = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTaskDescription = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBoxCustomPriority = new System.Windows.Forms.CheckBox();
            this.txtNewPriority = new System.Windows.Forms.TextBox();
            this.lblNewPriority = new System.Windows.Forms.Label();
            this.btnColourChoose = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // txtTaskName
            // 
            this.txtTaskName.Location = new System.Drawing.Point(310, 64);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(204, 23);
            this.txtTaskName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(160, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Task name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Add new Task";
            // 
            // cbxPriority
            // 
            this.cbxPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPriority.FormattingEnabled = true;
            this.cbxPriority.Location = new System.Drawing.Point(310, 141);
            this.cbxPriority.Name = "cbxPriority";
            this.cbxPriority.Size = new System.Drawing.Size(204, 23);
            this.cbxPriority.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(160, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Priority";
            // 
            // datePicker
            // 
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(310, 307);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(204, 23);
            this.datePicker.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(160, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Pick a date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(160, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Start time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(160, 391);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "End time";
            // 
            // cbbStart
            // 
            this.cbbStart.FormattingEnabled = true;
            this.cbbStart.Location = new System.Drawing.Point(310, 352);
            this.cbbStart.Name = "cbbStart";
            this.cbbStart.Size = new System.Drawing.Size(204, 23);
            this.cbbStart.TabIndex = 9;
            // 
            // cbbEnd
            // 
            this.cbbEnd.FormattingEnabled = true;
            this.cbbEnd.Location = new System.Drawing.Point(310, 389);
            this.cbbEnd.Name = "cbbEnd";
            this.cbbEnd.Size = new System.Drawing.Size(204, 23);
            this.cbbEnd.TabIndex = 10;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(232, 446);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(134, 36);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(160, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "Task description";
            // 
            // txtTaskDescription
            // 
            this.txtTaskDescription.Location = new System.Drawing.Point(310, 103);
            this.txtTaskDescription.Name = "txtTaskDescription";
            this.txtTaskDescription.Size = new System.Drawing.Size(204, 23);
            this.txtTaskDescription.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(400, 446);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 36);
            this.button1.TabIndex = 14;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBoxCustomPriority
            // 
            this.checkBoxCustomPriority.AutoSize = true;
            this.checkBoxCustomPriority.Location = new System.Drawing.Point(310, 170);
            this.checkBoxCustomPriority.Name = "checkBoxCustomPriority";
            this.checkBoxCustomPriority.Size = new System.Drawing.Size(132, 19);
            this.checkBoxCustomPriority.TabIndex = 15;
            this.checkBoxCustomPriority.Text = "Add custom priority";
            this.checkBoxCustomPriority.UseVisualStyleBackColor = true;
            this.checkBoxCustomPriority.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtNewPriority
            // 
            this.txtNewPriority.Location = new System.Drawing.Point(310, 214);
            this.txtNewPriority.Name = "txtNewPriority";
            this.txtNewPriority.Size = new System.Drawing.Size(204, 23);
            this.txtNewPriority.TabIndex = 16;
            // 
            // lblNewPriority
            // 
            this.lblNewPriority.AutoSize = true;
            this.lblNewPriority.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNewPriority.Location = new System.Drawing.Point(338, 198);
            this.lblNewPriority.Name = "lblNewPriority";
            this.lblNewPriority.Size = new System.Drawing.Size(132, 13);
            this.lblNewPriority.TabIndex = 17;
            this.lblNewPriority.Text = "Enter new priority name";
            // 
            // btnColourChoose
            // 
            this.btnColourChoose.Location = new System.Drawing.Point(310, 254);
            this.btnColourChoose.Name = "btnColourChoose";
            this.btnColourChoose.Size = new System.Drawing.Size(204, 30);
            this.btnColourChoose.TabIndex = 18;
            this.btnColourChoose.Text = "Choose colouring";
            this.btnColourChoose.UseVisualStyleBackColor = true;
            this.btnColourChoose.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 513);
            this.Controls.Add(this.btnColourChoose);
            this.Controls.Add(this.lblNewPriority);
            this.Controls.Add(this.txtNewPriority);
            this.Controls.Add(this.checkBoxCustomPriority);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTaskDescription);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cbbEnd);
            this.Controls.Add(this.cbbStart);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxPriority);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTaskName);
            this.Name = "AddTask";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtTaskName;
        private Label label1;
        private Label label2;
        private ComboBox cbxPriority;
        private Label label3;
        private DateTimePicker datePicker;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox cbbStart;
        private ComboBox cbbEnd;
        private Button btnSubmit;
        private Label label7;
        private TextBox txtTaskDescription;
        private Button button1;
        private CheckBox checkBox1;
        private TextBox txtNewPriority;
        private Label lblNewPriority;
        private Button btnColourChoose;
        private ColorDialog colorDialog1;
        private CheckBox checkBoxCustomPriority;
    }
}
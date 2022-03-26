namespace CarDealership
{
    partial class BookTestDriveForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.availableCarLabel = new System.Windows.Forms.Label();
            this.carImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.nameEnterLabel = new System.Windows.Forms.Label();
            this.enterNameTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.carImage)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(243, 106);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(249, 24);
            this.listBox1.TabIndex = 0;
            // 
            // availableCarLabel
            // 
            this.availableCarLabel.AutoSize = true;
            this.availableCarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.availableCarLabel.Location = new System.Drawing.Point(23, 106);
            this.availableCarLabel.Name = "availableCarLabel";
            this.availableCarLabel.Size = new System.Drawing.Size(185, 24);
            this.availableCarLabel.TabIndex = 24;
            this.availableCarLabel.Text = "Choose available car";
            // 
            // carImage
            // 
            this.carImage.Location = new System.Drawing.Point(547, 106);
            this.carImage.Name = "carImage";
            this.carImage.Size = new System.Drawing.Size(204, 163);
            this.carImage.TabIndex = 25;
            this.carImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(23, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "Pick convenient date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(264, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 36);
            this.label2.TabIndex = 27;
            this.label2.Text = "Test drive reservation";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker1.Location = new System.Drawing.Point(243, 165);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(249, 26);
            this.dateTimePicker1.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(612, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 38);
            this.button1.TabIndex = 29;
            this.button1.Text = "ADD NEW RESERVATION";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(431, 370);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 38);
            this.button2.TabIndex = 30;
            this.button2.Text = "SHOW RESERVATION LIST";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // nameEnterLabel
            // 
            this.nameEnterLabel.AutoSize = true;
            this.nameEnterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameEnterLabel.Location = new System.Drawing.Point(22, 224);
            this.nameEnterLabel.Name = "nameEnterLabel";
            this.nameEnterLabel.Size = new System.Drawing.Size(139, 24);
            this.nameEnterLabel.TabIndex = 31;
            this.nameEnterLabel.Text = "Enter the name";
            // 
            // enterNameTextBox
            // 
            this.enterNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.enterNameTextBox.Location = new System.Drawing.Point(243, 224);
            this.enterNameTextBox.Name = "enterNameTextBox";
            this.enterNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.enterNameTextBox.Size = new System.Drawing.Size(249, 26);
            this.enterNameTextBox.TabIndex = 32;
            this.enterNameTextBox.Text = "John Doe";
            // 
            // BookTestDriveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.enterNameTextBox);
            this.Controls.Add(this.nameEnterLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.carImage);
            this.Controls.Add(this.availableCarLabel);
            this.Controls.Add(this.listBox1);
            this.Name = "BookTestDriveForm";
            this.Text = "Book the test drive";
            ((System.ComponentModel.ISupportInitialize)(this.carImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label availableCarLabel;
        private System.Windows.Forms.PictureBox carImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label nameEnterLabel;
        private System.Windows.Forms.TextBox enterNameTextBox;
    }
}
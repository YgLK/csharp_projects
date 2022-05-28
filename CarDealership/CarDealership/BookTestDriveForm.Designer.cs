namespace CarDealership
{
    partial class btnRemoveRes
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnAddReservation = new System.Windows.Forms.Button();
            this.showReservations = new System.Windows.Forms.Button();
            this.nameEnterLabel = new System.Windows.Forms.Label();
            this.enterNameTextBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.colorComboBox = new System.Windows.Forms.ComboBox();
            this.engineComboBox = new System.Windows.Forms.ComboBox();
            this.carModelComboBox = new System.Windows.Forms.ComboBox();
            this.carMakeComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.carModel = new System.Windows.Forms.Label();
            this.carBrand = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(48, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "Pick convenient date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(217, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 36);
            this.label2.TabIndex = 27;
            this.label2.Text = "Test drive reservation";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker1.Location = new System.Drawing.Point(247, 345);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(206, 26);
            this.dateTimePicker1.TabIndex = 28;
            // 
            // btnAddReservation
            // 
            this.btnAddReservation.Location = new System.Drawing.Point(314, 470);
            this.btnAddReservation.Name = "btnAddReservation";
            this.btnAddReservation.Size = new System.Drawing.Size(139, 38);
            this.btnAddReservation.TabIndex = 29;
            this.btnAddReservation.Text = "ADD NEW RESERVATION";
            this.btnAddReservation.UseVisualStyleBackColor = true;
            this.btnAddReservation.Click += new System.EventHandler(this.btnAddReservation_Click);
            // 
            // showReservations
            // 
            this.showReservations.Enabled = false;
            this.showReservations.Location = new System.Drawing.Point(499, 492);
            this.showReservations.Name = "showReservations";
            this.showReservations.Size = new System.Drawing.Size(145, 38);
            this.showReservations.TabIndex = 30;
            this.showReservations.Text = "SHOW RESERVATION LIST";
            this.showReservations.UseVisualStyleBackColor = true;
            this.showReservations.Visible = false;
            this.showReservations.Click += new System.EventHandler(this.showReservations_Click);
            // 
            // nameEnterLabel
            // 
            this.nameEnterLabel.AutoSize = true;
            this.nameEnterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameEnterLabel.Location = new System.Drawing.Point(48, 397);
            this.nameEnterLabel.Name = "nameEnterLabel";
            this.nameEnterLabel.Size = new System.Drawing.Size(150, 24);
            this.nameEnterLabel.TabIndex = 31;
            this.nameEnterLabel.Text = "Enter your name";
            // 
            // enterNameTextBox
            // 
            this.enterNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.enterNameTextBox.Location = new System.Drawing.Point(247, 397);
            this.enterNameTextBox.Name = "enterNameTextBox";
            this.enterNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.enterNameTextBox.Size = new System.Drawing.Size(206, 26);
            this.enterNameTextBox.TabIndex = 32;
            this.enterNameTextBox.Text = "John Doe";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(891, 513);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(72, 38);
            this.button3.TabIndex = 33;
            this.button3.Text = "BACK";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // colorComboBox
            // 
            this.colorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colorComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.colorComboBox.FormattingEnabled = true;
            this.colorComboBox.Location = new System.Drawing.Point(249, 289);
            this.colorComboBox.Name = "colorComboBox";
            this.colorComboBox.Size = new System.Drawing.Size(204, 28);
            this.colorComboBox.TabIndex = 41;
            this.colorComboBox.SelectedIndexChanged += new System.EventHandler(this.colorComboBox_SelectedIndexChanged);
            // 
            // engineComboBox
            // 
            this.engineComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.engineComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.engineComboBox.FormattingEnabled = true;
            this.engineComboBox.Location = new System.Drawing.Point(249, 228);
            this.engineComboBox.Name = "engineComboBox";
            this.engineComboBox.Size = new System.Drawing.Size(204, 28);
            this.engineComboBox.TabIndex = 40;
            this.engineComboBox.SelectedIndexChanged += new System.EventHandler(this.engineComboBox_SelectedIndexChanged);
            // 
            // carModelComboBox
            // 
            this.carModelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.carModelComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.carModelComboBox.FormattingEnabled = true;
            this.carModelComboBox.Location = new System.Drawing.Point(249, 161);
            this.carModelComboBox.Name = "carModelComboBox";
            this.carModelComboBox.Size = new System.Drawing.Size(204, 28);
            this.carModelComboBox.TabIndex = 39;
            this.carModelComboBox.SelectedIndexChanged += new System.EventHandler(this.carModelComboBox_SelectedIndexChanged);
            // 
            // carMakeComboBox
            // 
            this.carMakeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.carMakeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.carMakeComboBox.FormattingEnabled = true;
            this.carMakeComboBox.Location = new System.Drawing.Point(249, 103);
            this.carMakeComboBox.Name = "carMakeComboBox";
            this.carMakeComboBox.Size = new System.Drawing.Size(204, 28);
            this.carMakeComboBox.TabIndex = 38;
            this.carMakeComboBox.SelectedIndexChanged += new System.EventHandler(this.carMakeComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(48, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 24);
            this.label3.TabIndex = 37;
            this.label3.Text = "Engine";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(48, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 24);
            this.label4.TabIndex = 36;
            this.label4.Text = "Color";
            // 
            // carModel
            // 
            this.carModel.AutoSize = true;
            this.carModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.carModel.Location = new System.Drawing.Point(48, 161);
            this.carModel.Name = "carModel";
            this.carModel.Size = new System.Drawing.Size(63, 24);
            this.carModel.TabIndex = 35;
            this.carModel.Text = "Model";
            // 
            // carBrand
            // 
            this.carBrand.AutoSize = true;
            this.carBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.carBrand.Location = new System.Drawing.Point(48, 103);
            this.carBrand.Name = "carBrand";
            this.carBrand.Size = new System.Drawing.Size(56, 24);
            this.carBrand.TabIndex = 34;
            this.carBrand.Text = "Make";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.driverName});
            this.dataGridView1.Location = new System.Drawing.Point(604, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(244, 320);
            this.dataGridView1.TabIndex = 42;
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            // 
            // driverName
            // 
            this.driverName.HeaderText = "Name";
            this.driverName.Name = "driverName";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(743, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 37);
            this.button1.TabIndex = 43;
            this.button1.Text = "REMOVE RESERVATION";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRemoveRes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 563);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.colorComboBox);
            this.Controls.Add(this.engineComboBox);
            this.Controls.Add(this.carModelComboBox);
            this.Controls.Add(this.carMakeComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.carModel);
            this.Controls.Add(this.carBrand);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.enterNameTextBox);
            this.Controls.Add(this.nameEnterLabel);
            this.Controls.Add(this.showReservations);
            this.Controls.Add(this.btnAddReservation);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "btnRemoveRes";
            this.Text = "Book the test drive";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button showReservations;
        private System.Windows.Forms.Label nameEnterLabel;
        private System.Windows.Forms.TextBox enterNameTextBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox colorComboBox;
        private System.Windows.Forms.ComboBox engineComboBox;
        private System.Windows.Forms.ComboBox carModelComboBox;
        private System.Windows.Forms.ComboBox carMakeComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label carModel;
        private System.Windows.Forms.Label carBrand;
        private System.Windows.Forms.Button btnAddReservation;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn driverName;
        private System.Windows.Forms.Button button1;
    }
}
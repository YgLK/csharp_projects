namespace CarDealership
{
    partial class DreamCarForm
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
            this.carBranListBox = new System.Windows.Forms.ListBox();
            this.carBrand = new System.Windows.Forms.Label();
            this.carModel = new System.Windows.Forms.Label();
            this.carModelListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorPickButton = new System.Windows.Forms.Button();
            this.carImage = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.addFeautLabel = new System.Windows.Forms.Label();
            this.additionalFeaturesList = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.carImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(253, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Car specifications";
            // 
            // carBranListBox
            // 
            this.carBranListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.carBranListBox.FormattingEnabled = true;
            this.carBranListBox.ItemHeight = 20;
            this.carBranListBox.Location = new System.Drawing.Point(272, 97);
            this.carBranListBox.Name = "carBranListBox";
            this.carBranListBox.Size = new System.Drawing.Size(187, 24);
            this.carBranListBox.TabIndex = 1;
            // 
            // carBrand
            // 
            this.carBrand.AutoSize = true;
            this.carBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.carBrand.Location = new System.Drawing.Point(50, 97);
            this.carBrand.Name = "carBrand";
            this.carBrand.Size = new System.Drawing.Size(56, 24);
            this.carBrand.TabIndex = 2;
            this.carBrand.Text = "Make";
            // 
            // carModel
            // 
            this.carModel.AutoSize = true;
            this.carModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.carModel.Location = new System.Drawing.Point(50, 151);
            this.carModel.Name = "carModel";
            this.carModel.Size = new System.Drawing.Size(63, 24);
            this.carModel.TabIndex = 4;
            this.carModel.Text = "Model";
            // 
            // carModelListBox
            // 
            this.carModelListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.carModelListBox.FormattingEnabled = true;
            this.carModelListBox.ItemHeight = 20;
            this.carModelListBox.Location = new System.Drawing.Point(272, 151);
            this.carModelListBox.Name = "carModelListBox";
            this.carModelListBox.Size = new System.Drawing.Size(187, 24);
            this.carModelListBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(50, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Color";
            // 
            // colorPickButton
            // 
            this.colorPickButton.Font = new System.Drawing.Font("Microsoft Uighur", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.colorPickButton.Location = new System.Drawing.Point(272, 264);
            this.colorPickButton.Name = "colorPickButton";
            this.colorPickButton.Size = new System.Drawing.Size(187, 24);
            this.colorPickButton.TabIndex = 6;
            this.colorPickButton.Text = "PICK COLOR";
            this.colorPickButton.UseVisualStyleBackColor = true;
            this.colorPickButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // carImage
            // 
            this.carImage.Location = new System.Drawing.Point(524, 97);
            this.carImage.Name = "carImage";
            this.carImage.Size = new System.Drawing.Size(204, 163);
            this.carImage.TabIndex = 7;
            this.carImage.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(50, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Engine";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(272, 206);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(187, 24);
            this.listBox1.TabIndex = 8;
            // 
            // addFeautLabel
            // 
            this.addFeautLabel.AutoSize = true;
            this.addFeautLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addFeautLabel.Location = new System.Drawing.Point(50, 323);
            this.addFeautLabel.Name = "addFeautLabel";
            this.addFeautLabel.Size = new System.Drawing.Size(164, 24);
            this.addFeautLabel.TabIndex = 11;
            this.addFeautLabel.Text = "Additional features";
            // 
            // additionalFeaturesList
            // 
            this.additionalFeaturesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.additionalFeaturesList.FormattingEnabled = true;
            this.additionalFeaturesList.ItemHeight = 20;
            this.additionalFeaturesList.Location = new System.Drawing.Point(272, 323);
            this.additionalFeaturesList.Name = "additionalFeaturesList";
            this.additionalFeaturesList.Size = new System.Drawing.Size(187, 24);
            this.additionalFeaturesList.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(571, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 33);
            this.button1.TabIndex = 12;
            this.button1.Text = "SEARCH";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // DreamCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addFeautLabel);
            this.Controls.Add(this.additionalFeaturesList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.carImage);
            this.Controls.Add(this.colorPickButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.carModel);
            this.Controls.Add(this.carModelListBox);
            this.Controls.Add(this.carBrand);
            this.Controls.Add(this.carBranListBox);
            this.Controls.Add(this.label1);
            this.Name = "DreamCarForm";
            this.Text = "Find your dream car!";
            ((System.ComponentModel.ISupportInitialize)(this.carImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox carBranListBox;
        private System.Windows.Forms.Label carBrand;
        private System.Windows.Forms.Label carModel;
        private System.Windows.Forms.ListBox carModelListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button colorPickButton;
        private System.Windows.Forms.PictureBox carImage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label addFeautLabel;
        private System.Windows.Forms.ListBox additionalFeaturesList;
        private System.Windows.Forms.Button button1;
    }
}
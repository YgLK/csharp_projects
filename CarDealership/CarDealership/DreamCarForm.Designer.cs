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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.carBrand = new System.Windows.Forms.Label();
            this.carModel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.carImage = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addFeautLabel = new System.Windows.Forms.Label();
            this.searchOffersButton = new System.Windows.Forms.Button();
            this.carMakeComboBox = new System.Windows.Forms.ComboBox();
            this.carModelComboBox = new System.Windows.Forms.ComboBox();
            this.engineComboBox = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.colorComboBox = new System.Windows.Forms.ComboBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.prodYearLabel = new System.Windows.Forms.Label();
            this.boxAdditionalAccessories = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.carImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(150, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Car specifications";
            // 
            // carBrand
            // 
            this.carBrand.AutoSize = true;
            this.carBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.carBrand.Location = new System.Drawing.Point(69, 243);
            this.carBrand.Name = "carBrand";
            this.carBrand.Size = new System.Drawing.Size(56, 24);
            this.carBrand.TabIndex = 2;
            this.carBrand.Text = "Make";
            // 
            // carModel
            // 
            this.carModel.AutoSize = true;
            this.carModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.carModel.Location = new System.Drawing.Point(69, 301);
            this.carModel.Name = "carModel";
            this.carModel.Size = new System.Drawing.Size(63, 24);
            this.carModel.TabIndex = 4;
            this.carModel.Text = "Model";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(69, 429);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Color";
            // 
            // carImage
            // 
            this.carImage.Location = new System.Drawing.Point(558, 82);
            this.carImage.Name = "carImage";
            this.carImage.Size = new System.Drawing.Size(750, 447);
            this.carImage.TabIndex = 7;
            this.carImage.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(69, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Engine";
            // 
            // addFeautLabel
            // 
            this.addFeautLabel.AutoSize = true;
            this.addFeautLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addFeautLabel.Location = new System.Drawing.Point(69, 492);
            this.addFeautLabel.Name = "addFeautLabel";
            this.addFeautLabel.Size = new System.Drawing.Size(164, 24);
            this.addFeautLabel.TabIndex = 11;
            this.addFeautLabel.Text = "Additional features";
            // 
            // searchOffersButton
            // 
            this.searchOffersButton.Location = new System.Drawing.Point(792, 643);
            this.searchOffersButton.Name = "searchOffersButton";
            this.searchOffersButton.Size = new System.Drawing.Size(172, 45);
            this.searchOffersButton.TabIndex = 12;
            this.searchOffersButton.Text = "SHOW";
            this.searchOffersButton.UseVisualStyleBackColor = true;
            this.searchOffersButton.Click += new System.EventHandler(this.searchOffersButton_Click);
            // 
            // carMakeComboBox
            // 
            this.carMakeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.carMakeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.carMakeComboBox.FormattingEnabled = true;
            this.carMakeComboBox.Location = new System.Drawing.Point(291, 243);
            this.carMakeComboBox.Name = "carMakeComboBox";
            this.carMakeComboBox.Size = new System.Drawing.Size(204, 28);
            this.carMakeComboBox.TabIndex = 13;
            this.carMakeComboBox.SelectedIndexChanged += new System.EventHandler(this.carMakeComboBox_SelectedIndexChanged);
            // 
            // carModelComboBox
            // 
            this.carModelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.carModelComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.carModelComboBox.FormattingEnabled = true;
            this.carModelComboBox.Location = new System.Drawing.Point(291, 301);
            this.carModelComboBox.Name = "carModelComboBox";
            this.carModelComboBox.Size = new System.Drawing.Size(204, 28);
            this.carModelComboBox.TabIndex = 14;
            this.carModelComboBox.SelectedIndexChanged += new System.EventHandler(this.carModelComboBox_SelectedIndexChanged);
            // 
            // engineComboBox
            // 
            this.engineComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.engineComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.engineComboBox.FormattingEnabled = true;
            this.engineComboBox.Location = new System.Drawing.Point(291, 368);
            this.engineComboBox.Name = "engineComboBox";
            this.engineComboBox.Size = new System.Drawing.Size(204, 28);
            this.engineComboBox.TabIndex = 15;
            this.engineComboBox.SelectedIndexChanged += new System.EventHandler(this.engineComboBox_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // colorComboBox
            // 
            this.colorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colorComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.colorComboBox.FormattingEnabled = true;
            this.colorComboBox.Location = new System.Drawing.Point(291, 429);
            this.colorComboBox.Name = "colorComboBox";
            this.colorComboBox.Size = new System.Drawing.Size(204, 28);
            this.colorComboBox.TabIndex = 17;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.priceLabel.Location = new System.Drawing.Point(689, 577);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(83, 25);
            this.priceLabel.TabIndex = 18;
            this.priceLabel.Text = "PRICE:";
            // 
            // prodYearLabel
            // 
            this.prodYearLabel.AutoSize = true;
            this.prodYearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prodYearLabel.Location = new System.Drawing.Point(689, 542);
            this.prodYearLabel.Name = "prodYearLabel";
            this.prodYearLabel.Size = new System.Drawing.Size(275, 25);
            this.prodYearLabel.TabIndex = 19;
            this.prodYearLabel.Text = "MANUFACTURING YEAR: ";
            // 
            // boxAdditionalAccessories
            // 
            this.boxAdditionalAccessories.FormattingEnabled = true;
            this.boxAdditionalAccessories.Location = new System.Drawing.Point(291, 492);
            this.boxAdditionalAccessories.Name = "boxAdditionalAccessories";
            this.boxAdditionalAccessories.Size = new System.Drawing.Size(204, 109);
            this.boxAdditionalAccessories.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1181, 643);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 45);
            this.button1.TabIndex = 21;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(986, 643);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 45);
            this.button2.TabIndex = 22;
            this.button2.Text = "DELETE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.DeleteOffer_Click);
            // 
            // DreamCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.boxAdditionalAccessories);
            this.Controls.Add(this.prodYearLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.colorComboBox);
            this.Controls.Add(this.engineComboBox);
            this.Controls.Add(this.carModelComboBox);
            this.Controls.Add(this.carMakeComboBox);
            this.Controls.Add(this.searchOffersButton);
            this.Controls.Add(this.addFeautLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.carImage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.carModel);
            this.Controls.Add(this.carBrand);
            this.Controls.Add(this.label1);
            this.Name = "DreamCarForm";
            this.Text = "Find your dream car!";
            ((System.ComponentModel.ISupportInitialize)(this.carImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label carBrand;
        private System.Windows.Forms.Label carModel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox carImage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label addFeautLabel;
        private System.Windows.Forms.Button searchOffersButton;
        private System.Windows.Forms.ComboBox carMakeComboBox;
        private System.Windows.Forms.ComboBox carModelComboBox;
        private System.Windows.Forms.ComboBox engineComboBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox colorComboBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label prodYearLabel;
        private System.Windows.Forms.CheckedListBox boxAdditionalAccessories;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
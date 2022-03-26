namespace CarDealership
{
    partial class Menu
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
            this.dreamCarButton = new System.Windows.Forms.Button();
            this.newCarAddButton = new System.Windows.Forms.Button();
            this.reservationButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dreamCarButton
            // 
            this.dreamCarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dreamCarButton.Location = new System.Drawing.Point(256, 134);
            this.dreamCarButton.Name = "dreamCarButton";
            this.dreamCarButton.Size = new System.Drawing.Size(238, 47);
            this.dreamCarButton.TabIndex = 0;
            this.dreamCarButton.Text = "Find your dream car";
            this.dreamCarButton.UseVisualStyleBackColor = true;
            this.dreamCarButton.Click += new System.EventHandler(this.dreamCarButton_Click);
            // 
            // newCarAddButton
            // 
            this.newCarAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newCarAddButton.Location = new System.Drawing.Point(256, 214);
            this.newCarAddButton.Name = "newCarAddButton";
            this.newCarAddButton.Size = new System.Drawing.Size(238, 50);
            this.newCarAddButton.TabIndex = 1;
            this.newCarAddButton.Text = "Add new car";
            this.newCarAddButton.UseVisualStyleBackColor = true;
            this.newCarAddButton.Click += new System.EventHandler(this.newCarAddButton_Click);
            // 
            // reservationButton
            // 
            this.reservationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.reservationButton.Location = new System.Drawing.Point(256, 299);
            this.reservationButton.Name = "reservationButton";
            this.reservationButton.Size = new System.Drawing.Size(238, 47);
            this.reservationButton.TabIndex = 2;
            this.reservationButton.Text = "Book a test drive";
            this.reservationButton.UseVisualStyleBackColor = true;
            this.reservationButton.Click += new System.EventHandler(this.reservationButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(233, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 51);
            this.label1.TabIndex = 3;
            this.label1.Text = "Car Dealeship";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reservationButton);
            this.Controls.Add(this.newCarAddButton);
            this.Controls.Add(this.dreamCarButton);
            this.Name = "Menu";
            this.Text = "CarDealership";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dreamCarButton;
        private System.Windows.Forms.Button newCarAddButton;
        private System.Windows.Forms.Button reservationButton;
        private System.Windows.Forms.Label label1;
    }
}


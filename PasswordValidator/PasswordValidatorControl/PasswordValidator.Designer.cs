namespace PasswordValidatorControl
{
    partial class PasswordValidator
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMinSpecChar = new System.Windows.Forms.Label();
            this.lblMinChar = new System.Windows.Forms.Label();
            this.lblCapitalLetter = new System.Windows.Forms.Label();
            this.lblMinDigit = new System.Windows.Forms.Label();
            this.pctMinChar = new System.Windows.Forms.PictureBox();
            this.pctMinCapLet = new System.Windows.Forms.PictureBox();
            this.pctMinSpecChar = new System.Windows.Forms.PictureBox();
            this.pctMinDigit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctMinChar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMinCapLet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMinSpecChar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMinDigit)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMinSpecChar
            // 
            this.lblMinSpecChar.AutoSize = true;
            this.lblMinSpecChar.Location = new System.Drawing.Point(108, 107);
            this.lblMinSpecChar.Name = "lblMinSpecChar";
            this.lblMinSpecChar.Size = new System.Drawing.Size(158, 15);
            this.lblMinSpecChar.TabIndex = 2;
            this.lblMinSpecChar.Text = "at least one special character";
            // 
            // lblMinChar
            // 
            this.lblMinChar.AutoSize = true;
            this.lblMinChar.Location = new System.Drawing.Point(108, 26);
            this.lblMinChar.Name = "lblMinChar";
            this.lblMinChar.Size = new System.Drawing.Size(113, 15);
            this.lblMinChar.TabIndex = 3;
            this.lblMinChar.Text = "at least N characters";
            // 
            // lblCapitalLetter
            // 
            this.lblCapitalLetter.AutoSize = true;
            this.lblCapitalLetter.Location = new System.Drawing.Point(108, 68);
            this.lblCapitalLetter.Name = "lblCapitalLetter";
            this.lblCapitalLetter.Size = new System.Drawing.Size(135, 15);
            this.lblCapitalLetter.TabIndex = 4;
            this.lblCapitalLetter.Text = "at least one capital letter";
            // 
            // lblMinDigit
            // 
            this.lblMinDigit.AutoSize = true;
            this.lblMinDigit.Location = new System.Drawing.Point(108, 147);
            this.lblMinDigit.Name = "lblMinDigit";
            this.lblMinDigit.Size = new System.Drawing.Size(94, 15);
            this.lblMinDigit.TabIndex = 5;
            this.lblMinDigit.Text = "at least one digit";
            // 
            // pctMinChar
            // 
            this.pctMinChar.Image = global::PasswordValidatorControl.Properties.Resources.reject;
            this.pctMinChar.Location = new System.Drawing.Point(47, 16);
            this.pctMinChar.Name = "pctMinChar";
            this.pctMinChar.Size = new System.Drawing.Size(29, 25);
            this.pctMinChar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctMinChar.TabIndex = 10;
            this.pctMinChar.TabStop = false;
            // 
            // pctMinCapLet
            // 
            this.pctMinCapLet.Image = global::PasswordValidatorControl.Properties.Resources.reject;
            this.pctMinCapLet.Location = new System.Drawing.Point(47, 58);
            this.pctMinCapLet.Name = "pctMinCapLet";
            this.pctMinCapLet.Size = new System.Drawing.Size(29, 25);
            this.pctMinCapLet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctMinCapLet.TabIndex = 11;
            this.pctMinCapLet.TabStop = false;
            // 
            // pctMinSpecChar
            // 
            this.pctMinSpecChar.Image = global::PasswordValidatorControl.Properties.Resources.reject;
            this.pctMinSpecChar.Location = new System.Drawing.Point(47, 97);
            this.pctMinSpecChar.Name = "pctMinSpecChar";
            this.pctMinSpecChar.Size = new System.Drawing.Size(29, 25);
            this.pctMinSpecChar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctMinSpecChar.TabIndex = 12;
            this.pctMinSpecChar.TabStop = false;
            // 
            // pctMinDigit
            // 
            this.pctMinDigit.Image = global::PasswordValidatorControl.Properties.Resources.reject;
            this.pctMinDigit.Location = new System.Drawing.Point(47, 137);
            this.pctMinDigit.Name = "pctMinDigit";
            this.pctMinDigit.Size = new System.Drawing.Size(29, 25);
            this.pctMinDigit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctMinDigit.TabIndex = 13;
            this.pctMinDigit.TabStop = false;
            // 
            // PasswordValidator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pctMinDigit);
            this.Controls.Add(this.pctMinSpecChar);
            this.Controls.Add(this.pctMinCapLet);
            this.Controls.Add(this.pctMinChar);
            this.Controls.Add(this.lblMinDigit);
            this.Controls.Add(this.lblCapitalLetter);
            this.Controls.Add(this.lblMinChar);
            this.Controls.Add(this.lblMinSpecChar);
            this.Name = "PasswordValidator";
            this.Size = new System.Drawing.Size(293, 190);
            ((System.ComponentModel.ISupportInitialize)(this.pctMinChar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMinCapLet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMinSpecChar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMinDigit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblMinSpecChar;
        private Label lblMinChar;
        private Label lblCapitalLetter;
        private Label lblMinDigit;
        private PictureBox pctMinChar;
        private PictureBox pctMinCapLet;
        private PictureBox pctMinSpecChar;
        private PictureBox pctMinDigit;
    }
}
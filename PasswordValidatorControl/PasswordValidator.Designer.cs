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
            this.boolCapitalLetterCount = new System.Windows.Forms.Label();
            this.boolCharCount = new System.Windows.Forms.Label();
            this.boolSpecCharCount = new System.Windows.Forms.Label();
            this.boolDigitCount = new System.Windows.Forms.Label();
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
            // boolCapitalLetterCount
            // 
            this.boolCapitalLetterCount.AutoSize = true;
            this.boolCapitalLetterCount.Location = new System.Drawing.Point(26, 68);
            this.boolCapitalLetterCount.Name = "boolCapitalLetterCount";
            this.boolCapitalLetterCount.Size = new System.Drawing.Size(38, 15);
            this.boolCapitalLetterCount.TabIndex = 6;
            this.boolCapitalLetterCount.Text = "FALSE";
            // 
            // boolCharCount
            // 
            this.boolCharCount.AutoSize = true;
            this.boolCharCount.Location = new System.Drawing.Point(26, 26);
            this.boolCharCount.Name = "boolCharCount";
            this.boolCharCount.Size = new System.Drawing.Size(38, 15);
            this.boolCharCount.TabIndex = 7;
            this.boolCharCount.Text = "FALSE";
            // 
            // boolSpecCharCount
            // 
            this.boolSpecCharCount.AutoSize = true;
            this.boolSpecCharCount.Location = new System.Drawing.Point(26, 107);
            this.boolSpecCharCount.Name = "boolSpecCharCount";
            this.boolSpecCharCount.Size = new System.Drawing.Size(38, 15);
            this.boolSpecCharCount.TabIndex = 8;
            this.boolSpecCharCount.Text = "FALSE";
            // 
            // boolDigitCount
            // 
            this.boolDigitCount.AutoSize = true;
            this.boolDigitCount.Location = new System.Drawing.Point(26, 147);
            this.boolDigitCount.Name = "boolDigitCount";
            this.boolDigitCount.Size = new System.Drawing.Size(38, 15);
            this.boolDigitCount.TabIndex = 9;
            this.boolDigitCount.Text = "FALSE";
            // 
            // PasswordValidator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.boolDigitCount);
            this.Controls.Add(this.boolSpecCharCount);
            this.Controls.Add(this.boolCharCount);
            this.Controls.Add(this.boolCapitalLetterCount);
            this.Controls.Add(this.lblMinDigit);
            this.Controls.Add(this.lblCapitalLetter);
            this.Controls.Add(this.lblMinChar);
            this.Controls.Add(this.lblMinSpecChar);
            this.Name = "PasswordValidator";
            this.Size = new System.Drawing.Size(293, 190);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblMinSpecChar;
        private Label lblMinChar;
        private Label lblCapitalLetter;
        private Label lblMinDigit;
        private Label boolCapitalLetterCount;
        private Label boolCharCount;
        private Label boolSpecCharCount;
        private Label boolDigitCount;
    }
}
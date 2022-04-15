namespace MemoryApp
{
    partial class Configuration
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.initTimeTextBox = new System.Windows.Forms.TextBox();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.cardVisibilityTextBox = new System.Windows.Forms.TextBox();
            this.boardSizeTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(250, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gameplay configuration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(166, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Card visibility time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(166, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Board size    (e.g. 4x4)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(166, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Initial visibility time";
            // 
            // initTimeTextBox
            // 
            this.initTimeTextBox.Location = new System.Drawing.Point(412, 116);
            this.initTimeTextBox.Name = "initTimeTextBox";
            this.initTimeTextBox.Size = new System.Drawing.Size(197, 20);
            this.initTimeTextBox.TabIndex = 5;
            this.initTimeTextBox.Text = "3";
            // 
            // btnStartGame
            // 
            this.btnStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStartGame.Location = new System.Drawing.Point(302, 344);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(150, 35);
            this.btnStartGame.TabIndex = 6;
            this.btnStartGame.Text = "START";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // cardVisibilityTextBox
            // 
            this.cardVisibilityTextBox.Location = new System.Drawing.Point(412, 166);
            this.cardVisibilityTextBox.Name = "cardVisibilityTextBox";
            this.cardVisibilityTextBox.Size = new System.Drawing.Size(197, 20);
            this.cardVisibilityTextBox.TabIndex = 7;
            this.cardVisibilityTextBox.Text = "0.4";
            // 
            // boardSizeTextBox
            // 
            this.boardSizeTextBox.Location = new System.Drawing.Point(412, 221);
            this.boardSizeTextBox.Name = "boardSizeTextBox";
            this.boardSizeTextBox.Size = new System.Drawing.Size(197, 20);
            this.boardSizeTextBox.TabIndex = 8;
            this.boardSizeTextBox.Text = "4x4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(273, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(268, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "WARNING! The provided time values means seconds. ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(273, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(252, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "If no values are chosen, the default ones will be set!";
            // 
            // Configuration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.boardSizeTextBox);
            this.Controls.Add(this.cardVisibilityTextBox);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.initTimeTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Configuration";
            this.Text = "Configuration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox initTimeTextBox;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.TextBox cardVisibilityTextBox;
        private System.Windows.Forms.TextBox boardSizeTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}
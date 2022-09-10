namespace TestWeekScheduler
{
    partial class Form1
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
            this.weekScheduler1 = new WeekSchedulerControl.WeekScheduler();
            this.SuspendLayout();
            // 
            // weekScheduler1
            // 
            this.weekScheduler1.Location = new System.Drawing.Point(12, 12);
            this.weekScheduler1.Name = "weekScheduler1";
            this.weekScheduler1.Size = new System.Drawing.Size(1161, 620);
            this.weekScheduler1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 668);
            this.Controls.Add(this.weekScheduler1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private WeekSchedulerControl.WeekScheduler weekScheduler1;
    }
}
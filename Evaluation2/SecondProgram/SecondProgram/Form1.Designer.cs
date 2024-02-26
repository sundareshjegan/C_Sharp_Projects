namespace SecondProgram
{
    partial class Form1
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
            this.calender1 = new SecondProgram.Calender();
            this.SuspendLayout();
            // 
            // calender1
            // 
            this.calender1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calender1.Location = new System.Drawing.Point(0, 0);
            this.calender1.Name = "calender1";
            this.calender1.Size = new System.Drawing.Size(320, 367);
            this.calender1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 367);
            this.Controls.Add(this.calender1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Calender";
            this.ResumeLayout(false);

        }

        #endregion

        private Calender calender1;
    }
}


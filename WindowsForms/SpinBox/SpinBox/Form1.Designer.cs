namespace SpinBox
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
            this.spinBoxUserControl1 = new SpinBox.SpinBoxUserControl();
            this.SuspendLayout();
            // 
            // spinBoxUserControl1
            // 
            this.spinBoxUserControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.spinBoxUserControl1.Location = new System.Drawing.Point(12, 12);
            this.spinBoxUserControl1.Name = "spinBoxUserControl1";
            this.spinBoxUserControl1.Size = new System.Drawing.Size(324, 66);
            this.spinBoxUserControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 84);
            this.Controls.Add(this.spinBoxUserControl1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(366, 123);
            this.MinimumSize = new System.Drawing.Size(366, 123);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private SpinBoxUserControl spinBoxUserControl1;
    }
}


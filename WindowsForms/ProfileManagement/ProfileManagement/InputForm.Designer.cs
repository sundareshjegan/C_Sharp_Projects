namespace ProfileManagement
{
    partial class InputForm
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
            this.inputUC1 = new ProfileManagement.InputUC();
            this.SuspendLayout();
            // 
            // inputUC1
            // 
            this.inputUC1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.inputUC1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inputUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputUC1.Location = new System.Drawing.Point(0, 0);
            this.inputUC1.Name = "inputUC1";
            this.inputUC1.Size = new System.Drawing.Size(449, 527);
            this.inputUC1.TabIndex = 0;
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 527);
            this.Controls.Add(this.inputUC1);
            this.Name = "InputForm";
            this.Text = "InputForm";
            this.ResumeLayout(false);

        }

        #endregion

        private InputUC inputUC1;
    }
}
namespace UserControlProgressBar
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
            this.canvasPanel = new System.Windows.Forms.Panel();
            this.widthHeightUserControl1 = new UserControlProgressBar.WidthHeightUserControl();
            this.SuspendLayout();
            // 
            // canvasPanel
            // 
            this.canvasPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvasPanel.Location = new System.Drawing.Point(0, 0);
            this.canvasPanel.Name = "canvasPanel";
            this.canvasPanel.Size = new System.Drawing.Size(489, 450);
            this.canvasPanel.TabIndex = 1;
            this.canvasPanel.Resize += new System.EventHandler(this.OnValuesChanged);
            // 
            // widthHeightUserControl1
            // 
            this.widthHeightUserControl1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.widthHeightUserControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.widthHeightUserControl1.Location = new System.Drawing.Point(489, 0);
            this.widthHeightUserControl1.Name = "widthHeightUserControl1";
            this.widthHeightUserControl1.Size = new System.Drawing.Size(311, 450);
            this.widthHeightUserControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.canvasPanel);
            this.Controls.Add(this.widthHeightUserControl1);
            this.MinimumSize = new System.Drawing.Size(808, 410);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private WidthHeightUserControl widthHeightUserControl1;
        private System.Windows.Forms.Panel canvasPanel;
    }
}


namespace UserControlProgressBar
{
    partial class WidthHeightUserControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.heightProgressBar = new System.Windows.Forms.ProgressBar();
            this.widthProgressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Height";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthLabel.Location = new System.Drawing.Point(177, 64);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(24, 25);
            this.widthLabel.TabIndex = 0;
            this.widthLabel.Text = "0";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightLabel.Location = new System.Drawing.Point(177, 215);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(24, 25);
            this.heightLabel.TabIndex = 0;
            this.heightLabel.Text = "0";
            // 
            // heightProgressBar
            // 
            this.heightProgressBar.Location = new System.Drawing.Point(33, 255);
            this.heightProgressBar.Name = "heightProgressBar";
            this.heightProgressBar.Size = new System.Drawing.Size(224, 30);
            this.heightProgressBar.TabIndex = 1;
            this.heightProgressBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnHeightProgressBarMouseDown);
            this.heightProgressBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnHeightProgressBarMouseMoved);
            this.heightProgressBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnHeightProgressBarMouseUp);
            // 
            // widthProgressBar
            // 
            this.widthProgressBar.Location = new System.Drawing.Point(33, 104);
            this.widthProgressBar.Name = "widthProgressBar";
            this.widthProgressBar.Size = new System.Drawing.Size(224, 30);
            this.widthProgressBar.TabIndex = 1;
            this.widthProgressBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnWidthProgressBarMouseDown);
            this.widthProgressBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnWidthProgressBarMouseMoved);
            this.widthProgressBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnWidthProgressBarMouseUp);
            // 
            // WidthHeightUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Controls.Add(this.widthProgressBar);
            this.Controls.Add(this.heightProgressBar);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.label1);
            this.Name = "WidthHeightUserControl";
            this.Size = new System.Drawing.Size(308, 410);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.ProgressBar heightProgressBar;
        private System.Windows.Forms.ProgressBar widthProgressBar;
    }
}

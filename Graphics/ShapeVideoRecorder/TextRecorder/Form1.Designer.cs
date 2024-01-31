namespace TextRecorder
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
            this.ClearButton = new System.Windows.Forms.Button();
            this.PlayPauseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClearButton
            // 
            this.ClearButton.BackgroundImage = global::TextRecorder.Properties.Resources.DeleteImage;
            this.ClearButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(485, 392);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(69, 46);
            this.ClearButton.TabIndex = 1;
            this.ClearButton.TabStop = false;
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // PlayPauseButton
            // 
            this.PlayPauseButton.BackgroundImage = global::TextRecorder.Properties.Resources.PlayImage;
            this.PlayPauseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlayPauseButton.Location = new System.Drawing.Point(391, 392);
            this.PlayPauseButton.Name = "PlayPauseButton";
            this.PlayPauseButton.Size = new System.Drawing.Size(75, 49);
            this.PlayPauseButton.TabIndex = 0;
            this.PlayPauseButton.TabStop = false;
            this.PlayPauseButton.UseVisualStyleBackColor = true;
            this.PlayPauseButton.Click += new System.EventHandler(this.OnPlayPauseButtonClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 450);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.PlayPauseButton);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "dfh";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OnFormPaint);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnFormKeyPress);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnFormMouseDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PlayPauseButton;
        private System.Windows.Forms.Button ClearButton;
    }
}


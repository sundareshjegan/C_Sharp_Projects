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
            this.TimerButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.PlayPauseButton = new System.Windows.Forms.Button();
            this.speedLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TimerButton
            // 
            this.TimerButton.BackgroundImage = global::TextRecorder.Properties.Resources.TimerImage;
            this.TimerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.TimerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TimerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerButton.Location = new System.Drawing.Point(90, 405);
            this.TimerButton.Name = "TimerButton";
            this.TimerButton.Size = new System.Drawing.Size(34, 33);
            this.TimerButton.TabIndex = 1;
            this.TimerButton.TabStop = false;
            this.TimerButton.UseVisualStyleBackColor = true;
            this.TimerButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnTimerButtonClicked);
            // 
            // ClearButton
            // 
            this.ClearButton.BackgroundImage = global::TextRecorder.Properties.Resources.DeleteImage;
            this.ClearButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(52, 405);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(32, 33);
            this.ClearButton.TabIndex = 1;
            this.ClearButton.TabStop = false;
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.OnClearButtonClicked);
            // 
            // PlayPauseButton
            // 
            this.PlayPauseButton.BackgroundImage = global::TextRecorder.Properties.Resources.PlayImage;
            this.PlayPauseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlayPauseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayPauseButton.Location = new System.Drawing.Point(12, 405);
            this.PlayPauseButton.Name = "PlayPauseButton";
            this.PlayPauseButton.Size = new System.Drawing.Size(34, 33);
            this.PlayPauseButton.TabIndex = 0;
            this.PlayPauseButton.TabStop = false;
            this.PlayPauseButton.UseVisualStyleBackColor = true;
            this.PlayPauseButton.Click += new System.EventHandler(this.OnPlayPauseButtonClicked);
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.speedLabel.Font = new System.Drawing.Font("Microsoft Himalaya", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedLabel.Location = new System.Drawing.Point(130, 416);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(113, 21);
            this.speedLabel.TabIndex = 2;
            this.speedLabel.Text = "Speed : Slow (1x)";
            this.speedLabel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnTimerButtonClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 450);
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.TimerButton);
            this.Controls.Add(this.PlayPauseButton);
            this.Controls.Add(this.ClearButton);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "TextRecorder";
            this.Click += new System.EventHandler(this.OnFormClicked);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OnFormPaint);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnFormKeyPress);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnFormMouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PlayPauseButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button TimerButton;
        private System.Windows.Forms.Label speedLabel;
    }
}


namespace ShapeVideoRecorder
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
            this.OptionButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PlayPauseButton = new System.Windows.Forms.Button();
            this.ShapeCB = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OptionButton
            // 
            this.OptionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionButton.Location = new System.Drawing.Point(12, 19);
            this.OptionButton.Name = "OptionButton";
            this.OptionButton.Size = new System.Drawing.Size(101, 28);
            this.OptionButton.TabIndex = 0;
            this.OptionButton.Text = "StartRecording";
            this.OptionButton.UseVisualStyleBackColor = true;
            this.OptionButton.Click += new System.EventHandler(this.OnOptionButtonClicked);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PlayPauseButton);
            this.panel1.Controls.Add(this.ShapeCB);
            this.panel1.Controls.Add(this.OptionButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 381);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 69);
            this.panel1.TabIndex = 1;
            // 
            // PlayPauseButton
            // 
            this.PlayPauseButton.BackgroundImage = global::ShapeVideoRecorder.Properties.Resources.PauseImage;
            this.PlayPauseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlayPauseButton.Location = new System.Drawing.Point(262, 14);
            this.PlayPauseButton.Name = "PlayPauseButton";
            this.PlayPauseButton.Size = new System.Drawing.Size(54, 38);
            this.PlayPauseButton.TabIndex = 1;
            this.PlayPauseButton.UseVisualStyleBackColor = true;
            this.PlayPauseButton.Visible = false;
            this.PlayPauseButton.Click += new System.EventHandler(this.OnPlayPauseButtonClicked);
            // 
            // ShapeCB
            // 
            this.ShapeCB.Enabled = false;
            this.ShapeCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShapeCB.FormattingEnabled = true;
            this.ShapeCB.Items.AddRange(new object[] {
            "Rectangle",
            "Triangle",
            "Circle"});
            this.ShapeCB.Location = new System.Drawing.Point(119, 19);
            this.ShapeCB.Name = "ShapeCB";
            this.ShapeCB.Size = new System.Drawing.Size(121, 28);
            this.ShapeCB.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OnFormPaint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnFormMouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnFormMouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnFormMouseUp);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OptionButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox ShapeCB;
        private System.Windows.Forms.Button PlayPauseButton;
    }
}


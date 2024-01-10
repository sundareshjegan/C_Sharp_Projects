namespace DrawShapes
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.triangleButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.circleButton = new System.Windows.Forms.Button();
            this.rectangleButton = new System.Windows.Forms.Button();
            this.canvasPanel = new System.Windows.Forms.Panel();
            this.propertyLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.propertyLabel);
            this.panel1.Controls.Add(this.triangleButton);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.circleButton);
            this.panel1.Controls.Add(this.rectangleButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 543);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 59);
            this.panel1.TabIndex = 0;
            // 
            // triangleButton
            // 
            this.triangleButton.AutoSize = true;
            this.triangleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.triangleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.triangleButton.Location = new System.Drawing.Point(227, 0);
            this.triangleButton.Name = "triangleButton";
            this.triangleButton.Size = new System.Drawing.Size(103, 56);
            this.triangleButton.TabIndex = 0;
            this.triangleButton.Text = "Triangle";
            this.triangleButton.UseVisualStyleBackColor = true;
            this.triangleButton.Click += new System.EventHandler(this.OnShapeButtonClicked);
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.BackColor = System.Drawing.Color.Salmon;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Dock = System.Windows.Forms.DockStyle.Right;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(691, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 59);
            this.button4.TabIndex = 0;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.OnDeleteButtonClicked);
            // 
            // circleButton
            // 
            this.circleButton.AutoSize = true;
            this.circleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.circleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circleButton.Location = new System.Drawing.Point(118, 0);
            this.circleButton.Name = "circleButton";
            this.circleButton.Size = new System.Drawing.Size(103, 56);
            this.circleButton.TabIndex = 0;
            this.circleButton.Text = "Circle";
            this.circleButton.UseVisualStyleBackColor = true;
            this.circleButton.Click += new System.EventHandler(this.OnShapeButtonClicked);
            // 
            // rectangleButton
            // 
            this.rectangleButton.AutoSize = true;
            this.rectangleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rectangleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rectangleButton.Location = new System.Drawing.Point(3, 0);
            this.rectangleButton.Name = "rectangleButton";
            this.rectangleButton.Size = new System.Drawing.Size(109, 56);
            this.rectangleButton.TabIndex = 0;
            this.rectangleButton.Text = "Rectangle";
            this.rectangleButton.UseVisualStyleBackColor = true;
            this.rectangleButton.Click += new System.EventHandler(this.OnShapeButtonClicked);
            // 
            // canvasPanel
            // 
            this.canvasPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.canvasPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvasPanel.Location = new System.Drawing.Point(0, 0);
            this.canvasPanel.Name = "canvasPanel";
            this.canvasPanel.Size = new System.Drawing.Size(794, 543);
            this.canvasPanel.TabIndex = 1;
            this.canvasPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnCanvasPanelMouseDown);
            this.canvasPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnCanvasPanelMouseMove);
            this.canvasPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnCanvasPanelMouseUp);
            // 
            // propertyLabel
            // 
            this.propertyLabel.AutoSize = true;
            this.propertyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propertyLabel.Location = new System.Drawing.Point(388, 15);
            this.propertyLabel.Name = "propertyLabel";
            this.propertyLabel.Size = new System.Drawing.Size(0, 25);
            this.propertyLabel.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 602);
            this.Controls.Add(this.canvasPanel);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button triangleButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button circleButton;
        private System.Windows.Forms.Button rectangleButton;
        private System.Windows.Forms.Panel canvasPanel;
        private System.Windows.Forms.Label propertyLabel;
    }
}


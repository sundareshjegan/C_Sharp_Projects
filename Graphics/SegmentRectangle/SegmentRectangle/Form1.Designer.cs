namespace SegmentRectangle
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
            this.InputPanel = new System.Windows.Forms.Panel();
            this.CanvasPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.IsHorizontalCheckBox = new System.Windows.Forms.CheckBox();
            this.IsFillCheckBox = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.InputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // InputPanel
            // 
            this.InputPanel.Controls.Add(this.comboBox1);
            this.InputPanel.Controls.Add(this.IsFillCheckBox);
            this.InputPanel.Controls.Add(this.IsHorizontalCheckBox);
            this.InputPanel.Controls.Add(this.numericUpDown1);
            this.InputPanel.Controls.Add(this.label1);
            this.InputPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.InputPanel.Location = new System.Drawing.Point(0, 331);
            this.InputPanel.Name = "InputPanel";
            this.InputPanel.Size = new System.Drawing.Size(800, 120);
            this.InputPanel.TabIndex = 0;
            // 
            // CanvasPanel
            // 
            this.CanvasPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CanvasPanel.Location = new System.Drawing.Point(0, 0);
            this.CanvasPanel.Name = "CanvasPanel";
            this.CanvasPanel.Size = new System.Drawing.Size(800, 331);
            this.CanvasPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "No of Segments";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(142, 19);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(85, 24);
            this.numericUpDown1.TabIndex = 1;
            // 
            // IsHorizontalCheckBox
            // 
            this.IsHorizontalCheckBox.AutoSize = true;
            this.IsHorizontalCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsHorizontalCheckBox.Location = new System.Drawing.Point(316, 19);
            this.IsHorizontalCheckBox.Name = "IsHorizontalCheckBox";
            this.IsHorizontalCheckBox.Size = new System.Drawing.Size(95, 22);
            this.IsHorizontalCheckBox.TabIndex = 2;
            this.IsHorizontalCheckBox.Text = "Horizontal";
            this.IsHorizontalCheckBox.UseVisualStyleBackColor = true;
            // 
            // IsFillCheckBox
            // 
            this.IsFillCheckBox.AutoSize = true;
            this.IsFillCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsFillCheckBox.Location = new System.Drawing.Point(440, 20);
            this.IsFillCheckBox.Name = "IsFillCheckBox";
            this.IsFillCheckBox.Size = new System.Drawing.Size(45, 22);
            this.IsFillCheckBox.TabIndex = 3;
            this.IsFillCheckBox.Text = "Fill";
            this.IsFillCheckBox.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(66, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.CanvasPanel);
            this.Controls.Add(this.InputPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.InputPanel.ResumeLayout(false);
            this.InputPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel InputPanel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox IsFillCheckBox;
        private System.Windows.Forms.CheckBox IsHorizontalCheckBox;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel CanvasPanel;
    }
}


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
            this.button1 = new System.Windows.Forms.Button();
            this.SegmentsComboBox = new System.Windows.Forms.ComboBox();
            this.IsFillCheckBox = new System.Windows.Forms.CheckBox();
            this.IsHorizontalCheckBox = new System.Windows.Forms.CheckBox();
            this.SegmentNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.CanvasPanel = new System.Windows.Forms.Panel();
            this.InputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SegmentNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // InputPanel
            // 
            this.InputPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputPanel.Controls.Add(this.button1);
            this.InputPanel.Controls.Add(this.SegmentsComboBox);
            this.InputPanel.Controls.Add(this.IsFillCheckBox);
            this.InputPanel.Controls.Add(this.IsHorizontalCheckBox);
            this.InputPanel.Controls.Add(this.SegmentNumericUpDown);
            this.InputPanel.Controls.Add(this.label1);
            this.InputPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.InputPanel.Location = new System.Drawing.Point(0, 450);
            this.InputPanel.Margin = new System.Windows.Forms.Padding(4);
            this.InputPanel.Name = "InputPanel";
            this.InputPanel.Size = new System.Drawing.Size(921, 124);
            this.InputPanel.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(612, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 50);
            this.button1.TabIndex = 5;
            this.button1.Text = "Choose Color";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // SegmentsComboBox
            // 
            this.SegmentsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SegmentsComboBox.FormattingEnabled = true;
            this.SegmentsComboBox.Location = new System.Drawing.Point(83, 71);
            this.SegmentsComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.SegmentsComboBox.Name = "SegmentsComboBox";
            this.SegmentsComboBox.Size = new System.Drawing.Size(160, 28);
            this.SegmentsComboBox.TabIndex = 4;
            this.SegmentsComboBox.DropDown += new System.EventHandler(this.OnSegmentsComboBoxDropDown);
            // 
            // IsFillCheckBox
            // 
            this.IsFillCheckBox.AutoSize = true;
            this.IsFillCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsFillCheckBox.Location = new System.Drawing.Point(417, 70);
            this.IsFillCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.IsFillCheckBox.Name = "IsFillCheckBox";
            this.IsFillCheckBox.Size = new System.Drawing.Size(56, 28);
            this.IsFillCheckBox.TabIndex = 3;
            this.IsFillCheckBox.Text = "Fill";
            this.IsFillCheckBox.UseVisualStyleBackColor = true;
            // 
            // IsHorizontalCheckBox
            // 
            this.IsHorizontalCheckBox.AutoSize = true;
            this.IsHorizontalCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsHorizontalCheckBox.Location = new System.Drawing.Point(417, 25);
            this.IsHorizontalCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.IsHorizontalCheckBox.Name = "IsHorizontalCheckBox";
            this.IsHorizontalCheckBox.Size = new System.Drawing.Size(116, 28);
            this.IsHorizontalCheckBox.TabIndex = 2;
            this.IsHorizontalCheckBox.Text = "Horizontal";
            this.IsHorizontalCheckBox.UseVisualStyleBackColor = true;
            // 
            // SegmentNumericUpDown
            // 
            this.SegmentNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SegmentNumericUpDown.Location = new System.Drawing.Point(189, 23);
            this.SegmentNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.SegmentNumericUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.SegmentNumericUpDown.Name = "SegmentNumericUpDown";
            this.SegmentNumericUpDown.Size = new System.Drawing.Size(113, 29);
            this.SegmentNumericUpDown.TabIndex = 1;
            this.SegmentNumericUpDown.ValueChanged += new System.EventHandler(this.OnSegmentNumericUpDownValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "No of Segments";
            // 
            // CanvasPanel
            // 
            this.CanvasPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CanvasPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CanvasPanel.Location = new System.Drawing.Point(0, 0);
            this.CanvasPanel.Margin = new System.Windows.Forms.Padding(4);
            this.CanvasPanel.Name = "CanvasPanel";
            this.CanvasPanel.Size = new System.Drawing.Size(921, 450);
            this.CanvasPanel.TabIndex = 1;
            this.CanvasPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.OnCanvasPanelPaint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 574);
            this.Controls.Add(this.CanvasPanel);
            this.Controls.Add(this.InputPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.InputPanel.ResumeLayout(false);
            this.InputPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SegmentNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel InputPanel;
        private System.Windows.Forms.ComboBox SegmentsComboBox;
        private System.Windows.Forms.CheckBox IsFillCheckBox;
        private System.Windows.Forms.CheckBox IsHorizontalCheckBox;
        private System.Windows.Forms.NumericUpDown SegmentNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel CanvasPanel;
        private System.Windows.Forms.Button button1;
    }
}


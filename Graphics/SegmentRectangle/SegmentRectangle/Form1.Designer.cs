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
            this.AllCheckBox = new System.Windows.Forms.CheckBox();
            this.ColorSelectButton = new System.Windows.Forms.Button();
            this.ColorPanel = new System.Windows.Forms.Panel();
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
            this.InputPanel.Controls.Add(this.AllCheckBox);
            this.InputPanel.Controls.Add(this.ColorSelectButton);
            this.InputPanel.Controls.Add(this.ColorPanel);
            this.InputPanel.Controls.Add(this.SegmentsComboBox);
            this.InputPanel.Controls.Add(this.IsFillCheckBox);
            this.InputPanel.Controls.Add(this.IsHorizontalCheckBox);
            this.InputPanel.Controls.Add(this.SegmentNumericUpDown);
            this.InputPanel.Controls.Add(this.label1);
            this.InputPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.InputPanel.Location = new System.Drawing.Point(0, 365);
            this.InputPanel.Name = "InputPanel";
            this.InputPanel.Size = new System.Drawing.Size(653, 101);
            this.InputPanel.TabIndex = 0;
            // 
            // AllCheckBox
            // 
            this.AllCheckBox.AutoSize = true;
            this.AllCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllCheckBox.Location = new System.Drawing.Point(26, 57);
            this.AllCheckBox.Name = "AllCheckBox";
            this.AllCheckBox.Size = new System.Drawing.Size(41, 22);
            this.AllCheckBox.TabIndex = 7;
            this.AllCheckBox.Text = "all";
            this.AllCheckBox.UseVisualStyleBackColor = true;
            this.AllCheckBox.CheckedChanged += new System.EventHandler(this.OnAllCheckBoxCheckChanged);
            // 
            // ColorSelectButton
            // 
            this.ColorSelectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorSelectButton.Location = new System.Drawing.Point(471, 20);
            this.ColorSelectButton.Margin = new System.Windows.Forms.Padding(2);
            this.ColorSelectButton.Name = "ColorSelectButton";
            this.ColorSelectButton.Size = new System.Drawing.Size(87, 44);
            this.ColorSelectButton.TabIndex = 5;
            this.ColorSelectButton.Text = "Choose Color";
            this.ColorSelectButton.UseVisualStyleBackColor = true;
            this.ColorSelectButton.Click += new System.EventHandler(this.OnColorSelectButtonClicked);
            // 
            // ColorPanel
            // 
            this.ColorPanel.Location = new System.Drawing.Point(561, 31);
            this.ColorPanel.Margin = new System.Windows.Forms.Padding(1, 1, 1, 3);
            this.ColorPanel.Name = "ColorPanel";
            this.ColorPanel.Padding = new System.Windows.Forms.Padding(1);
            this.ColorPanel.Size = new System.Drawing.Size(30, 23);
            this.ColorPanel.TabIndex = 6;
            this.ColorPanel.Click += new System.EventHandler(this.OnColorSelectButtonClicked);
            // 
            // SegmentsComboBox
            // 
            this.SegmentsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SegmentsComboBox.FormattingEnabled = true;
            this.SegmentsComboBox.Location = new System.Drawing.Point(106, 57);
            this.SegmentsComboBox.Name = "SegmentsComboBox";
            this.SegmentsComboBox.Size = new System.Drawing.Size(121, 25);
            this.SegmentsComboBox.TabIndex = 4;
            this.SegmentsComboBox.SelectedValueChanged += new System.EventHandler(this.OnSegmentComboBoxSelectedValueChanged);
            // 
            // IsFillCheckBox
            // 
            this.IsFillCheckBox.AutoSize = true;
            this.IsFillCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsFillCheckBox.Location = new System.Drawing.Point(313, 57);
            this.IsFillCheckBox.Name = "IsFillCheckBox";
            this.IsFillCheckBox.Size = new System.Drawing.Size(45, 22);
            this.IsFillCheckBox.TabIndex = 3;
            this.IsFillCheckBox.Text = "Fill";
            this.IsFillCheckBox.UseVisualStyleBackColor = true;
            this.IsFillCheckBox.CheckedChanged += new System.EventHandler(this.OnFillCheckBoxChanged);
            // 
            // IsHorizontalCheckBox
            // 
            this.IsHorizontalCheckBox.AutoSize = true;
            this.IsHorizontalCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsHorizontalCheckBox.Location = new System.Drawing.Point(313, 20);
            this.IsHorizontalCheckBox.Name = "IsHorizontalCheckBox";
            this.IsHorizontalCheckBox.Size = new System.Drawing.Size(95, 22);
            this.IsHorizontalCheckBox.TabIndex = 2;
            this.IsHorizontalCheckBox.Text = "Horizontal";
            this.IsHorizontalCheckBox.UseVisualStyleBackColor = true;
            this.IsHorizontalCheckBox.CheckedChanged += new System.EventHandler(this.OnHorizontalCheckBoxCheckChanged);
            // 
            // SegmentNumericUpDown
            // 
            this.SegmentNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SegmentNumericUpDown.Location = new System.Drawing.Point(142, 19);
            this.SegmentNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SegmentNumericUpDown.Name = "SegmentNumericUpDown";
            this.SegmentNumericUpDown.Size = new System.Drawing.Size(85, 24);
            this.SegmentNumericUpDown.TabIndex = 1;
            this.SegmentNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SegmentNumericUpDown.ValueChanged += new System.EventHandler(this.OnSegmentNumericUpDownValueChanged);
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
            // CanvasPanel
            // 
            this.CanvasPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CanvasPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CanvasPanel.Location = new System.Drawing.Point(0, 0);
            this.CanvasPanel.Name = "CanvasPanel";
            this.CanvasPanel.Size = new System.Drawing.Size(653, 365);
            this.CanvasPanel.TabIndex = 1;
            this.CanvasPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.OnCanvasPanelPaint);
            this.CanvasPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnCanvasPanelMouseDown);
            this.CanvasPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnCanvasPanelMouseMove);
            this.CanvasPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnCanvasPanelMouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 466);
            this.Controls.Add(this.CanvasPanel);
            this.Controls.Add(this.InputPanel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button ColorSelectButton;
        private System.Windows.Forms.Panel ColorPanel;
        private System.Windows.Forms.CheckBox AllCheckBox;
    }
}


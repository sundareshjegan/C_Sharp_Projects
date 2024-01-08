namespace ShapeShift
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
            this.inputPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.heightInputBox = new System.Windows.Forms.NumericUpDown();
            this.widthInputBox = new System.Windows.Forms.NumericUpDown();
            this.canvasPanel = new System.Windows.Forms.Panel();
            this.inputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heightInputBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthInputBox)).BeginInit();
            this.SuspendLayout();
            // 
            // inputPanel
            // 
            this.inputPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputPanel.Controls.Add(this.button1);
            this.inputPanel.Controls.Add(this.label2);
            this.inputPanel.Controls.Add(this.label1);
            this.inputPanel.Controls.Add(this.heightInputBox);
            this.inputPanel.Controls.Add(this.widthInputBox);
            this.inputPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.inputPanel.Location = new System.Drawing.Point(0, 0);
            this.inputPanel.Name = "inputPanel";
            this.inputPanel.Size = new System.Drawing.Size(286, 561);
            this.inputPanel.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(84, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnCreateButtonClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(22, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Height";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(29, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Width";
            // 
            // heightInputBox
            // 
            this.heightInputBox.BackColor = System.Drawing.SystemColors.Window;
            this.heightInputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.heightInputBox.Location = new System.Drawing.Point(109, 171);
            this.heightInputBox.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.heightInputBox.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.heightInputBox.Name = "heightInputBox";
            this.heightInputBox.Size = new System.Drawing.Size(120, 31);
            this.heightInputBox.TabIndex = 0;
            this.heightInputBox.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // widthInputBox
            // 
            this.widthInputBox.BackColor = System.Drawing.SystemColors.Window;
            this.widthInputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.widthInputBox.Location = new System.Drawing.Point(109, 117);
            this.widthInputBox.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.widthInputBox.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.widthInputBox.Name = "widthInputBox";
            this.widthInputBox.Size = new System.Drawing.Size(120, 31);
            this.widthInputBox.TabIndex = 0;
            this.widthInputBox.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // canvasPanel
            // 
            this.canvasPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.canvasPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvasPanel.Location = new System.Drawing.Point(286, 0);
            this.canvasPanel.Name = "canvasPanel";
            this.canvasPanel.Size = new System.Drawing.Size(598, 561);
            this.canvasPanel.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.canvasPanel);
            this.Controls.Add(this.inputPanel);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.inputPanel.ResumeLayout(false);
            this.inputPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heightInputBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthInputBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel inputPanel;
        private System.Windows.Forms.Panel canvasPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown heightInputBox;
        private System.Windows.Forms.NumericUpDown widthInputBox;
        private System.Windows.Forms.Button button1;
    }
}


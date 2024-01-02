namespace FormsPractice
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
            this.button1 = new System.Windows.Forms.Button();
            this.createPanelButton = new System.Windows.Forms.Button();
            this.colsTB = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.rowsTB = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.canvasPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colsTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowsTB)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.createPanelButton);
            this.panel1.Controls.Add(this.colsTB);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.rowsTB);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(820, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 681);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(127, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 59);
            this.button1.TabIndex = 5;
            this.button1.Text = "Delete Panels";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.OnClearButtonClicked);
            // 
            // createPanelButton
            // 
            this.createPanelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPanelButton.Location = new System.Drawing.Point(127, 364);
            this.createPanelButton.Margin = new System.Windows.Forms.Padding(4);
            this.createPanelButton.Name = "createPanelButton";
            this.createPanelButton.Size = new System.Drawing.Size(155, 59);
            this.createPanelButton.TabIndex = 4;
            this.createPanelButton.Text = "Create Panels";
            this.createPanelButton.UseVisualStyleBackColor = true;
            this.createPanelButton.Visible = false;
            this.createPanelButton.Click += new System.EventHandler(this.OnCreateButtonClicked);
            // 
            // colsTB
            // 
            this.colsTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colsTB.Location = new System.Drawing.Point(55, 215);
            this.colsTB.Margin = new System.Windows.Forms.Padding(4);
            this.colsTB.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.colsTB.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.colsTB.Name = "colsTB";
            this.colsTB.Size = new System.Drawing.Size(292, 37);
            this.colsTB.TabIndex = 3;
            this.colsTB.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.colsTB.ValueChanged += new System.EventHandler(this.OnNumericUpDownColsChanged);
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(113, 155);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(7, 6, 7, 0);
            this.label2.Size = new System.Drawing.Size(155, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Cols";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // rowsTB
            // 
            this.rowsTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowsTB.Location = new System.Drawing.Point(55, 71);
            this.rowsTB.Margin = new System.Windows.Forms.Padding(4);
            this.rowsTB.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.rowsTB.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rowsTB.Name = "rowsTB";
            this.rowsTB.Size = new System.Drawing.Size(292, 37);
            this.rowsTB.TabIndex = 1;
            this.rowsTB.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rowsTB.ValueChanged += new System.EventHandler(this.OnNumbericUpDownRowsChanged);
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(7, 6, 7, 0);
            this.label1.Size = new System.Drawing.Size(169, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Rows";
            this.label1.Click += new System.EventHandler(this.OnLabel1Clicked);
            // 
            // canvasPanel
            // 
            this.canvasPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.canvasPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvasPanel.Location = new System.Drawing.Point(0, 0);
            this.canvasPanel.Margin = new System.Windows.Forms.Padding(4);
            this.canvasPanel.Name = "canvasPanel";
            this.canvasPanel.Size = new System.Drawing.Size(820, 681);
            this.canvasPanel.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1240, 681);
            this.Controls.Add(this.canvasPanel);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colsTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowsTB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown colsTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown rowsTB;
        private System.Windows.Forms.Button createPanelButton;
        private System.Windows.Forms.Panel canvasPanel;
        private System.Windows.Forms.Button button1;
    }
}


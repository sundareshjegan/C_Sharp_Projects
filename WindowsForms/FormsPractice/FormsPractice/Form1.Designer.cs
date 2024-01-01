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
            this.panel1.Controls.Add(this.createPanelButton);
            this.panel1.Controls.Add(this.colsTB);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.rowsTB);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(614, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 553);
            this.panel1.TabIndex = 0;
            // 
            // createPanelButton
            // 
            this.createPanelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPanelButton.Location = new System.Drawing.Point(90, 261);
            this.createPanelButton.Name = "createPanelButton";
            this.createPanelButton.Size = new System.Drawing.Size(127, 48);
            this.createPanelButton.TabIndex = 4;
            this.createPanelButton.Text = "Create Panels";
            this.createPanelButton.UseVisualStyleBackColor = true;
            this.createPanelButton.Click += new System.EventHandler(this.OnCreateButtonClicked);
            // 
            // colsTB
            // 
            this.colsTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colsTB.Location = new System.Drawing.Point(41, 175);
            this.colsTB.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.colsTB.Name = "colsTB";
            this.colsTB.Size = new System.Drawing.Size(219, 31);
            this.colsTB.TabIndex = 3;
            this.colsTB.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 126);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label2.Size = new System.Drawing.Size(122, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Cols";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // rowsTB
            // 
            this.rowsTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowsTB.Location = new System.Drawing.Point(41, 58);
            this.rowsTB.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.rowsTB.Name = "rowsTB";
            this.rowsTB.Size = new System.Drawing.Size(219, 31);
            this.rowsTB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 9);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label1.Size = new System.Drawing.Size(132, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Rows";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // canvasPanel
            // 
            this.canvasPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.canvasPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvasPanel.Location = new System.Drawing.Point(0, 0);
            this.canvasPanel.Name = "canvasPanel";
            this.canvasPanel.Size = new System.Drawing.Size(614, 553);
            this.canvasPanel.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(930, 553);
            this.Controls.Add(this.canvasPanel);
            this.Controls.Add(this.panel1);
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
    }
}


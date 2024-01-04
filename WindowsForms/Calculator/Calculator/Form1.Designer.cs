namespace Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.displayPanel = new System.Windows.Forms.Panel();
            this.displayBox = new System.Windows.Forms.TextBox();
            this.btMod = new System.Windows.Forms.Button();
            this.btOpenBrace = new System.Windows.Forms.Button();
            this.btCloseBrace = new System.Windows.Forms.Button();
            this.btPower = new System.Windows.Forms.Button();
            this.bt7 = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.btSub = new System.Windows.Forms.Button();
            this.btMul = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.btDot = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.btDiv = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.btEquals = new System.Windows.Forms.Button();
            this.bt0 = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.btBackSlash = new System.Windows.Forms.Button();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.displayPanel.SuspendLayout();
            this.buttonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // displayPanel
            // 
            this.displayPanel.Controls.Add(this.displayBox);
            this.displayPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.displayPanel.Location = new System.Drawing.Point(0, 0);
            this.displayPanel.Name = "displayPanel";
            this.displayPanel.Size = new System.Drawing.Size(294, 98);
            this.displayPanel.TabIndex = 0;
            // 
            // displayBox
            // 
            this.displayBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.displayBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.displayBox.Font = new System.Drawing.Font("Palatino Linotype", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayBox.ForeColor = System.Drawing.SystemColors.Window;
            this.displayBox.Location = new System.Drawing.Point(0, 0);
            this.displayBox.Multiline = true;
            this.displayBox.Name = "displayBox";
            this.displayBox.ReadOnly = true;
            this.displayBox.Size = new System.Drawing.Size(294, 98);
            this.displayBox.TabIndex = 0;
            this.displayBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.displayBox.TextChanged += new System.EventHandler(this.displayBox_TextChanged);
            this.displayBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.displayBox_KeyPress);
            // 
            // btMod
            // 
            this.btMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMod.Location = new System.Drawing.Point(5, 62);
            this.btMod.Name = "btMod";
            this.btMod.Size = new System.Drawing.Size(65, 50);
            this.btMod.TabIndex = 0;
            this.btMod.Text = "%";
            this.btMod.UseVisualStyleBackColor = true;
            // 
            // btOpenBrace
            // 
            this.btOpenBrace.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOpenBrace.Location = new System.Drawing.Point(147, 62);
            this.btOpenBrace.Name = "btOpenBrace";
            this.btOpenBrace.Size = new System.Drawing.Size(65, 50);
            this.btOpenBrace.TabIndex = 0;
            this.btOpenBrace.Text = "(";
            this.btOpenBrace.UseVisualStyleBackColor = true;
            this.btOpenBrace.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // btCloseBrace
            // 
            this.btCloseBrace.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCloseBrace.Location = new System.Drawing.Point(218, 62);
            this.btCloseBrace.Name = "btCloseBrace";
            this.btCloseBrace.Size = new System.Drawing.Size(65, 50);
            this.btCloseBrace.TabIndex = 0;
            this.btCloseBrace.Text = ")";
            this.btCloseBrace.UseVisualStyleBackColor = true;
            this.btCloseBrace.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // btPower
            // 
            this.btPower.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPower.Location = new System.Drawing.Point(76, 62);
            this.btPower.Name = "btPower";
            this.btPower.Size = new System.Drawing.Size(65, 50);
            this.btPower.TabIndex = 3;
            this.btPower.Text = "^";
            this.btPower.UseVisualStyleBackColor = true;
            // 
            // bt7
            // 
            this.bt7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bt7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt7.Location = new System.Drawing.Point(5, 130);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(65, 50);
            this.bt7.TabIndex = 4;
            this.bt7.Text = "7";
            this.bt7.UseVisualStyleBackColor = true;
            this.bt7.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // btAdd
            // 
            this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.Location = new System.Drawing.Point(218, 130);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(65, 50);
            this.btAdd.TabIndex = 5;
            this.btAdd.Text = "+";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // bt9
            // 
            this.bt9.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bt9.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt9.Location = new System.Drawing.Point(147, 130);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(65, 50);
            this.bt9.TabIndex = 6;
            this.bt9.Text = "9";
            this.bt9.UseVisualStyleBackColor = true;
            this.bt9.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // bt8
            // 
            this.bt8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bt8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt8.Location = new System.Drawing.Point(76, 130);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(65, 50);
            this.bt8.TabIndex = 7;
            this.bt8.Text = "8";
            this.bt8.UseVisualStyleBackColor = true;
            this.bt8.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // bt4
            // 
            this.bt4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bt4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt4.Location = new System.Drawing.Point(5, 199);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(65, 50);
            this.bt4.TabIndex = 8;
            this.bt4.Text = "4";
            this.bt4.UseVisualStyleBackColor = true;
            this.bt4.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // bt1
            // 
            this.bt1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bt1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt1.Location = new System.Drawing.Point(5, 265);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(65, 50);
            this.bt1.TabIndex = 8;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = false;
            this.bt1.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // btSub
            // 
            this.btSub.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSub.Location = new System.Drawing.Point(218, 199);
            this.btSub.Name = "btSub";
            this.btSub.Size = new System.Drawing.Size(65, 50);
            this.btSub.TabIndex = 9;
            this.btSub.Text = "-";
            this.btSub.UseVisualStyleBackColor = true;
            this.btSub.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // btMul
            // 
            this.btMul.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btMul.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMul.Location = new System.Drawing.Point(218, 265);
            this.btMul.Name = "btMul";
            this.btMul.Size = new System.Drawing.Size(65, 50);
            this.btMul.TabIndex = 9;
            this.btMul.Text = "x";
            this.btMul.UseVisualStyleBackColor = true;
            this.btMul.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // bt6
            // 
            this.bt6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bt6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt6.Location = new System.Drawing.Point(147, 199);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(65, 50);
            this.bt6.TabIndex = 10;
            this.bt6.Text = "6";
            this.bt6.UseVisualStyleBackColor = true;
            this.bt6.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // bt3
            // 
            this.bt3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt3.Location = new System.Drawing.Point(147, 265);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(65, 50);
            this.bt3.TabIndex = 10;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // btDot
            // 
            this.btDot.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDot.Location = new System.Drawing.Point(5, 332);
            this.btDot.Name = "btDot";
            this.btDot.Size = new System.Drawing.Size(65, 50);
            this.btDot.TabIndex = 4;
            this.btDot.Text = ".";
            this.btDot.UseVisualStyleBackColor = true;
            this.btDot.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // bt5
            // 
            this.bt5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bt5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt5.Location = new System.Drawing.Point(76, 199);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(65, 50);
            this.bt5.TabIndex = 11;
            this.bt5.Text = "5";
            this.bt5.UseVisualStyleBackColor = true;
            this.bt5.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // btDiv
            // 
            this.btDiv.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDiv.Location = new System.Drawing.Point(218, 332);
            this.btDiv.Name = "btDiv";
            this.btDiv.Size = new System.Drawing.Size(65, 50);
            this.btDiv.TabIndex = 5;
            this.btDiv.Text = "÷";
            this.btDiv.UseVisualStyleBackColor = true;
            this.btDiv.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // bt2
            // 
            this.bt2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt2.Location = new System.Drawing.Point(76, 265);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(65, 50);
            this.bt2.TabIndex = 11;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // btEquals
            // 
            this.btEquals.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btEquals.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEquals.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btEquals.Location = new System.Drawing.Point(147, 332);
            this.btEquals.Name = "btEquals";
            this.btEquals.Size = new System.Drawing.Size(65, 50);
            this.btEquals.TabIndex = 6;
            this.btEquals.Text = "=";
            this.btEquals.UseVisualStyleBackColor = false;
            this.btEquals.Click += new System.EventHandler(this.OnEqualsButtonClicked);
            // 
            // bt0
            // 
            this.bt0.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bt0.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt0.Location = new System.Drawing.Point(76, 332);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(65, 50);
            this.bt0.TabIndex = 7;
            this.bt0.Text = "0";
            this.bt0.UseVisualStyleBackColor = true;
            this.bt0.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // btClear
            // 
            this.btClear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClear.Location = new System.Drawing.Point(5, 6);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(136, 50);
            this.btClear.TabIndex = 2;
            this.btClear.Text = "C";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.OnClearButtonClicked);
            // 
            // btBackSlash
            // 
            this.btBackSlash.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btBackSlash.BackgroundImage")));
            this.btBackSlash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btBackSlash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btBackSlash.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btBackSlash.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBackSlash.Location = new System.Drawing.Point(150, 6);
            this.btBackSlash.Name = "btBackSlash";
            this.btBackSlash.Size = new System.Drawing.Size(133, 50);
            this.btBackSlash.TabIndex = 1;
            this.btBackSlash.Text = "⌫";
            this.btBackSlash.UseVisualStyleBackColor = true;
            this.btBackSlash.Click += new System.EventHandler(this.OnBackslashButtonClicked);
            // 
            // buttonPanel
            // 
            this.buttonPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonPanel.Controls.Add(this.btBackSlash);
            this.buttonPanel.Controls.Add(this.btClear);
            this.buttonPanel.Controls.Add(this.bt0);
            this.buttonPanel.Controls.Add(this.btEquals);
            this.buttonPanel.Controls.Add(this.bt2);
            this.buttonPanel.Controls.Add(this.btDiv);
            this.buttonPanel.Controls.Add(this.bt5);
            this.buttonPanel.Controls.Add(this.btDot);
            this.buttonPanel.Controls.Add(this.bt3);
            this.buttonPanel.Controls.Add(this.bt6);
            this.buttonPanel.Controls.Add(this.btMul);
            this.buttonPanel.Controls.Add(this.btSub);
            this.buttonPanel.Controls.Add(this.bt1);
            this.buttonPanel.Controls.Add(this.bt4);
            this.buttonPanel.Controls.Add(this.bt8);
            this.buttonPanel.Controls.Add(this.bt9);
            this.buttonPanel.Controls.Add(this.btAdd);
            this.buttonPanel.Controls.Add(this.bt7);
            this.buttonPanel.Controls.Add(this.btPower);
            this.buttonPanel.Controls.Add(this.btCloseBrace);
            this.buttonPanel.Controls.Add(this.btOpenBrace);
            this.buttonPanel.Controls.Add(this.btMod);
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPanel.Location = new System.Drawing.Point(0, 98);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(294, 389);
            this.buttonPanel.TabIndex = 1;
            this.buttonPanel.Resize += new System.EventHandler(this.OnButtonPanelResized);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 487);
            this.Controls.Add(this.buttonPanel);
            this.Controls.Add(this.displayPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyPressed);
            this.Resize += new System.EventHandler(this.OnFormResized);
            this.displayPanel.ResumeLayout(false);
            this.displayPanel.PerformLayout();
            this.buttonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel displayPanel;
        private System.Windows.Forms.TextBox displayBox;
        private System.Windows.Forms.Button btMod;
        private System.Windows.Forms.Button btOpenBrace;
        private System.Windows.Forms.Button btCloseBrace;
        private System.Windows.Forms.Button btPower;
        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button bt9;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button btSub;
        private System.Windows.Forms.Button btMul;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button btDot;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button btDiv;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button btEquals;
        private System.Windows.Forms.Button bt0;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btBackSlash;
        private System.Windows.Forms.Panel buttonPanel;
    }
}


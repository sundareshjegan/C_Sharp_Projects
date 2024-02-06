namespace ProfileManagement
{
    partial class InputUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.mailTB = new System.Windows.Forms.TextBox();
            this.BrowseBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.imgUrlTB = new System.Windows.Forms.TextBox();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dobTB = new System.Windows.Forms.DateTimePicker();
            this.profileBox = new System.Windows.Forms.PictureBox();
            this.phoneTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.profileBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(38, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "DOB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(38, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(35, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "E-mail";
            // 
            // nameTB
            // 
            this.nameTB.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nameTB.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTB.Location = new System.Drawing.Point(133, 223);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(236, 28);
            this.nameTB.TabIndex = 1;
            this.nameTB.TextChanged += new System.EventHandler(this.OnTextBoxTextChanged);
            this.nameTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnNameTBKeyPress);
            // 
            // mailTB
            // 
            this.mailTB.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailTB.Location = new System.Drawing.Point(133, 357);
            this.mailTB.Name = "mailTB";
            this.mailTB.Size = new System.Drawing.Size(236, 28);
            this.mailTB.TabIndex = 1;
            this.mailTB.TextChanged += new System.EventHandler(this.OnTextBoxTextChanged);
            // 
            // BrowseBtn
            // 
            this.BrowseBtn.Location = new System.Drawing.Point(375, 407);
            this.BrowseBtn.Name = "BrowseBtn";
            this.BrowseBtn.Size = new System.Drawing.Size(64, 22);
            this.BrowseBtn.TabIndex = 2;
            this.BrowseBtn.Text = "Browse";
            this.BrowseBtn.UseVisualStyleBackColor = true;
            this.BrowseBtn.Click += new System.EventHandler(this.OnBrouseBtnClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(5, 408);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Profile Image";
            // 
            // imgUrlTB
            // 
            this.imgUrlTB.BackColor = System.Drawing.Color.White;
            this.imgUrlTB.Enabled = false;
            this.imgUrlTB.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imgUrlTB.Location = new System.Drawing.Point(133, 401);
            this.imgUrlTB.Name = "imgUrlTB";
            this.imgUrlTB.Size = new System.Drawing.Size(236, 28);
            this.imgUrlTB.TabIndex = 1;
            this.imgUrlTB.TextChanged += new System.EventHandler(this.OnTextBoxTextChanged);
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.SubmitBtn.Enabled = false;
            this.SubmitBtn.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitBtn.Location = new System.Drawing.Point(168, 465);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(102, 34);
            this.SubmitBtn.TabIndex = 3;
            this.SubmitBtn.Text = "SUBMIT";
            this.SubmitBtn.UseVisualStyleBackColor = false;
            this.SubmitBtn.UseWaitCursor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.OnSubmitBtnClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(109, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(250, 41);
            this.label6.TabIndex = 0;
            this.label6.Text = "USER DETAILS";
            // 
            // dobTB
            // 
            this.dobTB.CalendarFont = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobTB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobTB.Location = new System.Drawing.Point(133, 268);
            this.dobTB.Name = "dobTB";
            this.dobTB.Size = new System.Drawing.Size(236, 25);
            this.dobTB.TabIndex = 4;
            // 
            // profileBox
            // 
            this.profileBox.BackColor = System.Drawing.Color.Transparent;
            this.profileBox.BackgroundImage = global::ProfileManagement.Properties.Resources.addUserImage;
            this.profileBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.profileBox.Location = new System.Drawing.Point(168, 71);
            this.profileBox.Name = "profileBox";
            this.profileBox.Size = new System.Drawing.Size(135, 135);
            this.profileBox.TabIndex = 6;
            this.profileBox.TabStop = false;
            this.profileBox.Click += new System.EventHandler(this.OnProfileBoxClicked);
            // 
            // phoneTB
            // 
            this.phoneTB.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.phoneTB.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTB.Location = new System.Drawing.Point(133, 311);
            this.phoneTB.Name = "phoneTB";
            this.phoneTB.Size = new System.Drawing.Size(236, 28);
            this.phoneTB.TabIndex = 1;
            this.phoneTB.TextChanged += new System.EventHandler(this.OnTextBoxTextChanged);
            this.phoneTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnPhoneTBKeyPress);
            // 
            // InputUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.profileBox);
            this.Controls.Add(this.dobTB);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.BrowseBtn);
            this.Controls.Add(this.imgUrlTB);
            this.Controls.Add(this.mailTB);
            this.Controls.Add(this.phoneTB);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "InputUC";
            this.Size = new System.Drawing.Size(449, 511);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.InputUC_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.profileBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.TextBox mailTB;
        private System.Windows.Forms.Button BrowseBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox imgUrlTB;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dobTB;
        private System.Windows.Forms.PictureBox profileBox;
        private System.Windows.Forms.TextBox phoneTB;
    }
}

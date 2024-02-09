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
            this.nameLabel = new System.Windows.Forms.Label();
            this.dobLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.mailTB = new System.Windows.Forms.TextBox();
            this.BrowseBtn = new System.Windows.Forms.Button();
            this.profileLabel = new System.Windows.Forms.Label();
            this.imgUrlTB = new System.Windows.Forms.TextBox();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dobTB = new System.Windows.Forms.DateTimePicker();
            this.profileBox = new System.Windows.Forms.PictureBox();
            this.phoneTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.profileBox)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(38, 230);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(57, 21);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.BackColor = System.Drawing.Color.Transparent;
            this.dobLabel.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobLabel.ForeColor = System.Drawing.Color.White;
            this.dobLabel.Location = new System.Drawing.Point(38, 273);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(45, 21);
            this.dobLabel.TabIndex = 0;
            this.dobLabel.Text = "DOB";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.BackColor = System.Drawing.Color.Transparent;
            this.phoneLabel.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.ForeColor = System.Drawing.Color.White;
            this.phoneLabel.Location = new System.Drawing.Point(38, 318);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(60, 21);
            this.phoneLabel.TabIndex = 0;
            this.phoneLabel.Text = "Phone";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailLabel.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.Color.White;
            this.emailLabel.Location = new System.Drawing.Point(35, 364);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(63, 21);
            this.emailLabel.TabIndex = 0;
            this.emailLabel.Text = "E-mail";
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
            // profileLabel
            // 
            this.profileLabel.AutoSize = true;
            this.profileLabel.BackColor = System.Drawing.Color.Transparent;
            this.profileLabel.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileLabel.ForeColor = System.Drawing.Color.White;
            this.profileLabel.Location = new System.Drawing.Point(5, 408);
            this.profileLabel.Name = "profileLabel";
            this.profileLabel.Size = new System.Drawing.Size(122, 21);
            this.profileLabel.TabIndex = 0;
            this.profileLabel.Text = "Profile Image";
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
            this.SubmitBtn.Location = new System.Drawing.Point(168, 454);
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
            this.Controls.Add(this.profileLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.dobLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nameLabel);
            this.DoubleBuffered = true;
            this.Name = "InputUC";
            this.Size = new System.Drawing.Size(449, 511);
            this.Load += new System.EventHandler(this.OnTextBoxTextChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.InputUC_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.profileBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label dobLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.TextBox mailTB;
        private System.Windows.Forms.Button BrowseBtn;
        private System.Windows.Forms.Label profileLabel;
        private System.Windows.Forms.TextBox imgUrlTB;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dobTB;
        private System.Windows.Forms.PictureBox profileBox;
        private System.Windows.Forms.TextBox phoneTB;
    }
}

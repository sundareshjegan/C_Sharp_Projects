namespace ProfileManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.displayTable = new System.Windows.Forms.DataGridView();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profileImage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optionsPanel = new System.Windows.Forms.Panel();
            this.importHoverLabel = new System.Windows.Forms.Label();
            this.userCard = new System.Windows.Forms.Panel();
            this.photoPanel = new System.Windows.Forms.Panel();
            this.profilePicBox = new System.Windows.Forms.PictureBox();
            this.loadBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.addColBtn = new System.Windows.Forms.Button();
            this.AddRowBtn = new System.Windows.Forms.Button();
            this.saveHoverLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.displayTable)).BeginInit();
            this.optionsPanel.SuspendLayout();
            this.photoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // displayTable
            // 
            this.displayTable.AllowUserToAddRows = false;
            this.displayTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.displayTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.displayTable.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.displayTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.displayTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.displayTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.email,
            this.name,
            this.dob,
            this.phone,
            this.profileImage});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.displayTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.displayTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.displayTable.Location = new System.Drawing.Point(275, 0);
            this.displayTable.Name = "displayTable";
            this.displayTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.displayTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.displayTable.RowHeadersVisible = false;
            this.displayTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayTable.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.displayTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.displayTable.Size = new System.Drawing.Size(587, 604);
            this.displayTable.TabIndex = 1;
            this.displayTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnCellClick);
            this.displayTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnCellDoubleClicked);
            this.displayTable.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.displayTable_CellMouseClick);
            // 
            // email
            // 
            this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.email.HeaderText = "E-mail";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.email.ToolTipText = "email-id";
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.name.Width = 58;
            // 
            // dob
            // 
            this.dob.HeaderText = "DOB";
            this.dob.Name = "dob";
            this.dob.ReadOnly = true;
            this.dob.Width = 67;
            // 
            // phone
            // 
            this.phone.HeaderText = "Phone no";
            this.phone.Name = "phone";
            this.phone.Width = 106;
            // 
            // profileImage
            // 
            this.profileImage.HeaderText = "ProfileImage";
            this.profileImage.Name = "profileImage";
            this.profileImage.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.profileImage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.profileImage.Width = 110;
            // 
            // optionsPanel
            // 
            this.optionsPanel.BackgroundImage = global::ProfileManagement.Properties.Resources.greenPurple;
            this.optionsPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.optionsPanel.Controls.Add(this.saveHoverLabel);
            this.optionsPanel.Controls.Add(this.importHoverLabel);
            this.optionsPanel.Controls.Add(this.userCard);
            this.optionsPanel.Controls.Add(this.photoPanel);
            this.optionsPanel.Controls.Add(this.loadBtn);
            this.optionsPanel.Controls.Add(this.saveBtn);
            this.optionsPanel.Controls.Add(this.addColBtn);
            this.optionsPanel.Controls.Add(this.AddRowBtn);
            this.optionsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.optionsPanel.Location = new System.Drawing.Point(0, 0);
            this.optionsPanel.Name = "optionsPanel";
            this.optionsPanel.Size = new System.Drawing.Size(275, 604);
            this.optionsPanel.TabIndex = 0;
            this.optionsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.optionsPanel_Paint);
            // 
            // importHoverLabel
            // 
            this.importHoverLabel.AutoSize = true;
            this.importHoverLabel.BackColor = System.Drawing.Color.Transparent;
            this.importHoverLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importHoverLabel.ForeColor = System.Drawing.Color.White;
            this.importHoverLabel.Location = new System.Drawing.Point(12, 61);
            this.importHoverLabel.Name = "importHoverLabel";
            this.importHoverLabel.Size = new System.Drawing.Size(0, 16);
            this.importHoverLabel.TabIndex = 4;
            // 
            // userCard
            // 
            this.userCard.Location = new System.Drawing.Point(3, 287);
            this.userCard.Name = "userCard";
            this.userCard.Size = new System.Drawing.Size(272, 228);
            this.userCard.TabIndex = 1;
            this.userCard.Visible = false;
            // 
            // photoPanel
            // 
            this.photoPanel.Controls.Add(this.profilePicBox);
            this.photoPanel.Location = new System.Drawing.Point(3, 167);
            this.photoPanel.Name = "photoPanel";
            this.photoPanel.Size = new System.Drawing.Size(272, 134);
            this.photoPanel.TabIndex = 3;
            this.photoPanel.Visible = false;
            // 
            // profilePicBox
            // 
            this.profilePicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.profilePicBox.Location = new System.Drawing.Point(88, 3);
            this.profilePicBox.Name = "profilePicBox";
            this.profilePicBox.Size = new System.Drawing.Size(100, 102);
            this.profilePicBox.TabIndex = 2;
            this.profilePicBox.TabStop = false;
            // 
            // loadBtn
            // 
            this.loadBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loadBtn.BackgroundImage")));
            this.loadBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loadBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loadBtn.Location = new System.Drawing.Point(12, 12);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(50, 46);
            this.loadBtn.TabIndex = 2;
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.OnLoadBtnClicked);
            this.loadBtn.MouseEnter += new System.EventHandler(this.OnButtonMouseEnter);
            this.loadBtn.MouseLeave += new System.EventHandler(this.OnButtonMouseLeave);
            // 
            // saveBtn
            // 
            this.saveBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("saveBtn.BackgroundImage")));
            this.saveBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.Location = new System.Drawing.Point(216, 12);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(53, 46);
            this.saveBtn.TabIndex = 2;
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.OnSaveBtnClicked);
            this.saveBtn.MouseEnter += new System.EventHandler(this.OnButtonMouseEnter);
            this.saveBtn.MouseLeave += new System.EventHandler(this.OnButtonMouseLeave);
            // 
            // addColBtn
            // 
            this.addColBtn.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addColBtn.Location = new System.Drawing.Point(135, 85);
            this.addColBtn.Name = "addColBtn";
            this.addColBtn.Size = new System.Drawing.Size(134, 32);
            this.addColBtn.TabIndex = 0;
            this.addColBtn.Text = "ADD COLUMN";
            this.addColBtn.UseVisualStyleBackColor = true;
            this.addColBtn.Click += new System.EventHandler(this.OnAddColBtnClicked);
            // 
            // AddRowBtn
            // 
            this.AddRowBtn.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddRowBtn.Location = new System.Drawing.Point(12, 85);
            this.AddRowBtn.Name = "AddRowBtn";
            this.AddRowBtn.Size = new System.Drawing.Size(114, 32);
            this.AddRowBtn.TabIndex = 0;
            this.AddRowBtn.Text = "ADD ROW";
            this.AddRowBtn.UseVisualStyleBackColor = true;
            this.AddRowBtn.Click += new System.EventHandler(this.OnAddRowBtnClicked);
            // 
            // saveHoverLabel
            // 
            this.saveHoverLabel.AutoSize = true;
            this.saveHoverLabel.BackColor = System.Drawing.Color.Transparent;
            this.saveHoverLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveHoverLabel.ForeColor = System.Drawing.Color.White;
            this.saveHoverLabel.Location = new System.Drawing.Point(203, 61);
            this.saveHoverLabel.Name = "saveHoverLabel";
            this.saveHoverLabel.Size = new System.Drawing.Size(0, 16);
            this.saveHoverLabel.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 604);
            this.Controls.Add(this.displayTable);
            this.Controls.Add(this.optionsPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OnFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.displayTable)).EndInit();
            this.optionsPanel.ResumeLayout(false);
            this.optionsPanel.PerformLayout();
            this.photoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profilePicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView displayTable;
        private System.Windows.Forms.Button addColBtn;
        private System.Windows.Forms.Button AddRowBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.PictureBox profilePicBox;
        private System.Windows.Forms.Panel userCard;
        private System.Windows.Forms.Panel photoPanel;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dob;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn profileImage;
        public System.Windows.Forms.Panel optionsPanel;
        private System.Windows.Forms.Label importHoverLabel;
        private System.Windows.Forms.Label saveHoverLabel;
    }
}


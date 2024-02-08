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
            this.photoPanel = new System.Windows.Forms.Panel();
            this.profilePicBox = new System.Windows.Forms.PictureBox();
            this.userCard = new System.Windows.Forms.Panel();
            this.saveBtn = new System.Windows.Forms.Button();
            this.addColBtn = new System.Windows.Forms.Button();
            this.AddRowBtn = new System.Windows.Forms.Button();
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
            this.displayTable.Size = new System.Drawing.Size(448, 720);
            this.displayTable.TabIndex = 1;
            this.displayTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnCellClick);
            this.displayTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnCellDoubleClicked);
            // 
            // email
            // 
            this.email.HeaderText = "E-mail";
            this.email.Name = "email";
            this.email.Width = 84;
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
            this.optionsPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("optionsPanel.BackgroundImage")));
            this.optionsPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.optionsPanel.Controls.Add(this.userCard);
            this.optionsPanel.Controls.Add(this.photoPanel);
            this.optionsPanel.Controls.Add(this.saveBtn);
            this.optionsPanel.Controls.Add(this.addColBtn);
            this.optionsPanel.Controls.Add(this.AddRowBtn);
            this.optionsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.optionsPanel.Location = new System.Drawing.Point(0, 0);
            this.optionsPanel.Name = "optionsPanel";
            this.optionsPanel.Size = new System.Drawing.Size(275, 720);
            this.optionsPanel.TabIndex = 0;
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
            // userCard
            // 
            this.userCard.Location = new System.Drawing.Point(3, 287);
            this.userCard.Name = "userCard";
            this.userCard.Size = new System.Drawing.Size(272, 228);
            this.userCard.TabIndex = 1;
            this.userCard.Visible = false;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(107, 123);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(63, 28);
            this.saveBtn.TabIndex = 2;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.OnSaveBtnClicked);
            // 
            // addColBtn
            // 
            this.addColBtn.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addColBtn.Location = new System.Drawing.Point(50, 85);
            this.addColBtn.Name = "addColBtn";
            this.addColBtn.Size = new System.Drawing.Size(175, 32);
            this.addColBtn.TabIndex = 0;
            this.addColBtn.Text = "ADD COLUMN";
            this.addColBtn.UseVisualStyleBackColor = true;
            this.addColBtn.Click += new System.EventHandler(this.OnAddColBtnClicked);
            // 
            // AddRowBtn
            // 
            this.AddRowBtn.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddRowBtn.Location = new System.Drawing.Point(50, 47);
            this.AddRowBtn.Name = "AddRowBtn";
            this.AddRowBtn.Size = new System.Drawing.Size(175, 32);
            this.AddRowBtn.TabIndex = 0;
            this.AddRowBtn.Text = "ADD ROW";
            this.AddRowBtn.UseVisualStyleBackColor = true;
            this.AddRowBtn.Click += new System.EventHandler(this.OnAddRowBtnClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 720);
            this.Controls.Add(this.displayTable);
            this.Controls.Add(this.optionsPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OnFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.displayTable)).EndInit();
            this.optionsPanel.ResumeLayout(false);
            this.photoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profilePicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel optionsPanel;
        private System.Windows.Forms.DataGridView displayTable;
        private System.Windows.Forms.Button addColBtn;
        private System.Windows.Forms.Button AddRowBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.PictureBox profilePicBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dob;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn profileImage;
        private System.Windows.Forms.Panel userCard;
        private System.Windows.Forms.Panel photoPanel;
    }
}


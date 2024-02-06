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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.displayTable = new System.Windows.Forms.DataGridView();
            this.profileImage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optionsPanel = new System.Windows.Forms.Panel();
            this.userCard = new System.Windows.Forms.Panel();
            this.addColBtn = new System.Windows.Forms.Button();
            this.AddRowBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.displayTable)).BeginInit();
            this.optionsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // displayTable
            // 
            this.displayTable.AllowUserToAddRows = false;
            this.displayTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.profileImage,
            this.name,
            this.dob,
            this.email,
            this.phone});
            this.displayTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.displayTable.Location = new System.Drawing.Point(224, 0);
            this.displayTable.Name = "displayTable";
            this.displayTable.RowHeadersVisible = false;
            this.displayTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.displayTable.Size = new System.Drawing.Size(499, 429);
            this.displayTable.TabIndex = 1;
            // 
            // profileImage
            // 
            this.profileImage.HeaderText = "Profile Image";
            this.profileImage.Name = "profileImage";
            this.profileImage.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.profileImage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dob
            // 
            this.dob.HeaderText = "DOB";
            this.dob.Name = "dob";
            this.dob.ReadOnly = true;
            // 
            // email
            // 
            this.email.HeaderText = "E-mail";
            this.email.Name = "email";
            // 
            // phone
            // 
            this.phone.HeaderText = "Phone no";
            this.phone.Name = "phone";
            // 
            // optionsPanel
            // 
            this.optionsPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("optionsPanel.BackgroundImage")));
            this.optionsPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.optionsPanel.Controls.Add(this.userCard);
            this.optionsPanel.Controls.Add(this.addColBtn);
            this.optionsPanel.Controls.Add(this.AddRowBtn);
            this.optionsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.optionsPanel.Location = new System.Drawing.Point(0, 0);
            this.optionsPanel.Name = "optionsPanel";
            this.optionsPanel.Size = new System.Drawing.Size(224, 429);
            this.optionsPanel.TabIndex = 0;
            // 
            // userCard
            // 
            this.userCard.Location = new System.Drawing.Point(12, 155);
            this.userCard.Name = "userCard";
            this.userCard.Size = new System.Drawing.Size(200, 262);
            this.userCard.TabIndex = 1;
            this.userCard.Visible = false;
            // 
            // addColBtn
            // 
            this.addColBtn.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addColBtn.Location = new System.Drawing.Point(26, 85);
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
            this.AddRowBtn.Location = new System.Drawing.Point(26, 47);
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
            this.ClientSize = new System.Drawing.Size(723, 429);
            this.Controls.Add(this.displayTable);
            this.Controls.Add(this.optionsPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.displayTable)).EndInit();
            this.optionsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel optionsPanel;
        private System.Windows.Forms.DataGridView displayTable;
        private System.Windows.Forms.Button addColBtn;
        private System.Windows.Forms.Button AddRowBtn;
        private System.Windows.Forms.Panel userCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn profileImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dob;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
    }
}


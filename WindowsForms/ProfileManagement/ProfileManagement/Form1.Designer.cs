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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.AddRowBtn = new System.Windows.Forms.Button();
            this.displayTable = new System.Windows.Forms.DataGridView();
            this.profileImage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.AddRowBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 387);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(12, 135);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 240);
            this.panel2.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(26, 82);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 32);
            this.button2.TabIndex = 0;
            this.button2.Text = "ADD COLUMN";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // AddRowBtn
            // 
            this.AddRowBtn.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddRowBtn.Location = new System.Drawing.Point(26, 44);
            this.AddRowBtn.Name = "AddRowBtn";
            this.AddRowBtn.Size = new System.Drawing.Size(175, 32);
            this.AddRowBtn.TabIndex = 0;
            this.AddRowBtn.Text = "ADD ROW";
            this.AddRowBtn.UseVisualStyleBackColor = true;
            this.AddRowBtn.Click += new System.EventHandler(this.OnAddRowBtnClicked);
            // 
            // displayTable
            // 
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
            this.displayTable.Size = new System.Drawing.Size(542, 387);
            this.displayTable.TabIndex = 1;
            this.displayTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnDisplayTableCellClicked);
            this.displayTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.displayTable_CellContentClick);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 387);
            this.Controls.Add(this.displayTable);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.displayTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView displayTable;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button AddRowBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn profileImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dob;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
    }
}


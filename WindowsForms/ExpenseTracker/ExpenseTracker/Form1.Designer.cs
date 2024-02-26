namespace ExpenseTracker
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.optionsPanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.delPB = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.filterPB = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addPB = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuPB = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.headingLabel = new System.Windows.Forms.Label();
            this.expenseDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expenseBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.optionsPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delPB)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filterPB)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuPB)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expenseDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // optionsPanel
            // 
            this.optionsPanel.BackColor = System.Drawing.Color.White;
            this.optionsPanel.Controls.Add(this.panel4);
            this.optionsPanel.Controls.Add(this.panel3);
            this.optionsPanel.Controls.Add(this.panel1);
            this.optionsPanel.Controls.Add(this.menuPB);
            this.optionsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.optionsPanel.Location = new System.Drawing.Point(0, 84);
            this.optionsPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.optionsPanel.Name = "optionsPanel";
            this.optionsPanel.Size = new System.Drawing.Size(89, 632);
            this.optionsPanel.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.delPB);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(16, 204);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(267, 57);
            this.panel4.TabIndex = 5;
            // 
            // delPB
            // 
            this.delPB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delPB.Dock = System.Windows.Forms.DockStyle.Left;
            this.delPB.Image = ((System.Drawing.Image)(resources.GetObject("delPB.Image")));
            this.delPB.Location = new System.Drawing.Point(0, 0);
            this.delPB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.delPB.Name = "delPB";
            this.delPB.Size = new System.Drawing.Size(61, 57);
            this.delPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.delPB.TabIndex = 1;
            this.delPB.TabStop = false;
            this.delPB.Visible = false;
            this.delPB.Click += new System.EventHandler(this.delPB_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(85, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Delete";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.filterPB);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(16, 140);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(267, 57);
            this.panel3.TabIndex = 5;
            // 
            // filterPB
            // 
            this.filterPB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filterPB.Dock = System.Windows.Forms.DockStyle.Left;
            this.filterPB.Image = ((System.Drawing.Image)(resources.GetObject("filterPB.Image")));
            this.filterPB.Location = new System.Drawing.Point(0, 0);
            this.filterPB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.filterPB.Name = "filterPB";
            this.filterPB.Size = new System.Drawing.Size(61, 57);
            this.filterPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.filterPB.TabIndex = 0;
            this.filterPB.TabStop = false;
            this.filterPB.Click += new System.EventHandler(this.OnFilterPBClick);
            this.filterPB.MouseEnter += new System.EventHandler(this.OnPictureBoxMouseEnter);
            this.filterPB.MouseLeave += new System.EventHandler(this.OnPictureBoxMouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(89, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Filter";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addPB);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(16, 76);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 57);
            this.panel1.TabIndex = 5;
            // 
            // addPB
            // 
            this.addPB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addPB.Dock = System.Windows.Forms.DockStyle.Left;
            this.addPB.Image = ((System.Drawing.Image)(resources.GetObject("addPB.Image")));
            this.addPB.Location = new System.Drawing.Point(0, 0);
            this.addPB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addPB.Name = "addPB";
            this.addPB.Size = new System.Drawing.Size(61, 57);
            this.addPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addPB.TabIndex = 0;
            this.addPB.TabStop = false;
            this.addPB.Click += new System.EventHandler(this.OnPlusPBClick);
            this.addPB.MouseEnter += new System.EventHandler(this.OnPictureBoxMouseEnter);
            this.addPB.MouseLeave += new System.EventHandler(this.OnPictureBoxMouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(85, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Add";
            // 
            // menuPB
            // 
            this.menuPB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuPB.Image = ((System.Drawing.Image)(resources.GetObject("menuPB.Image")));
            this.menuPB.Location = new System.Drawing.Point(16, 21);
            this.menuPB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.menuPB.Name = "menuPB";
            this.menuPB.Size = new System.Drawing.Size(61, 48);
            this.menuPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menuPB.TabIndex = 0;
            this.menuPB.TabStop = false;
            this.menuPB.Click += new System.EventHandler(this.OnMenuPBClick);
            this.menuPB.MouseEnter += new System.EventHandler(this.OnPictureBoxMouseEnter);
            this.menuPB.MouseLeave += new System.EventHandler(this.OnPictureBoxMouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.headingLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1349, 84);
            this.panel2.TabIndex = 2;
            // 
            // headingLabel
            // 
            this.headingLabel.AutoSize = true;
            this.headingLabel.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headingLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.headingLabel.Location = new System.Drawing.Point(9, 26);
            this.headingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.headingLabel.Name = "headingLabel";
            this.headingLabel.Size = new System.Drawing.Size(298, 41);
            this.headingLabel.TabIndex = 3;
            this.headingLabel.Text = "Expense Tracker";
            // 
            // expenseDataGridView
            // 
            this.expenseDataGridView.AllowUserToAddRows = false;
            this.expenseDataGridView.AutoGenerateColumns = false;
            this.expenseDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.expenseDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.expenseDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.expenseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.expenseDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.expenseDataGridView.DataSource = this.expenseBindingSource2;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.expenseDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.expenseDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expenseDataGridView.Location = new System.Drawing.Point(89, 84);
            this.expenseDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.expenseDataGridView.Name = "expenseDataGridView";
            this.expenseDataGridView.RowHeadersVisible = false;
            this.expenseDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenseDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.expenseDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.expenseDataGridView.Size = new System.Drawing.Size(1260, 632);
            this.expenseDataGridView.TabIndex = 3;
            this.expenseDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.expenseDataGridView_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 36;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 83;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 93;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.Width = 124;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.Width = 113;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 148;
            // 
            // expenseBindingSource2
            // 
            this.expenseBindingSource2.DataSource = typeof(ExpenseTracker.Expense);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 716);
            this.Controls.Add(this.expenseDataGridView);
            this.Controls.Add(this.optionsPanel);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Expense Tracker";
            this.optionsPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delPB)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filterPB)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuPB)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expenseDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel optionsPanel;
        private System.Windows.Forms.PictureBox addPB;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label headingLabel;
        private System.Windows.Forms.DataGridView expenseDataGridView;
        private System.Windows.Forms.BindingSource expenseBindingSource2;
        private System.Windows.Forms.PictureBox filterPB;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox delPB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox menuPB;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
    }
}


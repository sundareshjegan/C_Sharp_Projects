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
            this.categoryPB = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.limitPanel = new System.Windows.Forms.Panel();
            this.budgetPB = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.deletePanel = new System.Windows.Forms.Panel();
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expenseBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.optionsPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryPB)).BeginInit();
            this.limitPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.budgetPB)).BeginInit();
            this.deletePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delPB)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filterPB)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuPB)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expenseDataGridView)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expenseBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // optionsPanel
            // 
            this.optionsPanel.BackColor = System.Drawing.Color.White;
            this.optionsPanel.Controls.Add(this.panel4);
            this.optionsPanel.Controls.Add(this.limitPanel);
            this.optionsPanel.Controls.Add(this.deletePanel);
            this.optionsPanel.Controls.Add(this.panel3);
            this.optionsPanel.Controls.Add(this.panel1);
            this.optionsPanel.Controls.Add(this.menuPB);
            this.optionsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.optionsPanel.Location = new System.Drawing.Point(0, 68);
            this.optionsPanel.Name = "optionsPanel";
            this.optionsPanel.Size = new System.Drawing.Size(73, 514);
            this.optionsPanel.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.categoryPB);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel4.Location = new System.Drawing.Point(13, 166);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 46);
            this.panel4.TabIndex = 5;
            this.panel4.Click += new System.EventHandler(this.OnCategoryPBClicked);
            this.panel4.MouseEnter += new System.EventHandler(this.OnPictureBoxMouseEnter);
            this.panel4.MouseLeave += new System.EventHandler(this.OnPictureBoxMouseLeave);
            // 
            // categoryPB
            // 
            this.categoryPB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.categoryPB.Dock = System.Windows.Forms.DockStyle.Left;
            this.categoryPB.Image = global::ExpenseTracker.Properties.Resources.categories;
            this.categoryPB.Location = new System.Drawing.Point(0, 0);
            this.categoryPB.Name = "categoryPB";
            this.categoryPB.Size = new System.Drawing.Size(46, 46);
            this.categoryPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.categoryPB.TabIndex = 1;
            this.categoryPB.TabStop = false;
            this.categoryPB.Click += new System.EventHandler(this.OnCategoryPBClicked);
            this.categoryPB.MouseEnter += new System.EventHandler(this.OnPictureBoxMouseEnter);
            this.categoryPB.MouseLeave += new System.EventHandler(this.OnPictureBoxMouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(64, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Categories";
            this.label4.Click += new System.EventHandler(this.OnCategoryPBClicked);
            this.label4.MouseEnter += new System.EventHandler(this.OnPictureBoxMouseEnter);
            this.label4.MouseLeave += new System.EventHandler(this.OnPictureBoxMouseLeave);
            // 
            // limitPanel
            // 
            this.limitPanel.Controls.Add(this.budgetPB);
            this.limitPanel.Controls.Add(this.label6);
            this.limitPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.limitPanel.Location = new System.Drawing.Point(12, 218);
            this.limitPanel.Name = "limitPanel";
            this.limitPanel.Size = new System.Drawing.Size(200, 46);
            this.limitPanel.TabIndex = 5;
            this.limitPanel.Click += new System.EventHandler(this.OnBudgetClicked);
            this.limitPanel.MouseEnter += new System.EventHandler(this.OnPictureBoxMouseEnter);
            this.limitPanel.MouseLeave += new System.EventHandler(this.OnPictureBoxMouseLeave);
            // 
            // budgetPB
            // 
            this.budgetPB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.budgetPB.Dock = System.Windows.Forms.DockStyle.Left;
            this.budgetPB.Image = ((System.Drawing.Image)(resources.GetObject("budgetPB.Image")));
            this.budgetPB.Location = new System.Drawing.Point(0, 0);
            this.budgetPB.Name = "budgetPB";
            this.budgetPB.Size = new System.Drawing.Size(46, 46);
            this.budgetPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.budgetPB.TabIndex = 1;
            this.budgetPB.TabStop = false;
            this.budgetPB.Click += new System.EventHandler(this.OnBudgetClicked);
            this.budgetPB.MouseEnter += new System.EventHandler(this.OnPictureBoxMouseEnter);
            this.budgetPB.MouseLeave += new System.EventHandler(this.OnPictureBoxMouseLeave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(64, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "Budget";
            this.label6.Click += new System.EventHandler(this.OnBudgetClicked);
            this.label6.MouseEnter += new System.EventHandler(this.OnPictureBoxMouseEnter);
            this.label6.MouseLeave += new System.EventHandler(this.OnPictureBoxMouseLeave);
            // 
            // deletePanel
            // 
            this.deletePanel.Controls.Add(this.delPB);
            this.deletePanel.Controls.Add(this.label3);
            this.deletePanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deletePanel.Location = new System.Drawing.Point(13, 270);
            this.deletePanel.Name = "deletePanel";
            this.deletePanel.Size = new System.Drawing.Size(200, 46);
            this.deletePanel.TabIndex = 5;
            this.deletePanel.Visible = false;
            this.deletePanel.Click += new System.EventHandler(this.OnDelPBClicked);
            this.deletePanel.MouseEnter += new System.EventHandler(this.OnPictureBoxMouseEnter);
            this.deletePanel.MouseLeave += new System.EventHandler(this.OnPictureBoxMouseLeave);
            // 
            // delPB
            // 
            this.delPB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delPB.Dock = System.Windows.Forms.DockStyle.Left;
            this.delPB.Image = ((System.Drawing.Image)(resources.GetObject("delPB.Image")));
            this.delPB.Location = new System.Drawing.Point(0, 0);
            this.delPB.Name = "delPB";
            this.delPB.Size = new System.Drawing.Size(46, 46);
            this.delPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.delPB.TabIndex = 1;
            this.delPB.TabStop = false;
            this.delPB.Click += new System.EventHandler(this.OnDelPBClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(64, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Delete";
            this.label3.Click += new System.EventHandler(this.OnDelPBClicked);
            this.label3.MouseEnter += new System.EventHandler(this.OnPictureBoxMouseEnter);
            this.label3.MouseLeave += new System.EventHandler(this.OnPictureBoxMouseLeave);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.filterPB);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel3.Location = new System.Drawing.Point(12, 114);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 46);
            this.panel3.TabIndex = 5;
            this.panel3.MouseEnter += new System.EventHandler(this.OnPictureBoxMouseEnter);
            this.panel3.MouseLeave += new System.EventHandler(this.OnPictureBoxMouseLeave);
            // 
            // filterPB
            // 
            this.filterPB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filterPB.Dock = System.Windows.Forms.DockStyle.Left;
            this.filterPB.Image = ((System.Drawing.Image)(resources.GetObject("filterPB.Image")));
            this.filterPB.Location = new System.Drawing.Point(0, 0);
            this.filterPB.Name = "filterPB";
            this.filterPB.Size = new System.Drawing.Size(46, 46);
            this.filterPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.filterPB.TabIndex = 0;
            this.filterPB.TabStop = false;
            this.filterPB.MouseEnter += new System.EventHandler(this.OnPictureBoxMouseEnter);
            this.filterPB.MouseLeave += new System.EventHandler(this.OnPictureBoxMouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(67, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Filter";
            this.label2.MouseEnter += new System.EventHandler(this.OnPictureBoxMouseEnter);
            this.label2.MouseLeave += new System.EventHandler(this.OnPictureBoxMouseLeave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addPB);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(12, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 46);
            this.panel1.TabIndex = 5;
            this.panel1.Click += new System.EventHandler(this.OnPlusPBClick);
            this.panel1.MouseEnter += new System.EventHandler(this.OnPictureBoxMouseEnter);
            this.panel1.MouseLeave += new System.EventHandler(this.OnPictureBoxMouseLeave);
            // 
            // addPB
            // 
            this.addPB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addPB.Dock = System.Windows.Forms.DockStyle.Left;
            this.addPB.Image = ((System.Drawing.Image)(resources.GetObject("addPB.Image")));
            this.addPB.Location = new System.Drawing.Point(0, 0);
            this.addPB.Name = "addPB";
            this.addPB.Size = new System.Drawing.Size(46, 46);
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
            this.label1.Location = new System.Drawing.Point(64, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Add";
            this.label1.Click += new System.EventHandler(this.OnPlusPBClick);
            this.label1.MouseEnter += new System.EventHandler(this.OnPictureBoxMouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.OnPictureBoxMouseLeave);
            // 
            // menuPB
            // 
            this.menuPB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuPB.Image = ((System.Drawing.Image)(resources.GetObject("menuPB.Image")));
            this.menuPB.Location = new System.Drawing.Point(12, 17);
            this.menuPB.Name = "menuPB";
            this.menuPB.Size = new System.Drawing.Size(46, 39);
            this.menuPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menuPB.TabIndex = 0;
            this.menuPB.TabStop = false;
            this.menuPB.Click += new System.EventHandler(this.OnMenuPBClick);
            this.menuPB.MouseEnter += new System.EventHandler(this.OnPictureBoxMouseEnter);
            this.menuPB.MouseLeave += new System.EventHandler(this.OnPictureBoxMouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.headingLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1012, 68);
            this.panel2.TabIndex = 2;
            // 
            // headingLabel
            // 
            this.headingLabel.AutoSize = true;
            this.headingLabel.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headingLabel.ForeColor = System.Drawing.Color.White;
            this.headingLabel.Location = new System.Drawing.Point(7, 21);
            this.headingLabel.Name = "headingLabel";
            this.headingLabel.Size = new System.Drawing.Size(238, 32);
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
            this.expenseDataGridView.Location = new System.Drawing.Point(73, 68);
            this.expenseDataGridView.Name = "expenseDataGridView";
            this.expenseDataGridView.RowHeadersVisible = false;
            this.expenseDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenseDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.expenseDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.expenseDataGridView.Size = new System.Drawing.Size(939, 465);
            this.expenseDataGridView.TabIndex = 3;
            this.expenseDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.expenseDataGridView_CellClick);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel5.Controls.Add(this.label5);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(73, 533);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(939, 49);
            this.panel5.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(334, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total Expense";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 28;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 68;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 77;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.Width = 102;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.Width = 92;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 115;
            // 
            // expenseBindingSource2
            // 
            this.expenseBindingSource2.DataSource = typeof(ExpenseTracker.Expense);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 582);
            this.Controls.Add(this.expenseDataGridView);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.optionsPanel);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Expense Tracker";
            this.optionsPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryPB)).EndInit();
            this.limitPanel.ResumeLayout(false);
            this.limitPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.budgetPB)).EndInit();
            this.deletePanel.ResumeLayout(false);
            this.deletePanel.PerformLayout();
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
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
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
        private System.Windows.Forms.Panel deletePanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox categoryPB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel limitPanel;
        private System.Windows.Forms.PictureBox budgetPB;
        private System.Windows.Forms.Label label6;
    }
}


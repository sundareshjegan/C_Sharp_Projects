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
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expenseBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.filterOptionsPanel = new System.Windows.Forms.Panel();
            this.filterResetBtn = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.filterToDatePicker = new System.Windows.Forms.DateTimePicker();
            this.filterFromDatePicker = new System.Windows.Forms.DateTimePicker();
            this.filterDayCB = new System.Windows.Forms.ComboBox();
            this.filterMonthCB = new System.Windows.Forms.ComboBox();
            this.filterCategoryCB = new System.Windows.Forms.ComboBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.expenseBindingSource2)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.filterOptionsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filterResetBtn)).BeginInit();
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
            this.filterPB.Click += new System.EventHandler(this.OnFilterPBClicked);
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
            this.panel2.Size = new System.Drawing.Size(1008, 68);
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
            this.expenseDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.expenseDataGridView.Location = new System.Drawing.Point(73, 168);
            this.expenseDataGridView.Name = "expenseDataGridView";
            this.expenseDataGridView.RowHeadersVisible = false;
            this.expenseDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenseDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.expenseDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.expenseDataGridView.Size = new System.Drawing.Size(935, 414);
            this.expenseDataGridView.TabIndex = 3;
            this.expenseDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnExpenseDataGridViewCellClick);
            this.expenseDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.OnExpenseDataGridViewCellMouseClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // expenseBindingSource2
            // 
            this.expenseBindingSource2.DataSource = typeof(ExpenseTracker.Expense);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(73, 533);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(935, 49);
            this.panel5.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label5);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(634, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 49);
            this.panel6.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label5.Size = new System.Drawing.Size(158, 35);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total Expense";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.label7);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(834, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(101, 49);
            this.panel7.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label7.Size = new System.Drawing.Size(25, 35);
            this.label7.TabIndex = 4;
            this.label7.Text = "0";
            // 
            // filterOptionsPanel
            // 
            this.filterOptionsPanel.BackColor = System.Drawing.Color.DodgerBlue;
            this.filterOptionsPanel.Controls.Add(this.filterResetBtn);
            this.filterOptionsPanel.Controls.Add(this.label12);
            this.filterOptionsPanel.Controls.Add(this.label11);
            this.filterOptionsPanel.Controls.Add(this.label10);
            this.filterOptionsPanel.Controls.Add(this.label9);
            this.filterOptionsPanel.Controls.Add(this.label8);
            this.filterOptionsPanel.Controls.Add(this.filterToDatePicker);
            this.filterOptionsPanel.Controls.Add(this.filterFromDatePicker);
            this.filterOptionsPanel.Controls.Add(this.filterDayCB);
            this.filterOptionsPanel.Controls.Add(this.filterMonthCB);
            this.filterOptionsPanel.Controls.Add(this.filterCategoryCB);
            this.filterOptionsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.filterOptionsPanel.Location = new System.Drawing.Point(73, 68);
            this.filterOptionsPanel.Name = "filterOptionsPanel";
            this.filterOptionsPanel.Size = new System.Drawing.Size(935, 100);
            this.filterOptionsPanel.TabIndex = 4;
            // 
            // filterResetBtn
            // 
            this.filterResetBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filterResetBtn.Image = ((System.Drawing.Image)(resources.GetObject("filterResetBtn.Image")));
            this.filterResetBtn.Location = new System.Drawing.Point(883, 41);
            this.filterResetBtn.Name = "filterResetBtn";
            this.filterResetBtn.Size = new System.Drawing.Size(49, 37);
            this.filterResetBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.filterResetBtn.TabIndex = 1;
            this.filterResetBtn.TabStop = false;
            this.filterResetBtn.Click += new System.EventHandler(this.FilterResetBtnClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(779, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 23);
            this.label12.TabIndex = 4;
            this.label12.Text = "Day";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(624, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 23);
            this.label11.TabIndex = 4;
            this.label11.Text = "Month";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(444, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 23);
            this.label10.TabIndex = 4;
            this.label10.Text = "To Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(243, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 23);
            this.label9.TabIndex = 4;
            this.label9.Text = "From Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(45, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 23);
            this.label8.TabIndex = 4;
            this.label8.Text = "Category";
            // 
            // filterToDatePicker
            // 
            this.filterToDatePicker.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterToDatePicker.Location = new System.Drawing.Point(393, 51);
            this.filterToDatePicker.Name = "filterToDatePicker";
            this.filterToDatePicker.Size = new System.Drawing.Size(185, 27);
            this.filterToDatePicker.TabIndex = 5;
            this.filterToDatePicker.ValueChanged += new System.EventHandler(this.FilterDatePickerValueChanged);
            this.filterToDatePicker.DropDown += new System.EventHandler(this.FilterDatePickerDropDown);
            // 
            // filterFromDatePicker
            // 
            this.filterFromDatePicker.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterFromDatePicker.Location = new System.Drawing.Point(202, 51);
            this.filterFromDatePicker.Name = "filterFromDatePicker";
            this.filterFromDatePicker.Size = new System.Drawing.Size(185, 27);
            this.filterFromDatePicker.TabIndex = 5;
            this.filterFromDatePicker.ValueChanged += new System.EventHandler(this.FilterDatePickerValueChanged);
            this.filterFromDatePicker.DropDown += new System.EventHandler(this.FilterDatePickerDropDown);
            // 
            // filterDayCB
            // 
            this.filterDayCB.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterDayCB.FormattingEnabled = true;
            this.filterDayCB.Location = new System.Drawing.Point(740, 47);
            this.filterDayCB.Name = "filterDayCB";
            this.filterDayCB.Size = new System.Drawing.Size(137, 31);
            this.filterDayCB.TabIndex = 0;
            this.filterDayCB.DropDown += new System.EventHandler(this.OnFilterCBDropDown);
            this.filterDayCB.TextChanged += new System.EventHandler(this.FilterCBTextChanged);
            this.filterDayCB.Click += new System.EventHandler(this.OnFilterCBClick);
            this.filterDayCB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FilterCBKeyPress);
            // 
            // filterMonthCB
            // 
            this.filterMonthCB.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterMonthCB.FormattingEnabled = true;
            this.filterMonthCB.Location = new System.Drawing.Point(584, 47);
            this.filterMonthCB.Name = "filterMonthCB";
            this.filterMonthCB.Size = new System.Drawing.Size(150, 31);
            this.filterMonthCB.TabIndex = 0;
            this.filterMonthCB.DropDown += new System.EventHandler(this.OnFilterCBDropDown);
            this.filterMonthCB.TextChanged += new System.EventHandler(this.FilterCBTextChanged);
            this.filterMonthCB.Click += new System.EventHandler(this.OnFilterCBClick);
            this.filterMonthCB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FilterCBKeyPress);
            // 
            // filterCategoryCB
            // 
            this.filterCategoryCB.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterCategoryCB.FormattingEnabled = true;
            this.filterCategoryCB.Location = new System.Drawing.Point(10, 47);
            this.filterCategoryCB.Name = "filterCategoryCB";
            this.filterCategoryCB.Size = new System.Drawing.Size(186, 31);
            this.filterCategoryCB.TabIndex = 0;
            this.filterCategoryCB.TextChanged += new System.EventHandler(this.FilterCBTextChanged);
            this.filterCategoryCB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FilterCBKeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 582);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.expenseDataGridView);
            this.Controls.Add(this.filterOptionsPanel);
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
            ((System.ComponentModel.ISupportInitialize)(this.expenseBindingSource2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.filterOptionsPanel.ResumeLayout(false);
            this.filterOptionsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filterResetBtn)).EndInit();
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
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel filterOptionsPanel;
        private System.Windows.Forms.DateTimePicker filterToDatePicker;
        private System.Windows.Forms.DateTimePicker filterFromDatePicker;
        private System.Windows.Forms.ComboBox filterDayCB;
        private System.Windows.Forms.ComboBox filterMonthCB;
        private System.Windows.Forms.ComboBox filterCategoryCB;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox filterResetBtn;
    }
}


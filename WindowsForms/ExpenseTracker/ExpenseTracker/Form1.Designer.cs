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
            this.budgetBtn = new System.Windows.Forms.Button();
            this.categoryBtn = new System.Windows.Forms.Button();
            this.filterExpenseBtn = new System.Windows.Forms.Button();
            this.addExpenseBtn = new System.Windows.Forms.Button();
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
            this.totalAmountLabel = new System.Windows.Forms.Label();
            this.filterOptionsPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.filterResetBtn = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.filterCategoryCB = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.filterMonthCB = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.filterDayCB = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.filterFromDatePicker = new System.Windows.Forms.DateTimePicker();
            this.filterToDatePicker = new System.Windows.Forms.DateTimePicker();
            this.optionsPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expenseDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseBindingSource2)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.filterOptionsPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filterResetBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // optionsPanel
            // 
            this.optionsPanel.BackColor = System.Drawing.Color.White;
            this.optionsPanel.Controls.Add(this.budgetBtn);
            this.optionsPanel.Controls.Add(this.categoryBtn);
            this.optionsPanel.Controls.Add(this.filterExpenseBtn);
            this.optionsPanel.Controls.Add(this.addExpenseBtn);
            this.optionsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.optionsPanel.Location = new System.Drawing.Point(0, 84);
            this.optionsPanel.Margin = new System.Windows.Forms.Padding(4);
            this.optionsPanel.Name = "optionsPanel";
            this.optionsPanel.Size = new System.Drawing.Size(67, 632);
            this.optionsPanel.TabIndex = 0;
            this.optionsPanel.MouseEnter += new System.EventHandler(this.MenuMouseEnter);
            this.optionsPanel.MouseLeave += new System.EventHandler(this.MenuMouseLeave);
            // 
            // budgetBtn
            // 
            this.budgetBtn.FlatAppearance.BorderSize = 0;
            this.budgetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.budgetBtn.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.budgetBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.budgetBtn.Image = ((System.Drawing.Image)(resources.GetObject("budgetBtn.Image")));
            this.budgetBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.budgetBtn.Location = new System.Drawing.Point(4, 69);
            this.budgetBtn.Margin = new System.Windows.Forms.Padding(4);
            this.budgetBtn.Name = "budgetBtn";
            this.budgetBtn.Size = new System.Drawing.Size(267, 57);
            this.budgetBtn.TabIndex = 6;
            this.budgetBtn.Text = "    Budget";
            this.budgetBtn.UseVisualStyleBackColor = true;
            this.budgetBtn.Click += new System.EventHandler(this.OnBudgetBtnClicked);
            this.budgetBtn.MouseEnter += new System.EventHandler(this.MenuMouseEnter);
            this.budgetBtn.MouseLeave += new System.EventHandler(this.MenuMouseLeave);
            // 
            // categoryBtn
            // 
            this.categoryBtn.FlatAppearance.BorderSize = 0;
            this.categoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoryBtn.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.categoryBtn.Image = ((System.Drawing.Image)(resources.GetObject("categoryBtn.Image")));
            this.categoryBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.categoryBtn.Location = new System.Drawing.Point(4, 133);
            this.categoryBtn.Margin = new System.Windows.Forms.Padding(4);
            this.categoryBtn.Name = "categoryBtn";
            this.categoryBtn.Size = new System.Drawing.Size(267, 57);
            this.categoryBtn.TabIndex = 6;
            this.categoryBtn.Text = "    Categories";
            this.categoryBtn.UseVisualStyleBackColor = true;
            this.categoryBtn.Click += new System.EventHandler(this.OnCategoryBtnClicked);
            this.categoryBtn.MouseEnter += new System.EventHandler(this.MenuMouseEnter);
            this.categoryBtn.MouseLeave += new System.EventHandler(this.MenuMouseLeave);
            // 
            // filterExpenseBtn
            // 
            this.filterExpenseBtn.FlatAppearance.BorderSize = 0;
            this.filterExpenseBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.filterExpenseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterExpenseBtn.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterExpenseBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.filterExpenseBtn.Image = ((System.Drawing.Image)(resources.GetObject("filterExpenseBtn.Image")));
            this.filterExpenseBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.filterExpenseBtn.Location = new System.Drawing.Point(4, 197);
            this.filterExpenseBtn.Margin = new System.Windows.Forms.Padding(4);
            this.filterExpenseBtn.Name = "filterExpenseBtn";
            this.filterExpenseBtn.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.filterExpenseBtn.Size = new System.Drawing.Size(267, 57);
            this.filterExpenseBtn.TabIndex = 6;
            this.filterExpenseBtn.Text = "     Filter Expense";
            this.filterExpenseBtn.UseVisualStyleBackColor = true;
            this.filterExpenseBtn.Click += new System.EventHandler(this.OnFilterExpenseBtnClicked);
            this.filterExpenseBtn.MouseEnter += new System.EventHandler(this.MenuMouseEnter);
            this.filterExpenseBtn.MouseLeave += new System.EventHandler(this.MenuMouseLeave);
            // 
            // addExpenseBtn
            // 
            this.addExpenseBtn.FlatAppearance.BorderSize = 0;
            this.addExpenseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addExpenseBtn.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addExpenseBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.addExpenseBtn.Image = ((System.Drawing.Image)(resources.GetObject("addExpenseBtn.Image")));
            this.addExpenseBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addExpenseBtn.Location = new System.Drawing.Point(4, 5);
            this.addExpenseBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addExpenseBtn.Name = "addExpenseBtn";
            this.addExpenseBtn.Size = new System.Drawing.Size(267, 57);
            this.addExpenseBtn.TabIndex = 6;
            this.addExpenseBtn.Text = "     Add Expense";
            this.addExpenseBtn.UseVisualStyleBackColor = true;
            this.addExpenseBtn.Click += new System.EventHandler(this.OnAddExpenseBtnClicked);
            this.addExpenseBtn.MouseEnter += new System.EventHandler(this.MenuMouseEnter);
            this.addExpenseBtn.MouseLeave += new System.EventHandler(this.MenuMouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.headingLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1343, 84);
            this.panel2.TabIndex = 2;
            // 
            // headingLabel
            // 
            this.headingLabel.AutoSize = true;
            this.headingLabel.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headingLabel.ForeColor = System.Drawing.Color.White;
            this.headingLabel.Location = new System.Drawing.Point(231, 28);
            this.headingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.headingLabel.Name = "headingLabel";
            this.headingLabel.Size = new System.Drawing.Size(290, 40);
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
            this.expenseDataGridView.Location = new System.Drawing.Point(67, 84);
            this.expenseDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.expenseDataGridView.Name = "expenseDataGridView";
            this.expenseDataGridView.RowHeadersVisible = false;
            this.expenseDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenseDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.expenseDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.expenseDataGridView.Size = new System.Drawing.Size(1276, 632);
            this.expenseDataGridView.TabIndex = 3;
            this.expenseDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.OnExpenseDataGridViewCellMouseClick);
            this.expenseDataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.OnExpenseDataGridViewRowsAdded);
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
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.panel5.Location = new System.Drawing.Point(67, 656);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1276, 60);
            this.panel5.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label5);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(876, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(266, 60);
            this.panel6.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.label5.Size = new System.Drawing.Size(201, 44);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total Expense";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.totalAmountLabel);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(1142, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(134, 60);
            this.panel7.TabIndex = 5;
            // 
            // totalAmountLabel
            // 
            this.totalAmountLabel.AutoSize = true;
            this.totalAmountLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalAmountLabel.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAmountLabel.ForeColor = System.Drawing.Color.White;
            this.totalAmountLabel.Location = new System.Drawing.Point(0, 0);
            this.totalAmountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalAmountLabel.Name = "totalAmountLabel";
            this.totalAmountLabel.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.totalAmountLabel.Size = new System.Drawing.Size(31, 44);
            this.totalAmountLabel.TabIndex = 4;
            this.totalAmountLabel.Text = "0";
            // 
            // filterOptionsPanel
            // 
            this.filterOptionsPanel.BackColor = System.Drawing.Color.DodgerBlue;
            this.filterOptionsPanel.Controls.Add(this.panel1);
            this.filterOptionsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.filterOptionsPanel.Location = new System.Drawing.Point(67, 84);
            this.filterOptionsPanel.Margin = new System.Windows.Forms.Padding(4);
            this.filterOptionsPanel.Name = "filterOptionsPanel";
            this.filterOptionsPanel.Size = new System.Drawing.Size(1276, 0);
            this.filterOptionsPanel.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.filterResetBtn);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.filterCategoryCB);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.filterMonthCB);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.filterDayCB);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.filterFromDatePicker);
            this.panel1.Controls.Add(this.filterToDatePicker);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1277, 0);
            this.panel1.TabIndex = 5;
            // 
            // filterResetBtn
            // 
            this.filterResetBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filterResetBtn.Image = ((System.Drawing.Image)(resources.GetObject("filterResetBtn.Image")));
            this.filterResetBtn.Location = new System.Drawing.Point(1187, 50);
            this.filterResetBtn.Margin = new System.Windows.Forms.Padding(4);
            this.filterResetBtn.Name = "filterResetBtn";
            this.filterResetBtn.Size = new System.Drawing.Size(65, 46);
            this.filterResetBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.filterResetBtn.TabIndex = 1;
            this.filterResetBtn.TabStop = false;
            this.filterResetBtn.Click += new System.EventHandler(this.FilterResetBtnClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(69, 21);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 29);
            this.label8.TabIndex = 4;
            this.label8.Text = "Category";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(1048, 21);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 29);
            this.label12.TabIndex = 4;
            this.label12.Text = "Day";
            // 
            // filterCategoryCB
            // 
            this.filterCategoryCB.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterCategoryCB.FormattingEnabled = true;
            this.filterCategoryCB.Location = new System.Drawing.Point(23, 58);
            this.filterCategoryCB.Margin = new System.Windows.Forms.Padding(4);
            this.filterCategoryCB.Name = "filterCategoryCB";
            this.filterCategoryCB.Size = new System.Drawing.Size(247, 37);
            this.filterCategoryCB.TabIndex = 0;
            this.filterCategoryCB.TextChanged += new System.EventHandler(this.FilterCBTextChanged);
            this.filterCategoryCB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FilterCBKeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(841, 21);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 29);
            this.label11.TabIndex = 4;
            this.label11.Text = "Month";
            // 
            // filterMonthCB
            // 
            this.filterMonthCB.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterMonthCB.FormattingEnabled = true;
            this.filterMonthCB.Location = new System.Drawing.Point(788, 58);
            this.filterMonthCB.Margin = new System.Windows.Forms.Padding(4);
            this.filterMonthCB.Name = "filterMonthCB";
            this.filterMonthCB.Size = new System.Drawing.Size(199, 37);
            this.filterMonthCB.TabIndex = 0;
            this.filterMonthCB.TextChanged += new System.EventHandler(this.FilterCBTextChanged);
            this.filterMonthCB.Click += new System.EventHandler(this.OnFilterCBClick);
            this.filterMonthCB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FilterCBKeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(601, 21);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 29);
            this.label10.TabIndex = 4;
            this.label10.Text = "To Date";
            // 
            // filterDayCB
            // 
            this.filterDayCB.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterDayCB.FormattingEnabled = true;
            this.filterDayCB.Location = new System.Drawing.Point(996, 58);
            this.filterDayCB.Margin = new System.Windows.Forms.Padding(4);
            this.filterDayCB.Name = "filterDayCB";
            this.filterDayCB.Size = new System.Drawing.Size(181, 37);
            this.filterDayCB.TabIndex = 0;
            this.filterDayCB.TextChanged += new System.EventHandler(this.FilterCBTextChanged);
            this.filterDayCB.Click += new System.EventHandler(this.OnFilterCBClick);
            this.filterDayCB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FilterCBKeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(333, 21);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 29);
            this.label9.TabIndex = 4;
            this.label9.Text = "From Date";
            // 
            // filterFromDatePicker
            // 
            this.filterFromDatePicker.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterFromDatePicker.Location = new System.Drawing.Point(279, 63);
            this.filterFromDatePicker.Margin = new System.Windows.Forms.Padding(4);
            this.filterFromDatePicker.Name = "filterFromDatePicker";
            this.filterFromDatePicker.Size = new System.Drawing.Size(245, 32);
            this.filterFromDatePicker.TabIndex = 5;
            this.filterFromDatePicker.ValueChanged += new System.EventHandler(this.FilterDatePickerValueChanged);
            this.filterFromDatePicker.DropDown += new System.EventHandler(this.FilterDatePickerDropDown);
            // 
            // filterToDatePicker
            // 
            this.filterToDatePicker.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterToDatePicker.Location = new System.Drawing.Point(533, 63);
            this.filterToDatePicker.Margin = new System.Windows.Forms.Padding(4);
            this.filterToDatePicker.Name = "filterToDatePicker";
            this.filterToDatePicker.Size = new System.Drawing.Size(245, 32);
            this.filterToDatePicker.TabIndex = 5;
            this.filterToDatePicker.ValueChanged += new System.EventHandler(this.FilterDatePickerValueChanged);
            this.filterToDatePicker.DropDown += new System.EventHandler(this.FilterDatePickerDropDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 716);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.expenseDataGridView);
            this.Controls.Add(this.filterOptionsPanel);
            this.Controls.Add(this.optionsPanel);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Expense Tracker";
            this.optionsPanel.ResumeLayout(false);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filterResetBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel optionsPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label headingLabel;
        private System.Windows.Forms.DataGridView expenseDataGridView;
        private System.Windows.Forms.BindingSource expenseBindingSource2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label totalAmountLabel;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button addExpenseBtn;
        private System.Windows.Forms.Button filterExpenseBtn;
        private System.Windows.Forms.Button categoryBtn;
        private System.Windows.Forms.Button budgetBtn;
        private System.Windows.Forms.Panel panel1;
    }
}


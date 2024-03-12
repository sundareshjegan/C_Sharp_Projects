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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.optionsPanel = new System.Windows.Forms.Panel();
            this.filterExpenseBtn = new System.Windows.Forms.Button();
            this.categoryBtn = new System.Windows.Forms.Button();
            this.budgetBtn = new System.Windows.Forms.Button();
            this.addExpenseBtn = new System.Windows.Forms.Button();
            this.homeBtn = new System.Windows.Forms.Button();
            this.menuBtn = new System.Windows.Forms.Button();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.headingLabel = new System.Windows.Forms.Label();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.amountDisplayPanel = new System.Windows.Forms.Panel();
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
            this.expenseDataGridView = new System.Windows.Forms.DataGridView();
            this.dashboardPanel = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.budgetTabPage = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dashCatLabel = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dashMonBudgetLabel = new System.Windows.Forms.Label();
            this.dashMonNameLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.analysisPage = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.optionsPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.amountDisplayPanel.SuspendLayout();
            this.filterOptionsPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filterResetBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseDataGridView)).BeginInit();
            this.dashboardPanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.budgetTabPage.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.analysisPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // optionsPanel
            // 
            this.optionsPanel.BackColor = System.Drawing.Color.White;
            this.optionsPanel.Controls.Add(this.filterExpenseBtn);
            this.optionsPanel.Controls.Add(this.categoryBtn);
            this.optionsPanel.Controls.Add(this.budgetBtn);
            this.optionsPanel.Controls.Add(this.addExpenseBtn);
            this.optionsPanel.Controls.Add(this.homeBtn);
            this.optionsPanel.Controls.Add(this.menuBtn);
            this.optionsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.optionsPanel.Location = new System.Drawing.Point(0, 0);
            this.optionsPanel.Name = "optionsPanel";
            this.optionsPanel.Size = new System.Drawing.Size(220, 582);
            this.optionsPanel.TabIndex = 0;
            this.optionsPanel.MouseEnter += new System.EventHandler(this.OnOptionMouseEnter);
            this.optionsPanel.MouseLeave += new System.EventHandler(this.OnOptionMouseLeave);
            // 
            // filterExpenseBtn
            // 
            this.filterExpenseBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.filterExpenseBtn.FlatAppearance.BorderSize = 0;
            this.filterExpenseBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.filterExpenseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterExpenseBtn.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterExpenseBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.filterExpenseBtn.Image = ((System.Drawing.Image)(resources.GetObject("filterExpenseBtn.Image")));
            this.filterExpenseBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.filterExpenseBtn.Location = new System.Drawing.Point(0, 230);
            this.filterExpenseBtn.Name = "filterExpenseBtn";
            this.filterExpenseBtn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.filterExpenseBtn.Size = new System.Drawing.Size(220, 46);
            this.filterExpenseBtn.TabIndex = 6;
            this.filterExpenseBtn.Text = "     Filter Expense";
            this.filterExpenseBtn.UseVisualStyleBackColor = true;
            this.filterExpenseBtn.Click += new System.EventHandler(this.OnFilterExpenseBtnClicked);
            this.filterExpenseBtn.MouseEnter += new System.EventHandler(this.OnOptionMouseEnter);
            this.filterExpenseBtn.MouseLeave += new System.EventHandler(this.OnOptionMouseLeave);
            // 
            // categoryBtn
            // 
            this.categoryBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.categoryBtn.FlatAppearance.BorderSize = 0;
            this.categoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoryBtn.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.categoryBtn.Image = ((System.Drawing.Image)(resources.GetObject("categoryBtn.Image")));
            this.categoryBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.categoryBtn.Location = new System.Drawing.Point(0, 184);
            this.categoryBtn.Name = "categoryBtn";
            this.categoryBtn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.categoryBtn.Size = new System.Drawing.Size(220, 46);
            this.categoryBtn.TabIndex = 6;
            this.categoryBtn.Text = "    Categories";
            this.categoryBtn.UseVisualStyleBackColor = true;
            this.categoryBtn.Click += new System.EventHandler(this.OnCategoryBtnClicked);
            this.categoryBtn.MouseEnter += new System.EventHandler(this.OnOptionMouseEnter);
            this.categoryBtn.MouseLeave += new System.EventHandler(this.OnOptionMouseLeave);
            // 
            // budgetBtn
            // 
            this.budgetBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.budgetBtn.FlatAppearance.BorderSize = 0;
            this.budgetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.budgetBtn.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.budgetBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.budgetBtn.Image = ((System.Drawing.Image)(resources.GetObject("budgetBtn.Image")));
            this.budgetBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.budgetBtn.Location = new System.Drawing.Point(0, 138);
            this.budgetBtn.Name = "budgetBtn";
            this.budgetBtn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.budgetBtn.Size = new System.Drawing.Size(220, 46);
            this.budgetBtn.TabIndex = 6;
            this.budgetBtn.Text = "    Budget";
            this.budgetBtn.UseVisualStyleBackColor = true;
            this.budgetBtn.Click += new System.EventHandler(this.OnBudgetBtnClicked);
            this.budgetBtn.MouseEnter += new System.EventHandler(this.OnOptionMouseEnter);
            this.budgetBtn.MouseLeave += new System.EventHandler(this.OnOptionMouseLeave);
            // 
            // addExpenseBtn
            // 
            this.addExpenseBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.addExpenseBtn.FlatAppearance.BorderSize = 0;
            this.addExpenseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addExpenseBtn.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addExpenseBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.addExpenseBtn.Image = ((System.Drawing.Image)(resources.GetObject("addExpenseBtn.Image")));
            this.addExpenseBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addExpenseBtn.Location = new System.Drawing.Point(0, 92);
            this.addExpenseBtn.Name = "addExpenseBtn";
            this.addExpenseBtn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.addExpenseBtn.Size = new System.Drawing.Size(220, 46);
            this.addExpenseBtn.TabIndex = 6;
            this.addExpenseBtn.Text = "     Add Expense";
            this.addExpenseBtn.UseVisualStyleBackColor = true;
            this.addExpenseBtn.Click += new System.EventHandler(this.OnAddExpenseBtnClicked);
            this.addExpenseBtn.MouseEnter += new System.EventHandler(this.OnOptionMouseEnter);
            this.addExpenseBtn.MouseLeave += new System.EventHandler(this.OnOptionMouseLeave);
            // 
            // homeBtn
            // 
            this.homeBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.homeBtn.FlatAppearance.BorderSize = 0;
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBtn.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.homeBtn.Image = ((System.Drawing.Image)(resources.GetObject("homeBtn.Image")));
            this.homeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeBtn.Location = new System.Drawing.Point(0, 46);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.homeBtn.Size = new System.Drawing.Size(220, 46);
            this.homeBtn.TabIndex = 6;
            this.homeBtn.Text = "     Dashboard";
            this.homeBtn.UseVisualStyleBackColor = true;
            this.homeBtn.Click += new System.EventHandler(this.OnHomeBtnClicked);
            this.homeBtn.MouseEnter += new System.EventHandler(this.OnOptionMouseEnter);
            this.homeBtn.MouseLeave += new System.EventHandler(this.OnOptionMouseLeave);
            // 
            // menuBtn
            // 
            this.menuBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.menuBtn.FlatAppearance.BorderSize = 0;
            this.menuBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.menuBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.menuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuBtn.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.menuBtn.Image = ((System.Drawing.Image)(resources.GetObject("menuBtn.Image")));
            this.menuBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuBtn.Location = new System.Drawing.Point(0, 0);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.menuBtn.Size = new System.Drawing.Size(220, 46);
            this.menuBtn.TabIndex = 6;
            this.menuBtn.Text = "     Menu";
            this.menuBtn.UseVisualStyleBackColor = true;
            this.menuBtn.Click += new System.EventHandler(this.OnMenuBtnClicked);
            this.menuBtn.MouseEnter += new System.EventHandler(this.OnOptionMouseEnter);
            this.menuBtn.MouseLeave += new System.EventHandler(this.OnOptionMouseLeave);
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.DodgerBlue;
            this.headerPanel.Controls.Add(this.headingLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(220, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(787, 68);
            this.headerPanel.TabIndex = 2;
            // 
            // headingLabel
            // 
            this.headingLabel.AutoSize = true;
            this.headingLabel.Font = new System.Drawing.Font("Lucida Console", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headingLabel.ForeColor = System.Drawing.Color.White;
            this.headingLabel.Location = new System.Drawing.Point(172, 14);
            this.headingLabel.Name = "headingLabel";
            this.headingLabel.Size = new System.Drawing.Size(345, 35);
            this.headingLabel.TabIndex = 3;
            this.headingLabel.Text = "EXPENSE TRACKER";
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.DodgerBlue;
            this.bottomPanel.Controls.Add(this.panel6);
            this.bottomPanel.Controls.Add(this.amountDisplayPanel);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(220, 533);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(787, 49);
            this.bottomPanel.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label5);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(486, 0);
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
            // amountDisplayPanel
            // 
            this.amountDisplayPanel.BackColor = System.Drawing.Color.DodgerBlue;
            this.amountDisplayPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.amountDisplayPanel.Controls.Add(this.totalAmountLabel);
            this.amountDisplayPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.amountDisplayPanel.Location = new System.Drawing.Point(686, 0);
            this.amountDisplayPanel.Name = "amountDisplayPanel";
            this.amountDisplayPanel.Size = new System.Drawing.Size(101, 49);
            this.amountDisplayPanel.TabIndex = 5;
            // 
            // totalAmountLabel
            // 
            this.totalAmountLabel.AutoSize = true;
            this.totalAmountLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalAmountLabel.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAmountLabel.ForeColor = System.Drawing.Color.White;
            this.totalAmountLabel.Location = new System.Drawing.Point(0, 0);
            this.totalAmountLabel.Name = "totalAmountLabel";
            this.totalAmountLabel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.totalAmountLabel.Size = new System.Drawing.Size(25, 35);
            this.totalAmountLabel.TabIndex = 4;
            this.totalAmountLabel.Text = "0";
            // 
            // filterOptionsPanel
            // 
            this.filterOptionsPanel.BackColor = System.Drawing.Color.DodgerBlue;
            this.filterOptionsPanel.Controls.Add(this.panel1);
            this.filterOptionsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.filterOptionsPanel.Location = new System.Drawing.Point(220, 68);
            this.filterOptionsPanel.Name = "filterOptionsPanel";
            this.filterOptionsPanel.Size = new System.Drawing.Size(787, 0);
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
            this.panel1.Location = new System.Drawing.Point(-160, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(947, 0);
            this.panel1.TabIndex = 5;
            // 
            // filterResetBtn
            // 
            this.filterResetBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filterResetBtn.Image = ((System.Drawing.Image)(resources.GetObject("filterResetBtn.Image")));
            this.filterResetBtn.Location = new System.Drawing.Point(890, 41);
            this.filterResetBtn.Name = "filterResetBtn";
            this.filterResetBtn.Size = new System.Drawing.Size(49, 37);
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
            this.label8.Location = new System.Drawing.Point(52, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 23);
            this.label8.TabIndex = 4;
            this.label8.Text = "Category";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(786, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 23);
            this.label12.TabIndex = 4;
            this.label12.Text = "Day";
            // 
            // filterCategoryCB
            // 
            this.filterCategoryCB.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterCategoryCB.FormattingEnabled = true;
            this.filterCategoryCB.Location = new System.Drawing.Point(17, 47);
            this.filterCategoryCB.Name = "filterCategoryCB";
            this.filterCategoryCB.Size = new System.Drawing.Size(186, 31);
            this.filterCategoryCB.TabIndex = 0;
            this.filterCategoryCB.TextChanged += new System.EventHandler(this.FilterCategoryCBTextChanged);
            this.filterCategoryCB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FilterCBKeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(631, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 23);
            this.label11.TabIndex = 4;
            this.label11.Text = "Month";
            // 
            // filterMonthCB
            // 
            this.filterMonthCB.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterMonthCB.FormattingEnabled = true;
            this.filterMonthCB.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June"});
            this.filterMonthCB.Location = new System.Drawing.Point(591, 47);
            this.filterMonthCB.Name = "filterMonthCB";
            this.filterMonthCB.Size = new System.Drawing.Size(150, 31);
            this.filterMonthCB.TabIndex = 0;
            this.filterMonthCB.TextChanged += new System.EventHandler(this.FilterMonthCBTextChanged);
            this.filterMonthCB.Click += new System.EventHandler(this.OnFilterCBClick);
            this.filterMonthCB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FilterCBKeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(451, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 23);
            this.label10.TabIndex = 4;
            this.label10.Text = "To Date";
            // 
            // filterDayCB
            // 
            this.filterDayCB.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterDayCB.FormattingEnabled = true;
            this.filterDayCB.Location = new System.Drawing.Point(747, 47);
            this.filterDayCB.Name = "filterDayCB";
            this.filterDayCB.Size = new System.Drawing.Size(137, 31);
            this.filterDayCB.TabIndex = 0;
            this.filterDayCB.TextChanged += new System.EventHandler(this.FilterCategoryCBTextChanged);
            this.filterDayCB.Click += new System.EventHandler(this.OnFilterCBClick);
            this.filterDayCB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FilterCBKeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(250, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 23);
            this.label9.TabIndex = 4;
            this.label9.Text = "From Date";
            // 
            // filterFromDatePicker
            // 
            this.filterFromDatePicker.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterFromDatePicker.Location = new System.Drawing.Point(209, 51);
            this.filterFromDatePicker.Name = "filterFromDatePicker";
            this.filterFromDatePicker.Size = new System.Drawing.Size(185, 27);
            this.filterFromDatePicker.TabIndex = 5;
            this.filterFromDatePicker.ValueChanged += new System.EventHandler(this.FilterDatePickerValueChanged);
            this.filterFromDatePicker.DropDown += new System.EventHandler(this.FilterDatePickerDropDown);
            // 
            // filterToDatePicker
            // 
            this.filterToDatePicker.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterToDatePicker.Location = new System.Drawing.Point(400, 51);
            this.filterToDatePicker.Name = "filterToDatePicker";
            this.filterToDatePicker.Size = new System.Drawing.Size(185, 27);
            this.filterToDatePicker.TabIndex = 5;
            this.filterToDatePicker.ValueChanged += new System.EventHandler(this.FilterDatePickerValueChanged);
            this.filterToDatePicker.DropDown += new System.EventHandler(this.FilterDatePickerDropDown);
            // 
            // expenseDataGridView
            // 
            this.expenseDataGridView.AllowUserToAddRows = false;
            this.expenseDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.expenseDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.expenseDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.expenseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.expenseDataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.expenseDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expenseDataGridView.Location = new System.Drawing.Point(220, 68);
            this.expenseDataGridView.Name = "expenseDataGridView";
            this.expenseDataGridView.RowHeadersVisible = false;
            this.expenseDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenseDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.expenseDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.expenseDataGridView.Size = new System.Drawing.Size(787, 465);
            this.expenseDataGridView.TabIndex = 3;
            this.expenseDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.OnExpenseDataGridViewCellMouseClick);
            this.expenseDataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.OnExpenseDataGridViewRowsAdded);
            // 
            // dashboardPanel
            // 
            this.dashboardPanel.Controls.Add(this.tabControl1);
            this.dashboardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboardPanel.Location = new System.Drawing.Point(220, 68);
            this.dashboardPanel.Name = "dashboardPanel";
            this.dashboardPanel.Size = new System.Drawing.Size(787, 465);
            this.dashboardPanel.TabIndex = 5;
            this.dashboardPanel.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.budgetTabPage);
            this.tabControl1.Controls.Add(this.analysisPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(6, 6);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.ShowToolTips = true;
            this.tabControl1.Size = new System.Drawing.Size(787, 465);
            this.tabControl1.TabIndex = 1;
            // 
            // budgetTabPage
            // 
            this.budgetTabPage.Controls.Add(this.panel4);
            this.budgetTabPage.Controls.Add(this.panel2);
            this.budgetTabPage.Location = new System.Drawing.Point(4, 37);
            this.budgetTabPage.Name = "budgetTabPage";
            this.budgetTabPage.Padding = new System.Windows.Forms.Padding(30, 20, 3, 3);
            this.budgetTabPage.Size = new System.Drawing.Size(779, 424);
            this.budgetTabPage.TabIndex = 1;
            this.budgetTabPage.Text = "Budget Info";
            this.budgetTabPage.ToolTipText = "View Monthly Wise Budgets and expenses";
            this.budgetTabPage.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.dashCatLabel);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(353, 20);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(257, 393);
            this.panel4.TabIndex = 2;
            // 
            // dashCatLabel
            // 
            this.dashCatLabel.AutoSize = true;
            this.dashCatLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.dashCatLabel.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashCatLabel.Location = new System.Drawing.Point(0, 37);
            this.dashCatLabel.Name = "dashCatLabel";
            this.dashCatLabel.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.dashCatLabel.Size = new System.Drawing.Size(110, 29);
            this.dashCatLabel.TabIndex = 0;
            this.dashCatLabel.Text = "label7";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel5.Controls.Add(this.label13);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(253, 37);
            this.panel5.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(17, 8);
            this.label13.Margin = new System.Windows.Forms.Padding(50, 0, 3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(229, 29);
            this.label13.TabIndex = 2;
            this.label13.Text = "CATEGORIES YOU SPENT ON";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.dashMonBudgetLabel);
            this.panel2.Controls.Add(this.dashMonNameLabel);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(30, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(291, 393);
            this.panel2.TabIndex = 1;
            // 
            // dashMonBudgetLabel
            // 
            this.dashMonBudgetLabel.AutoSize = true;
            this.dashMonBudgetLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.dashMonBudgetLabel.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashMonBudgetLabel.Location = new System.Drawing.Point(60, 37);
            this.dashMonBudgetLabel.Margin = new System.Windows.Forms.Padding(50, 0, 3, 0);
            this.dashMonBudgetLabel.Name = "dashMonBudgetLabel";
            this.dashMonBudgetLabel.Size = new System.Drawing.Size(55, 29);
            this.dashMonBudgetLabel.TabIndex = 0;
            this.dashMonBudgetLabel.Text = "label1";
            // 
            // dashMonNameLabel
            // 
            this.dashMonNameLabel.AutoSize = true;
            this.dashMonNameLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.dashMonNameLabel.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashMonNameLabel.Location = new System.Drawing.Point(0, 37);
            this.dashMonNameLabel.Name = "dashMonNameLabel";
            this.dashMonNameLabel.Size = new System.Drawing.Size(60, 29);
            this.dashMonNameLabel.TabIndex = 0;
            this.dashMonNameLabel.Text = "label1";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(287, 37);
            this.panel3.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(50, 8);
            this.label4.Margin = new System.Windows.Forms.Padding(50, 0, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "MONTH WISE BUDGETS";
            // 
            // analysisPage
            // 
            this.analysisPage.Controls.Add(this.chart1);
            this.analysisPage.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analysisPage.Location = new System.Drawing.Point(4, 33);
            this.analysisPage.Name = "analysisPage";
            this.analysisPage.Padding = new System.Windows.Forms.Padding(10);
            this.analysisPage.Size = new System.Drawing.Size(779, 428);
            this.analysisPage.TabIndex = 0;
            this.analysisPage.Text = "Expense Statistics";
            this.analysisPage.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(495, 368);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(0, 0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(200, 100);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "tabPage2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 582);
            this.Controls.Add(this.dashboardPanel);
            this.Controls.Add(this.expenseDataGridView);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.filterOptionsPanel);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.optionsPanel);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Expense Tracker";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.optionsPanel.ResumeLayout(false);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.bottomPanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.amountDisplayPanel.ResumeLayout(false);
            this.amountDisplayPanel.PerformLayout();
            this.filterOptionsPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filterResetBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseDataGridView)).EndInit();
            this.dashboardPanel.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.budgetTabPage.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.analysisPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel optionsPanel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label headingLabel;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel amountDisplayPanel;
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
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.Button filterExpenseBtn;
        private System.Windows.Forms.Button categoryBtn;
        private System.Windows.Forms.Button budgetBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView expenseDataGridView;
        private System.Windows.Forms.Button menuBtn;
        private System.Windows.Forms.Button addExpenseBtn;
        private System.Windows.Forms.Panel dashboardPanel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage analysisPage;
        private System.Windows.Forms.TabPage budgetTabPage;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label dashMonNameLabel;
        private System.Windows.Forms.Label dashMonBudgetLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label dashCatLabel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label13;
    }
}


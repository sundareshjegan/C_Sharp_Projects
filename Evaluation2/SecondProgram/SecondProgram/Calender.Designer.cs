namespace SecondProgram
{
    partial class Calender
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
            this.monthCB = new System.Windows.Forms.ComboBox();
            this.yearCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.todayBtn = new System.Windows.Forms.Button();
            this.sunLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.daysPanel = new System.Windows.Forms.Panel();
            this.datePanel = new System.Windows.Forms.Panel();
            this.l29 = new System.Windows.Forms.Label();
            this.l22 = new System.Windows.Forms.Label();
            this.l15 = new System.Windows.Forms.Label();
            this.l8 = new System.Windows.Forms.Label();
            this.l1 = new System.Windows.Forms.Label();
            this.l35 = new System.Windows.Forms.Label();
            this.l28 = new System.Windows.Forms.Label();
            this.l21 = new System.Windows.Forms.Label();
            this.l14 = new System.Windows.Forms.Label();
            this.l7 = new System.Windows.Forms.Label();
            this.l34 = new System.Windows.Forms.Label();
            this.l27 = new System.Windows.Forms.Label();
            this.l20 = new System.Windows.Forms.Label();
            this.l13 = new System.Windows.Forms.Label();
            this.l6 = new System.Windows.Forms.Label();
            this.l33 = new System.Windows.Forms.Label();
            this.l26 = new System.Windows.Forms.Label();
            this.l19 = new System.Windows.Forms.Label();
            this.l12 = new System.Windows.Forms.Label();
            this.l5 = new System.Windows.Forms.Label();
            this.l32 = new System.Windows.Forms.Label();
            this.l25 = new System.Windows.Forms.Label();
            this.l18 = new System.Windows.Forms.Label();
            this.l31 = new System.Windows.Forms.Label();
            this.l24 = new System.Windows.Forms.Label();
            this.l11 = new System.Windows.Forms.Label();
            this.l17 = new System.Windows.Forms.Label();
            this.l4 = new System.Windows.Forms.Label();
            this.l30 = new System.Windows.Forms.Label();
            this.l23 = new System.Windows.Forms.Label();
            this.l10 = new System.Windows.Forms.Label();
            this.l16 = new System.Windows.Forms.Label();
            this.l3 = new System.Windows.Forms.Label();
            this.l9 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.l36 = new System.Windows.Forms.Label();
            this.l37 = new System.Windows.Forms.Label();
            this.l38 = new System.Windows.Forms.Label();
            this.l39 = new System.Windows.Forms.Label();
            this.l40 = new System.Windows.Forms.Label();
            this.l41 = new System.Windows.Forms.Label();
            this.headerPanel.SuspendLayout();
            this.daysPanel.SuspendLayout();
            this.datePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCB
            // 
            this.monthCB.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCB.FormattingEnabled = true;
            this.monthCB.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.monthCB.Location = new System.Drawing.Point(20, 39);
            this.monthCB.Name = "monthCB";
            this.monthCB.Size = new System.Drawing.Size(125, 24);
            this.monthCB.TabIndex = 0;
            this.monthCB.SelectedIndexChanged += new System.EventHandler(this.OnValueChanged);
            this.monthCB.TextChanged += new System.EventHandler(this.OnValueChanged);
            // 
            // yearCB
            // 
            this.yearCB.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearCB.FormattingEnabled = true;
            this.yearCB.Location = new System.Drawing.Point(177, 39);
            this.yearCB.Name = "yearCB";
            this.yearCB.Size = new System.Drawing.Size(125, 24);
            this.yearCB.TabIndex = 0;
            this.yearCB.SelectedIndexChanged += new System.EventHandler(this.OnValueChanged);
            this.yearCB.TextChanged += new System.EventHandler(this.OnValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(85, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "CALENDER";
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.MistyRose;
            this.headerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.headerPanel.Controls.Add(this.todayBtn);
            this.headerPanel.Controls.Add(this.label1);
            this.headerPanel.Controls.Add(this.yearCB);
            this.headerPanel.Controls.Add(this.monthCB);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(322, 70);
            this.headerPanel.TabIndex = 2;
            // 
            // todayBtn
            // 
            this.todayBtn.Location = new System.Drawing.Point(250, 10);
            this.todayBtn.Name = "todayBtn";
            this.todayBtn.Size = new System.Drawing.Size(52, 23);
            this.todayBtn.TabIndex = 2;
            this.todayBtn.Text = "Today";
            this.todayBtn.UseVisualStyleBackColor = true;
            this.todayBtn.Click += new System.EventHandler(this.OnTodayBtnClicked);
            // 
            // sunLabel
            // 
            this.sunLabel.AutoSize = true;
            this.sunLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sunLabel.Location = new System.Drawing.Point(19, 14);
            this.sunLabel.Name = "sunLabel";
            this.sunLabel.Size = new System.Drawing.Size(39, 18);
            this.sunLabel.TabIndex = 3;
            this.sunLabel.Text = "Sun";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(107, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tue";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(147, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Wed";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(193, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "Thu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(234, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 18);
            this.label7.TabIndex = 3;
            this.label7.Text = "Fri";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(266, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 18);
            this.label8.TabIndex = 3;
            this.label8.Text = "Sat";
            // 
            // daysPanel
            // 
            this.daysPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.daysPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.daysPanel.Controls.Add(this.label3);
            this.daysPanel.Controls.Add(this.label8);
            this.daysPanel.Controls.Add(this.sunLabel);
            this.daysPanel.Controls.Add(this.label7);
            this.daysPanel.Controls.Add(this.label4);
            this.daysPanel.Controls.Add(this.label6);
            this.daysPanel.Controls.Add(this.label5);
            this.daysPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.daysPanel.Location = new System.Drawing.Point(0, 70);
            this.daysPanel.Name = "daysPanel";
            this.daysPanel.Size = new System.Drawing.Size(322, 47);
            this.daysPanel.TabIndex = 4;
            // 
            // datePanel
            // 
            this.datePanel.Controls.Add(this.l29);
            this.datePanel.Controls.Add(this.l22);
            this.datePanel.Controls.Add(this.l15);
            this.datePanel.Controls.Add(this.l8);
            this.datePanel.Controls.Add(this.l1);
            this.datePanel.Controls.Add(this.l41);
            this.datePanel.Controls.Add(this.l35);
            this.datePanel.Controls.Add(this.l28);
            this.datePanel.Controls.Add(this.l21);
            this.datePanel.Controls.Add(this.l14);
            this.datePanel.Controls.Add(this.l40);
            this.datePanel.Controls.Add(this.l7);
            this.datePanel.Controls.Add(this.l34);
            this.datePanel.Controls.Add(this.l27);
            this.datePanel.Controls.Add(this.l20);
            this.datePanel.Controls.Add(this.l13);
            this.datePanel.Controls.Add(this.l39);
            this.datePanel.Controls.Add(this.l6);
            this.datePanel.Controls.Add(this.l33);
            this.datePanel.Controls.Add(this.l26);
            this.datePanel.Controls.Add(this.l19);
            this.datePanel.Controls.Add(this.l12);
            this.datePanel.Controls.Add(this.l38);
            this.datePanel.Controls.Add(this.l5);
            this.datePanel.Controls.Add(this.l32);
            this.datePanel.Controls.Add(this.l25);
            this.datePanel.Controls.Add(this.l37);
            this.datePanel.Controls.Add(this.l18);
            this.datePanel.Controls.Add(this.l31);
            this.datePanel.Controls.Add(this.l24);
            this.datePanel.Controls.Add(this.l11);
            this.datePanel.Controls.Add(this.l17);
            this.datePanel.Controls.Add(this.l36);
            this.datePanel.Controls.Add(this.l4);
            this.datePanel.Controls.Add(this.l30);
            this.datePanel.Controls.Add(this.l23);
            this.datePanel.Controls.Add(this.l10);
            this.datePanel.Controls.Add(this.l16);
            this.datePanel.Controls.Add(this.l3);
            this.datePanel.Controls.Add(this.l9);
            this.datePanel.Controls.Add(this.l2);
            this.datePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.datePanel.Location = new System.Drawing.Point(0, 117);
            this.datePanel.Name = "datePanel";
            this.datePanel.Size = new System.Drawing.Size(322, 250);
            this.datePanel.TabIndex = 5;
            // 
            // l29
            // 
            this.l29.AutoSize = true;
            this.l29.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l29.Location = new System.Drawing.Point(19, 176);
            this.l29.Name = "l29";
            this.l29.Size = new System.Drawing.Size(0, 18);
            this.l29.TabIndex = 3;
            // 
            // l22
            // 
            this.l22.AutoSize = true;
            this.l22.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l22.Location = new System.Drawing.Point(19, 139);
            this.l22.Name = "l22";
            this.l22.Size = new System.Drawing.Size(0, 18);
            this.l22.TabIndex = 3;
            // 
            // l15
            // 
            this.l15.AutoSize = true;
            this.l15.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l15.Location = new System.Drawing.Point(19, 95);
            this.l15.Name = "l15";
            this.l15.Size = new System.Drawing.Size(0, 18);
            this.l15.TabIndex = 3;
            // 
            // l8
            // 
            this.l8.AutoSize = true;
            this.l8.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l8.Location = new System.Drawing.Point(19, 55);
            this.l8.Name = "l8";
            this.l8.Size = new System.Drawing.Size(0, 18);
            this.l8.TabIndex = 3;
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l1.Location = new System.Drawing.Point(19, 18);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(0, 18);
            this.l1.TabIndex = 3;
            // 
            // l35
            // 
            this.l35.AutoSize = true;
            this.l35.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l35.Location = new System.Drawing.Point(263, 176);
            this.l35.Name = "l35";
            this.l35.Size = new System.Drawing.Size(0, 18);
            this.l35.TabIndex = 3;
            // 
            // l28
            // 
            this.l28.AutoSize = true;
            this.l28.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l28.Location = new System.Drawing.Point(263, 139);
            this.l28.Name = "l28";
            this.l28.Size = new System.Drawing.Size(0, 18);
            this.l28.TabIndex = 3;
            // 
            // l21
            // 
            this.l21.AutoSize = true;
            this.l21.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l21.Location = new System.Drawing.Point(263, 95);
            this.l21.Name = "l21";
            this.l21.Size = new System.Drawing.Size(0, 18);
            this.l21.TabIndex = 3;
            // 
            // l14
            // 
            this.l14.AutoSize = true;
            this.l14.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l14.Location = new System.Drawing.Point(263, 55);
            this.l14.Name = "l14";
            this.l14.Size = new System.Drawing.Size(0, 18);
            this.l14.TabIndex = 3;
            // 
            // l7
            // 
            this.l7.AutoSize = true;
            this.l7.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l7.Location = new System.Drawing.Point(263, 18);
            this.l7.Name = "l7";
            this.l7.Size = new System.Drawing.Size(0, 18);
            this.l7.TabIndex = 3;
            // 
            // l34
            // 
            this.l34.AutoSize = true;
            this.l34.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l34.Location = new System.Drawing.Point(224, 176);
            this.l34.Name = "l34";
            this.l34.Size = new System.Drawing.Size(0, 18);
            this.l34.TabIndex = 3;
            // 
            // l27
            // 
            this.l27.AutoSize = true;
            this.l27.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l27.Location = new System.Drawing.Point(224, 139);
            this.l27.Name = "l27";
            this.l27.Size = new System.Drawing.Size(0, 18);
            this.l27.TabIndex = 3;
            // 
            // l20
            // 
            this.l20.AutoSize = true;
            this.l20.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l20.Location = new System.Drawing.Point(224, 95);
            this.l20.Name = "l20";
            this.l20.Size = new System.Drawing.Size(0, 18);
            this.l20.TabIndex = 3;
            // 
            // l13
            // 
            this.l13.AutoSize = true;
            this.l13.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l13.Location = new System.Drawing.Point(224, 55);
            this.l13.Name = "l13";
            this.l13.Size = new System.Drawing.Size(0, 18);
            this.l13.TabIndex = 3;
            // 
            // l6
            // 
            this.l6.AutoSize = true;
            this.l6.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l6.Location = new System.Drawing.Point(224, 18);
            this.l6.Name = "l6";
            this.l6.Size = new System.Drawing.Size(0, 18);
            this.l6.TabIndex = 3;
            // 
            // l33
            // 
            this.l33.AutoSize = true;
            this.l33.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l33.Location = new System.Drawing.Point(189, 176);
            this.l33.Name = "l33";
            this.l33.Size = new System.Drawing.Size(0, 18);
            this.l33.TabIndex = 3;
            // 
            // l26
            // 
            this.l26.AutoSize = true;
            this.l26.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l26.Location = new System.Drawing.Point(189, 139);
            this.l26.Name = "l26";
            this.l26.Size = new System.Drawing.Size(0, 18);
            this.l26.TabIndex = 3;
            // 
            // l19
            // 
            this.l19.AutoSize = true;
            this.l19.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l19.Location = new System.Drawing.Point(189, 95);
            this.l19.Name = "l19";
            this.l19.Size = new System.Drawing.Size(0, 18);
            this.l19.TabIndex = 3;
            // 
            // l12
            // 
            this.l12.AutoSize = true;
            this.l12.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l12.Location = new System.Drawing.Point(189, 55);
            this.l12.Name = "l12";
            this.l12.Size = new System.Drawing.Size(0, 18);
            this.l12.TabIndex = 3;
            // 
            // l5
            // 
            this.l5.AutoSize = true;
            this.l5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l5.Location = new System.Drawing.Point(189, 18);
            this.l5.Name = "l5";
            this.l5.Size = new System.Drawing.Size(0, 18);
            this.l5.TabIndex = 3;
            // 
            // l32
            // 
            this.l32.AutoSize = true;
            this.l32.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l32.Location = new System.Drawing.Point(147, 176);
            this.l32.Name = "l32";
            this.l32.Size = new System.Drawing.Size(0, 18);
            this.l32.TabIndex = 3;
            // 
            // l25
            // 
            this.l25.AutoSize = true;
            this.l25.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l25.Location = new System.Drawing.Point(147, 139);
            this.l25.Name = "l25";
            this.l25.Size = new System.Drawing.Size(0, 18);
            this.l25.TabIndex = 3;
            // 
            // l18
            // 
            this.l18.AutoSize = true;
            this.l18.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l18.Location = new System.Drawing.Point(147, 95);
            this.l18.Name = "l18";
            this.l18.Size = new System.Drawing.Size(0, 18);
            this.l18.TabIndex = 3;
            // 
            // l31
            // 
            this.l31.AutoSize = true;
            this.l31.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l31.Location = new System.Drawing.Point(105, 176);
            this.l31.Name = "l31";
            this.l31.Size = new System.Drawing.Size(0, 18);
            this.l31.TabIndex = 3;
            // 
            // l24
            // 
            this.l24.AutoSize = true;
            this.l24.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l24.Location = new System.Drawing.Point(105, 139);
            this.l24.Name = "l24";
            this.l24.Size = new System.Drawing.Size(0, 18);
            this.l24.TabIndex = 3;
            // 
            // l11
            // 
            this.l11.AutoSize = true;
            this.l11.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l11.Location = new System.Drawing.Point(147, 55);
            this.l11.Name = "l11";
            this.l11.Size = new System.Drawing.Size(0, 18);
            this.l11.TabIndex = 3;
            // 
            // l17
            // 
            this.l17.AutoSize = true;
            this.l17.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l17.Location = new System.Drawing.Point(105, 95);
            this.l17.Name = "l17";
            this.l17.Size = new System.Drawing.Size(0, 18);
            this.l17.TabIndex = 3;
            // 
            // l4
            // 
            this.l4.AutoSize = true;
            this.l4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l4.Location = new System.Drawing.Point(147, 18);
            this.l4.Name = "l4";
            this.l4.Size = new System.Drawing.Size(0, 18);
            this.l4.TabIndex = 3;
            // 
            // l30
            // 
            this.l30.AutoSize = true;
            this.l30.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l30.Location = new System.Drawing.Point(61, 176);
            this.l30.Name = "l30";
            this.l30.Size = new System.Drawing.Size(0, 18);
            this.l30.TabIndex = 3;
            // 
            // l23
            // 
            this.l23.AutoSize = true;
            this.l23.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l23.Location = new System.Drawing.Point(61, 139);
            this.l23.Name = "l23";
            this.l23.Size = new System.Drawing.Size(0, 18);
            this.l23.TabIndex = 3;
            // 
            // l10
            // 
            this.l10.AutoSize = true;
            this.l10.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l10.Location = new System.Drawing.Point(105, 55);
            this.l10.Name = "l10";
            this.l10.Size = new System.Drawing.Size(0, 18);
            this.l10.TabIndex = 3;
            // 
            // l16
            // 
            this.l16.AutoSize = true;
            this.l16.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l16.Location = new System.Drawing.Point(61, 95);
            this.l16.Name = "l16";
            this.l16.Size = new System.Drawing.Size(0, 18);
            this.l16.TabIndex = 3;
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l3.Location = new System.Drawing.Point(105, 18);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(0, 18);
            this.l3.TabIndex = 3;
            // 
            // l9
            // 
            this.l9.AutoSize = true;
            this.l9.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l9.Location = new System.Drawing.Point(61, 55);
            this.l9.Name = "l9";
            this.l9.Size = new System.Drawing.Size(0, 18);
            this.l9.TabIndex = 3;
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l2.Location = new System.Drawing.Point(61, 18);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(0, 18);
            this.l2.TabIndex = 3;
            // 
            // l36
            // 
            this.l36.AutoSize = true;
            this.l36.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l36.Location = new System.Drawing.Point(61, 214);
            this.l36.Name = "l36";
            this.l36.Size = new System.Drawing.Size(0, 18);
            this.l36.TabIndex = 3;
            // 
            // l37
            // 
            this.l37.AutoSize = true;
            this.l37.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l37.Location = new System.Drawing.Point(105, 214);
            this.l37.Name = "l37";
            this.l37.Size = new System.Drawing.Size(0, 18);
            this.l37.TabIndex = 3;
            // 
            // l38
            // 
            this.l38.AutoSize = true;
            this.l38.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l38.Location = new System.Drawing.Point(147, 214);
            this.l38.Name = "l38";
            this.l38.Size = new System.Drawing.Size(0, 18);
            this.l38.TabIndex = 3;
            // 
            // l39
            // 
            this.l39.AutoSize = true;
            this.l39.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l39.Location = new System.Drawing.Point(189, 214);
            this.l39.Name = "l39";
            this.l39.Size = new System.Drawing.Size(0, 18);
            this.l39.TabIndex = 3;
            // 
            // l40
            // 
            this.l40.AutoSize = true;
            this.l40.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l40.Location = new System.Drawing.Point(224, 214);
            this.l40.Name = "l40";
            this.l40.Size = new System.Drawing.Size(0, 18);
            this.l40.TabIndex = 3;
            // 
            // l41
            // 
            this.l41.AutoSize = true;
            this.l41.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l41.Location = new System.Drawing.Point(263, 214);
            this.l41.Name = "l41";
            this.l41.Size = new System.Drawing.Size(0, 18);
            this.l41.TabIndex = 3;
            // 
            // Calender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.datePanel);
            this.Controls.Add(this.daysPanel);
            this.Controls.Add(this.headerPanel);
            this.Name = "Calender";
            this.Size = new System.Drawing.Size(322, 367);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.daysPanel.ResumeLayout(false);
            this.daysPanel.PerformLayout();
            this.datePanel.ResumeLayout(false);
            this.datePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox monthCB;
        private System.Windows.Forms.ComboBox yearCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label sunLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel daysPanel;
        private System.Windows.Forms.Panel datePanel;
        private System.Windows.Forms.Label l29;
        private System.Windows.Forms.Label l22;
        private System.Windows.Forms.Label l15;
        private System.Windows.Forms.Label l8;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Label l35;
        private System.Windows.Forms.Label l28;
        private System.Windows.Forms.Label l21;
        private System.Windows.Forms.Label l14;
        private System.Windows.Forms.Label l7;
        private System.Windows.Forms.Label l34;
        private System.Windows.Forms.Label l27;
        private System.Windows.Forms.Label l20;
        private System.Windows.Forms.Label l13;
        private System.Windows.Forms.Label l6;
        private System.Windows.Forms.Label l33;
        private System.Windows.Forms.Label l26;
        private System.Windows.Forms.Label l19;
        private System.Windows.Forms.Label l12;
        private System.Windows.Forms.Label l5;
        private System.Windows.Forms.Label l32;
        private System.Windows.Forms.Label l25;
        private System.Windows.Forms.Label l18;
        private System.Windows.Forms.Label l31;
        private System.Windows.Forms.Label l24;
        private System.Windows.Forms.Label l11;
        private System.Windows.Forms.Label l17;
        private System.Windows.Forms.Label l4;
        private System.Windows.Forms.Label l30;
        private System.Windows.Forms.Label l23;
        private System.Windows.Forms.Label l10;
        private System.Windows.Forms.Label l16;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.Label l9;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Button todayBtn;
        private System.Windows.Forms.Label l41;
        private System.Windows.Forms.Label l40;
        private System.Windows.Forms.Label l39;
        private System.Windows.Forms.Label l38;
        private System.Windows.Forms.Label l37;
        private System.Windows.Forms.Label l36;
    }
}

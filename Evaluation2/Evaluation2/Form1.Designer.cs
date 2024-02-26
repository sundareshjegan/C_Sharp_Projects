namespace Evaluation2
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
            this.label1 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.viewBtn = new System.Windows.Forms.Button();
            this.expenseDataGridView = new System.Windows.Forms.DataGridView();
            this.cb = new System.Windows.Forms.ComboBox();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.rangePanel = new System.Windows.Forms.Panel();
            this.customDateOkBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.expenseDataGridView)).BeginInit();
            this.rangePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(224, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Expense Tracker";
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(21, 55);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(92, 34);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.OnAddBtnClicked);
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveBtn.Location = new System.Drawing.Point(21, 95);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(92, 34);
            this.RemoveBtn.TabIndex = 1;
            this.RemoveBtn.Text = "Remove";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.Location = new System.Drawing.Point(289, 57);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(78, 27);
            this.editBtn.TabIndex = 1;
            this.editBtn.Text = "Reset";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.OnEditBtnClicked);
            // 
            // viewBtn
            // 
            this.viewBtn.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBtn.Location = new System.Drawing.Point(119, 55);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(164, 31);
            this.viewBtn.TabIndex = 1;
            this.viewBtn.Text = "ViewOptions";
            this.viewBtn.UseVisualStyleBackColor = true;
            this.viewBtn.Click += new System.EventHandler(this.OnViewBtnClicked);
            // 
            // expenseDataGridView
            // 
            this.expenseDataGridView.AllowUserToAddRows = false;
            this.expenseDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.expenseDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.expenseDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.expenseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.expenseDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.expenseDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.expenseDataGridView.Location = new System.Drawing.Point(0, 188);
            this.expenseDataGridView.Name = "expenseDataGridView";
            this.expenseDataGridView.RowHeadersVisible = false;
            this.expenseDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.expenseDataGridView.Size = new System.Drawing.Size(617, 228);
            this.expenseDataGridView.TabIndex = 2;
            this.expenseDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnCellClicked);
            // 
            // cb
            // 
            this.cb.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb.FormattingEnabled = true;
            this.cb.Location = new System.Drawing.Point(426, 55);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(164, 26);
            this.cb.TabIndex = 3;
            this.cb.Visible = false;
            this.cb.SelectedIndexChanged += new System.EventHandler(this.OnCbValueChanged);
            // 
            // startDatePicker
            // 
            this.startDatePicker.CalendarFont = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDatePicker.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDatePicker.Location = new System.Drawing.Point(62, 3);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(157, 23);
            this.startDatePicker.TabIndex = 4;
            // 
            // rangePanel
            // 
            this.rangePanel.Controls.Add(this.customDateOkBtn);
            this.rangePanel.Controls.Add(this.label3);
            this.rangePanel.Controls.Add(this.endDatePicker);
            this.rangePanel.Controls.Add(this.label2);
            this.rangePanel.Controls.Add(this.startDatePicker);
            this.rangePanel.Location = new System.Drawing.Point(172, 92);
            this.rangePanel.Name = "rangePanel";
            this.rangePanel.Size = new System.Drawing.Size(418, 65);
            this.rangePanel.TabIndex = 5;
            this.rangePanel.Visible = false;
            // 
            // customDateOkBtn
            // 
            this.customDateOkBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customDateOkBtn.Location = new System.Drawing.Point(174, 32);
            this.customDateOkBtn.Name = "customDateOkBtn";
            this.customDateOkBtn.Size = new System.Drawing.Size(75, 30);
            this.customDateOkBtn.TabIndex = 6;
            this.customDateOkBtn.Text = "OK";
            this.customDateOkBtn.UseVisualStyleBackColor = true;
            this.customDateOkBtn.Click += new System.EventHandler(this.OnCustomDateOkBtnClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(225, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "To";
            // 
            // endDatePicker
            // 
            this.endDatePicker.CalendarFont = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDatePicker.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDatePicker.Location = new System.Drawing.Point(255, 3);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(157, 23);
            this.endDatePicker.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "From";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(617, 416);
            this.Controls.Add(this.rangePanel);
            this.Controls.Add(this.cb);
            this.Controls.Add(this.expenseDataGridView);
            this.Controls.Add(this.viewBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.RemoveBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expense Tracker";
            ((System.ComponentModel.ISupportInitialize)(this.expenseDataGridView)).EndInit();
            this.rangePanel.ResumeLayout(false);
            this.rangePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button viewBtn;
        private System.Windows.Forms.DataGridView expenseDataGridView;
        private System.Windows.Forms.ComboBox cb;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.Panel rangePanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button customDateOkBtn;
    }
}


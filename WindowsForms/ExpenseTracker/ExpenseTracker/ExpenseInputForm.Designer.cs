namespace ExpenseTracker
{
    partial class ExpenseInputForm
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
            this.NameTB = new System.Windows.Forms.TextBox();
            this.categoryTB = new System.Windows.Forms.ComboBox();
            this.amountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.amountTB = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.descriptionTB = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // NameTB
            // 
            this.NameTB.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTB.ForeColor = System.Drawing.Color.DodgerBlue;
            this.NameTB.Location = new System.Drawing.Point(27, 61);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(244, 30);
            this.NameTB.TabIndex = 0;
            this.NameTB.TabStop = false;
            this.NameTB.Text = "Name";
            this.NameTB.Click += new System.EventHandler(this.NameTB_Click);
            // 
            // categoryTB
            // 
            this.categoryTB.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryTB.ForeColor = System.Drawing.Color.DodgerBlue;
            this.categoryTB.FormattingEnabled = true;
            this.categoryTB.Location = new System.Drawing.Point(27, 97);
            this.categoryTB.Name = "categoryTB";
            this.categoryTB.Size = new System.Drawing.Size(244, 32);
            this.categoryTB.TabIndex = 1;
            this.categoryTB.TabStop = false;
            this.categoryTB.Text = "Category";
            // 
            // amountNumericUpDown
            // 
            this.amountNumericUpDown.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountNumericUpDown.Location = new System.Drawing.Point(27, 135);
            this.amountNumericUpDown.Name = "amountNumericUpDown";
            this.amountNumericUpDown.Size = new System.Drawing.Size(244, 30);
            this.amountNumericUpDown.TabIndex = 2;
            // 
            // amountTB
            // 
            this.amountTB.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountTB.ForeColor = System.Drawing.Color.DodgerBlue;
            this.amountTB.Location = new System.Drawing.Point(27, 135);
            this.amountTB.Name = "amountTB";
            this.amountTB.Size = new System.Drawing.Size(244, 30);
            this.amountTB.TabIndex = 0;
            this.amountTB.TabStop = false;
            this.amountTB.Text = "Amount";
            this.amountTB.Click += new System.EventHandler(this.OnAmountTBClick);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarForeColor = System.Drawing.Color.Magenta;
            this.dateTimePicker.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dateTimePicker.CalendarTrailingForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dateTimePicker.CustomFormat = "";
            this.dateTimePicker.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(27, 25);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(244, 30);
            this.dateTimePicker.TabIndex = 3;
            // 
            // descriptionTB
            // 
            this.descriptionTB.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTB.ForeColor = System.Drawing.Color.DodgerBlue;
            this.descriptionTB.Location = new System.Drawing.Point(27, 171);
            this.descriptionTB.Multiline = true;
            this.descriptionTB.Name = "descriptionTB";
            this.descriptionTB.Size = new System.Drawing.Size(244, 127);
            this.descriptionTB.TabIndex = 0;
            this.descriptionTB.TabStop = false;
            this.descriptionTB.Text = "Description";
            this.descriptionTB.Click += new System.EventHandler(this.DescriptionTBClick);
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.saveBtn.Location = new System.Drawing.Point(157, 313);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 31);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.OnSaveBtnClicked);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cancelBtn.Location = new System.Drawing.Point(66, 313);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 31);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.OncancelBtnClicked);
            // 
            // ExpenseInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::ExpenseTracker.Properties.Resources.bluegradient;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(321, 361);
            this.ControlBox = false;
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.categoryTB);
            this.Controls.Add(this.amountTB);
            this.Controls.Add(this.descriptionTB);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.amountNumericUpDown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExpenseInputForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OnExpenseInputFormPaint);
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.ComboBox categoryTB;
        private System.Windows.Forms.NumericUpDown amountNumericUpDown;
        private System.Windows.Forms.TextBox amountTB;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox descriptionTB;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}
namespace Evaluation2
{
    partial class InputUC
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.categoryTB = new System.Windows.Forms.ComboBox();
            this.amountTB = new System.Windows.Forms.NumericUpDown();
            this.dateTB = new System.Windows.Forms.DateTimePicker();
            this.descriptionTB = new System.Windows.Forms.RichTextBox();
            this.saveExpenseBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.addCategoryBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.amountTB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "*Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Description";
            // 
            // categoryTB
            // 
            this.categoryTB.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryTB.FormattingEnabled = true;
            this.categoryTB.Items.AddRange(new object[] {
            "Travel",
            "Food",
            "Education",
            "Others"});
            this.categoryTB.Location = new System.Drawing.Point(189, 137);
            this.categoryTB.Name = "categoryTB";
            this.categoryTB.Size = new System.Drawing.Size(181, 26);
            this.categoryTB.TabIndex = 1;
            this.categoryTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnCategoryKeyPress);
            // 
            // amountTB
            // 
            this.amountTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountTB.Location = new System.Drawing.Point(189, 173);
            this.amountTB.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.amountTB.Name = "amountTB";
            this.amountTB.Size = new System.Drawing.Size(181, 26);
            this.amountTB.TabIndex = 2;
            this.amountTB.ValueChanged += new System.EventHandler(this.amountTB_ValueChanged);
            // 
            // dateTB
            // 
            this.dateTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTB.Location = new System.Drawing.Point(189, 221);
            this.dateTB.Name = "dateTB";
            this.dateTB.Size = new System.Drawing.Size(181, 26);
            this.dateTB.TabIndex = 3;
            // 
            // descriptionTB
            // 
            this.descriptionTB.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTB.Location = new System.Drawing.Point(184, 272);
            this.descriptionTB.Name = "descriptionTB";
            this.descriptionTB.Size = new System.Drawing.Size(186, 78);
            this.descriptionTB.TabIndex = 4;
            this.descriptionTB.Text = "";
            // 
            // saveExpenseBtn
            // 
            this.saveExpenseBtn.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveExpenseBtn.Location = new System.Drawing.Point(150, 380);
            this.saveExpenseBtn.Name = "saveExpenseBtn";
            this.saveExpenseBtn.Size = new System.Drawing.Size(89, 31);
            this.saveExpenseBtn.TabIndex = 5;
            this.saveExpenseBtn.Text = "Save";
            this.saveExpenseBtn.UseVisualStyleBackColor = true;
            this.saveExpenseBtn.Click += new System.EventHandler(this.OnSaveBtnClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(74, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(279, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Expense Tracker Application";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(74, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "*Name";
            // 
            // nameTB
            // 
            this.nameTB.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTB.Location = new System.Drawing.Point(189, 96);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(181, 26);
            this.nameTB.TabIndex = 6;
            // 
            // addCategoryBtn
            // 
            this.addCategoryBtn.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCategoryBtn.Location = new System.Drawing.Point(376, 136);
            this.addCategoryBtn.Name = "addCategoryBtn";
            this.addCategoryBtn.Size = new System.Drawing.Size(30, 26);
            this.addCategoryBtn.TabIndex = 5;
            this.addCategoryBtn.Text = "+";
            this.addCategoryBtn.UseVisualStyleBackColor = true;
            this.addCategoryBtn.Click += new System.EventHandler(this.OnAddCategoryBtnClicked);
            // 
            // InputUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.addCategoryBtn);
            this.Controls.Add(this.saveExpenseBtn);
            this.Controls.Add(this.descriptionTB);
            this.Controls.Add(this.dateTB);
            this.Controls.Add(this.amountTB);
            this.Controls.Add(this.categoryTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "InputUC";
            this.Size = new System.Drawing.Size(417, 427);
            ((System.ComponentModel.ISupportInitialize)(this.amountTB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox categoryTB;
        private System.Windows.Forms.NumericUpDown amountTB;
        private System.Windows.Forms.DateTimePicker dateTB;
        private System.Windows.Forms.RichTextBox descriptionTB;
        private System.Windows.Forms.Button saveExpenseBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Button addCategoryBtn;
    }
}

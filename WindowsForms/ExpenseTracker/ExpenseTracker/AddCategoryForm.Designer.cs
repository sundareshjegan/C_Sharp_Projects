namespace ExpenseTracker
{
    partial class AddCategoryForm
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
            this.addCategoryLabel = new System.Windows.Forms.Label();
            this.newCategoryTB = new System.Windows.Forms.TextBox();
            this.okBtn = new System.Windows.Forms.Button();
            this.addCancelBtn = new System.Windows.Forms.Button();
            this.AddCategoryPanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.UpdateCategoryPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.updateCancel = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.RemoveCategoryPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.deleteCancel = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.AddCategoryPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.UpdateCategoryPanel.SuspendLayout();
            this.RemoveCategoryPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // addCategoryLabel
            // 
            this.addCategoryLabel.AutoSize = true;
            this.addCategoryLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCategoryLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.addCategoryLabel.Location = new System.Drawing.Point(22, 85);
            this.addCategoryLabel.Name = "addCategoryLabel";
            this.addCategoryLabel.Size = new System.Drawing.Size(168, 25);
            this.addCategoryLabel.TabIndex = 0;
            this.addCategoryLabel.Text = "Category Name";
            // 
            // newCategoryTB
            // 
            this.newCategoryTB.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newCategoryTB.Location = new System.Drawing.Point(206, 85);
            this.newCategoryTB.Name = "newCategoryTB";
            this.newCategoryTB.Size = new System.Drawing.Size(247, 32);
            this.newCategoryTB.TabIndex = 1;
            // 
            // okBtn
            // 
            this.okBtn.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.okBtn.Location = new System.Drawing.Point(299, 135);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(81, 39);
            this.okBtn.TabIndex = 2;
            this.okBtn.Text = "Add";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.OnBtnClicked);
            // 
            // addCancelBtn
            // 
            this.addCancelBtn.BackColor = System.Drawing.Color.LightSalmon;
            this.addCancelBtn.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCancelBtn.Location = new System.Drawing.Point(101, 135);
            this.addCancelBtn.Name = "addCancelBtn";
            this.addCancelBtn.Size = new System.Drawing.Size(89, 39);
            this.addCancelBtn.TabIndex = 2;
            this.addCancelBtn.Text = "Cancel";
            this.addCancelBtn.UseVisualStyleBackColor = false;
            this.addCancelBtn.Click += new System.EventHandler(this.OnCancelBtnClicked);
            // 
            // AddCategoryPanel
            // 
            this.AddCategoryPanel.Controls.Add(this.addCategoryLabel);
            this.AddCategoryPanel.Controls.Add(this.label6);
            this.AddCategoryPanel.Controls.Add(this.addCancelBtn);
            this.AddCategoryPanel.Controls.Add(this.newCategoryTB);
            this.AddCategoryPanel.Controls.Add(this.okBtn);
            this.AddCategoryPanel.Location = new System.Drawing.Point(206, 12);
            this.AddCategoryPanel.Name = "AddCategoryPanel";
            this.AddCategoryPanel.Size = new System.Drawing.Size(490, 203);
            this.AddCategoryPanel.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(131, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(228, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "ADD NEW CATEGORY";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 734);
            this.panel2.TabIndex = 4;
            // 
            // UpdateCategoryPanel
            // 
            this.UpdateCategoryPanel.Controls.Add(this.label3);
            this.UpdateCategoryPanel.Controls.Add(this.label4);
            this.UpdateCategoryPanel.Controls.Add(this.label1);
            this.UpdateCategoryPanel.Controls.Add(this.textBox3);
            this.UpdateCategoryPanel.Controls.Add(this.updateCancel);
            this.UpdateCategoryPanel.Controls.Add(this.textBox1);
            this.UpdateCategoryPanel.Controls.Add(this.updateBtn);
            this.UpdateCategoryPanel.Location = new System.Drawing.Point(206, 232);
            this.UpdateCategoryPanel.Name = "UpdateCategoryPanel";
            this.UpdateCategoryPanel.Size = new System.Drawing.Size(490, 254);
            this.UpdateCategoryPanel.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(33, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "New Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(97, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(316, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "UPDATE EXISTING CATEGORY";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(23, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Existing Category";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(207, 133);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(247, 32);
            this.textBox3.TabIndex = 1;
            // 
            // updateCancel
            // 
            this.updateCancel.BackColor = System.Drawing.Color.LightSalmon;
            this.updateCancel.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCancel.Location = new System.Drawing.Point(102, 200);
            this.updateCancel.Name = "updateCancel";
            this.updateCancel.Size = new System.Drawing.Size(89, 39);
            this.updateCancel.TabIndex = 2;
            this.updateCancel.Text = "Cancel";
            this.updateCancel.UseVisualStyleBackColor = false;
            this.updateCancel.Click += new System.EventHandler(this.OnCancelBtnClicked);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(207, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(247, 32);
            this.textBox1.TabIndex = 1;
            // 
            // updateBtn
            // 
            this.updateBtn.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.updateBtn.Location = new System.Drawing.Point(300, 200);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(81, 39);
            this.updateBtn.TabIndex = 2;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            // 
            // RemoveCategoryPanel
            // 
            this.RemoveCategoryPanel.Controls.Add(this.label2);
            this.RemoveCategoryPanel.Controls.Add(this.label5);
            this.RemoveCategoryPanel.Controls.Add(this.deleteCancel);
            this.RemoveCategoryPanel.Controls.Add(this.textBox2);
            this.RemoveCategoryPanel.Controls.Add(this.deleteBtn);
            this.RemoveCategoryPanel.Location = new System.Drawing.Point(206, 504);
            this.RemoveCategoryPanel.Name = "RemoveCategoryPanel";
            this.RemoveCategoryPanel.Size = new System.Drawing.Size(490, 192);
            this.RemoveCategoryPanel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(22, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Category Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(153, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "DELETE CATEGORY";
            // 
            // deleteCancel
            // 
            this.deleteCancel.BackColor = System.Drawing.Color.LightSalmon;
            this.deleteCancel.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCancel.Location = new System.Drawing.Point(101, 120);
            this.deleteCancel.Name = "deleteCancel";
            this.deleteCancel.Size = new System.Drawing.Size(89, 39);
            this.deleteCancel.TabIndex = 2;
            this.deleteCancel.Text = "Cancel";
            this.deleteCancel.UseVisualStyleBackColor = false;
            this.deleteCancel.Click += new System.EventHandler(this.OnCancelBtnClicked);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(206, 70);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(247, 32);
            this.textBox2.TabIndex = 1;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.deleteBtn.Location = new System.Drawing.Point(299, 120);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(81, 39);
            this.deleteBtn.TabIndex = 2;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.OnBtnClicked);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button1.Location = new System.Drawing.Point(29, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnBtnClicked);
            // 
            // AddCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 734);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.RemoveCategoryPanel);
            this.Controls.Add(this.UpdateCategoryPanel);
            this.Controls.Add(this.AddCategoryPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddCategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.AddCategoryPanel.ResumeLayout(false);
            this.AddCategoryPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.UpdateCategoryPanel.ResumeLayout(false);
            this.UpdateCategoryPanel.PerformLayout();
            this.RemoveCategoryPanel.ResumeLayout(false);
            this.RemoveCategoryPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label addCategoryLabel;
        private System.Windows.Forms.TextBox newCategoryTB;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button addCancelBtn;
        private System.Windows.Forms.Panel AddCategoryPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel UpdateCategoryPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button updateCancel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Panel RemoveCategoryPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deleteCancel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}
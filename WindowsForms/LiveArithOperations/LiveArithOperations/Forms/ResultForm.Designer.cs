namespace LiveArithOperations
{
    partial class ResultForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.DivRadioButton = new System.Windows.Forms.RadioButton();
            this.MulRadioButton = new System.Windows.Forms.RadioButton();
            this.SubRadioButton = new System.Windows.Forms.RadioButton();
            this.AddRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Result : ";
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultLabel.Location = new System.Drawing.Point(144, 121);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(15, 24);
            this.ResultLabel.TabIndex = 0;
            this.ResultLabel.Text = " ";
            // 
            // DivRadioButton
            // 
            this.DivRadioButton.AutoSize = true;
            this.DivRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivRadioButton.Location = new System.Drawing.Point(239, 237);
            this.DivRadioButton.Name = "DivRadioButton";
            this.DivRadioButton.Size = new System.Drawing.Size(43, 29);
            this.DivRadioButton.TabIndex = 1;
            this.DivRadioButton.Text = "÷";
            this.DivRadioButton.UseVisualStyleBackColor = true;
            // 
            // MulRadioButton
            // 
            this.MulRadioButton.AutoSize = true;
            this.MulRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MulRadioButton.Location = new System.Drawing.Point(175, 237);
            this.MulRadioButton.Name = "MulRadioButton";
            this.MulRadioButton.Size = new System.Drawing.Size(42, 29);
            this.MulRadioButton.TabIndex = 2;
            this.MulRadioButton.Text = "x";
            this.MulRadioButton.UseVisualStyleBackColor = true;
            // 
            // SubRadioButton
            // 
            this.SubRadioButton.AutoSize = true;
            this.SubRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubRadioButton.Location = new System.Drawing.Point(120, 237);
            this.SubRadioButton.Name = "SubRadioButton";
            this.SubRadioButton.Size = new System.Drawing.Size(38, 29);
            this.SubRadioButton.TabIndex = 3;
            this.SubRadioButton.Text = "-";
            this.SubRadioButton.UseVisualStyleBackColor = true;
            // 
            // AddRadioButton
            // 
            this.AddRadioButton.AutoSize = true;
            this.AddRadioButton.Checked = true;
            this.AddRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddRadioButton.Location = new System.Drawing.Point(65, 237);
            this.AddRadioButton.Name = "AddRadioButton";
            this.AddRadioButton.Size = new System.Drawing.Size(43, 29);
            this.AddRadioButton.TabIndex = 4;
            this.AddRadioButton.TabStop = true;
            this.AddRadioButton.Text = "+";
            this.AddRadioButton.UseVisualStyleBackColor = true;
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 450);
            this.Controls.Add(this.DivRadioButton);
            this.Controls.Add(this.MulRadioButton);
            this.Controls.Add(this.SubRadioButton);
            this.Controls.Add(this.AddRadioButton);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(150, 250);
            this.Name = "ResultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ResultForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.RadioButton DivRadioButton;
        private System.Windows.Forms.RadioButton MulRadioButton;
        private System.Windows.Forms.RadioButton SubRadioButton;
        private System.Windows.Forms.RadioButton AddRadioButton;
    }
}
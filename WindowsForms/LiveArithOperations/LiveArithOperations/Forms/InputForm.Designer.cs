namespace LiveArithOperations
{
    partial class InputForm
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
            this.num1TB = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.num2TB = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.num1TB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num2TB)).BeginInit();
            this.SuspendLayout();
            // 
            // num1TB
            // 
            this.num1TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1TB.Location = new System.Drawing.Point(160, 123);
            this.num1TB.Maximum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            0});
            this.num1TB.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.num1TB.Name = "num1TB";
            this.num1TB.Size = new System.Drawing.Size(120, 26);
            this.num1TB.TabIndex = 1;
            
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number : 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number : 2";
            // 
            // num2TB
            // 
            this.num2TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2TB.Location = new System.Drawing.Point(160, 170);
            this.num2TB.Maximum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            0});
            this.num2TB.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.num2TB.Name = "num2TB";
            this.num2TB.Size = new System.Drawing.Size(120, 26);
            this.num2TB.TabIndex = 1;
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.num2TB);
            this.Controls.Add(this.num1TB);
            this.Location = new System.Drawing.Point(550, 250);
            this.Name = "InputForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "InputForm";
            ((System.ComponentModel.ISupportInitialize)(this.num1TB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num2TB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown num1TB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown num2TB;
    }
}


namespace MoneyConverter {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.cmbFirstCurrency = new System.Windows.Forms.ComboBox();
            this.cmbSecondCurrency = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbFirstCurrency
            // 
            this.cmbFirstCurrency.FormattingEnabled = true;
            this.cmbFirstCurrency.Location = new System.Drawing.Point(40, 61);
            this.cmbFirstCurrency.Name = "cmbFirstCurrency";
            this.cmbFirstCurrency.Size = new System.Drawing.Size(176, 24);
            this.cmbFirstCurrency.TabIndex = 0;
            // 
            // cmbSecondCurrency
            // 
            this.cmbSecondCurrency.FormattingEnabled = true;
            this.cmbSecondCurrency.Location = new System.Drawing.Point(45, 133);
            this.cmbSecondCurrency.Name = "cmbSecondCurrency";
            this.cmbSecondCurrency.Size = new System.Drawing.Size(171, 24);
            this.cmbSecondCurrency.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(45, 206);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 22);
            this.textBox1.TabIndex = 2;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(80, 253);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(94, 49);
            this.btnConvert.TabIndex = 3;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(45, 343);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(171, 22);
            this.textBox2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Choose first currency :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Choose second currency :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Enter amount :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Converted :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 395);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cmbSecondCurrency);
            this.Controls.Add(this.cmbFirstCurrency);
            this.Name = "Form1";
            this.Text = "Money Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbFirstCurrency;
        private System.Windows.Forms.ComboBox cmbSecondCurrency;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}


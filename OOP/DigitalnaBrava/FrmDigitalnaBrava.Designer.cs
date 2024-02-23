namespace DigitalnaBrava {
    partial class FrmDigitalnaBrava {
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
            this.txtBrKartice = new System.Windows.Forms.TextBox();
            this.txtPIN = new System.Windows.Forms.TextBox();
            this.btnVrata501 = new System.Windows.Forms.Button();
            this.btnVrata502 = new System.Windows.Forms.Button();
            this.btnVrata503 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBrKartice
            // 
            this.txtBrKartice.Location = new System.Drawing.Point(147, 32);
            this.txtBrKartice.Name = "txtBrKartice";
            this.txtBrKartice.Size = new System.Drawing.Size(100, 22);
            this.txtBrKartice.TabIndex = 0;
            // 
            // txtPIN
            // 
            this.txtPIN.Location = new System.Drawing.Point(147, 90);
            this.txtPIN.Name = "txtPIN";
            this.txtPIN.Size = new System.Drawing.Size(100, 22);
            this.txtPIN.TabIndex = 1;
            // 
            // btnVrata501
            // 
            this.btnVrata501.Location = new System.Drawing.Point(98, 177);
            this.btnVrata501.Name = "btnVrata501";
            this.btnVrata501.Size = new System.Drawing.Size(115, 62);
            this.btnVrata501.TabIndex = 2;
            this.btnVrata501.Text = "Otvori vrata br. 501";
            this.btnVrata501.UseVisualStyleBackColor = true;
            this.btnVrata501.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVrata502
            // 
            this.btnVrata502.Location = new System.Drawing.Point(260, 177);
            this.btnVrata502.Name = "btnVrata502";
            this.btnVrata502.Size = new System.Drawing.Size(115, 62);
            this.btnVrata502.TabIndex = 3;
            this.btnVrata502.Text = "Otvori vrata br. 502";
            this.btnVrata502.UseVisualStyleBackColor = true;
            this.btnVrata502.Click += new System.EventHandler(this.btnVrata502_Click);
            // 
            // btnVrata503
            // 
            this.btnVrata503.Location = new System.Drawing.Point(425, 177);
            this.btnVrata503.Name = "btnVrata503";
            this.btnVrata503.Size = new System.Drawing.Size(115, 62);
            this.btnVrata503.TabIndex = 4;
            this.btnVrata503.Text = "Otvori vrata br. 503";
            this.btnVrata503.UseVisualStyleBackColor = true;
            this.btnVrata503.Click += new System.EventHandler(this.btnVrata503_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Broj kartice :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "PIN :";
            // 
            // FrmDigitalnaBrava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 251);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVrata503);
            this.Controls.Add(this.btnVrata502);
            this.Controls.Add(this.btnVrata501);
            this.Controls.Add(this.txtPIN);
            this.Controls.Add(this.txtBrKartice);
            this.Name = "FrmDigitalnaBrava";
            this.Text = "Otvori";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBrKartice;
        private System.Windows.Forms.TextBox txtPIN;
        private System.Windows.Forms.Button btnVrata501;
        private System.Windows.Forms.Button btnVrata502;
        private System.Windows.Forms.Button btnVrata503;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


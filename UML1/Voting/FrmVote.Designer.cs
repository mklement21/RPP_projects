namespace Voting {
    partial class FrmVote {
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
            this.txtOIB = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFor = new System.Windows.Forms.Label();
            this.lblAgainst = new System.Windows.Forms.Label();
            this.lblAbstained = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtOIB
            // 
            this.txtOIB.Location = new System.Drawing.Point(39, 44);
            this.txtOIB.Name = "txtOIB";
            this.txtOIB.Size = new System.Drawing.Size(135, 22);
            this.txtOIB.TabIndex = 0;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(39, 170);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 43);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Submit vote";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(39, 107);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(165, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(351, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "FOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "AGAINST";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "ABSTAINED";
            // 
            // lblFor
            // 
            this.lblFor.AutoSize = true;
            this.lblFor.Location = new System.Drawing.Point(469, 70);
            this.lblFor.Name = "lblFor";
            this.lblFor.Size = new System.Drawing.Size(0, 16);
            this.lblFor.TabIndex = 6;
            // 
            // lblAgainst
            // 
            this.lblAgainst.AutoSize = true;
            this.lblAgainst.Location = new System.Drawing.Point(469, 115);
            this.lblAgainst.Name = "lblAgainst";
            this.lblAgainst.Size = new System.Drawing.Size(0, 16);
            this.lblAgainst.TabIndex = 7;
            // 
            // lblAbstained
            // 
            this.lblAbstained.AutoSize = true;
            this.lblAbstained.Location = new System.Drawing.Point(469, 162);
            this.lblAbstained.Name = "lblAbstained";
            this.lblAbstained.Size = new System.Drawing.Size(0, 16);
            this.lblAbstained.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(343, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "VOTE RESULTS :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Enter OIB :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Choose option";
            // 
            // FrmVote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 235);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblAbstained);
            this.Controls.Add(this.lblAgainst);
            this.Controls.Add(this.lblFor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtOIB);
            this.Name = "FrmVote";
            this.Text = "Vote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOIB;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFor;
        private System.Windows.Forms.Label lblAgainst;
        private System.Windows.Forms.Label lblAbstained;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}


namespace Tasks {
    partial class Tasks {
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
            this.dgvNotCompleted = new System.Windows.Forms.DataGridView();
            this.dgvCompleted = new System.Windows.Forms.DataGridView();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.cmbPrioritet = new System.Windows.Forms.ComboBox();
            this.btnComplete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotCompleted)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompleted)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNotCompleted
            // 
            this.dgvNotCompleted.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotCompleted.Location = new System.Drawing.Point(11, 36);
            this.dgvNotCompleted.Name = "dgvNotCompleted";
            this.dgvNotCompleted.RowHeadersWidth = 51;
            this.dgvNotCompleted.RowTemplate.Height = 24;
            this.dgvNotCompleted.Size = new System.Drawing.Size(810, 150);
            this.dgvNotCompleted.TabIndex = 0;
            // 
            // dgvCompleted
            // 
            this.dgvCompleted.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompleted.Location = new System.Drawing.Point(12, 271);
            this.dgvCompleted.Name = "dgvCompleted";
            this.dgvCompleted.RowHeadersWidth = 51;
            this.dgvCompleted.RowTemplate.Height = 24;
            this.dgvCompleted.Size = new System.Drawing.Size(817, 150);
            this.dgvCompleted.TabIndex = 1;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(15, 227);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(228, 22);
            this.txtDescription.TabIndex = 2;
            // 
            // cmbPrioritet
            // 
            this.cmbPrioritet.FormattingEnabled = true;
            this.cmbPrioritet.Location = new System.Drawing.Point(288, 225);
            this.cmbPrioritet.Name = "cmbPrioritet";
            this.cmbPrioritet.Size = new System.Drawing.Size(141, 24);
            this.cmbPrioritet.TabIndex = 3;
            // 
            // btnComplete
            // 
            this.btnComplete.Location = new System.Drawing.Point(837, 87);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(108, 44);
            this.btnComplete.TabIndex = 4;
            this.btnComplete.Text = "Mark as completed";
            this.btnComplete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(734, 214);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 35);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add task";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(471, 225);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(175, 24);
            this.cmbEmployee.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Otvoreni zadatci :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Izvršeni zadaci :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(285, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Prioritet";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(468, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Employee";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbEmployee);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.cmbPrioritet);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.dgvCompleted);
            this.Controls.Add(this.dgvNotCompleted);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotCompleted)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompleted)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNotCompleted;
        private System.Windows.Forms.DataGridView dgvCompleted;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ComboBox cmbPrioritet;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}


namespace TeachersProjects {
    partial class FrmTeacherProjects {
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
            this.cbTeachers = new System.Windows.Forms.ComboBox();
            this.btnReport = new System.Windows.Forms.Button();
            this.txtReports = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbTeachers
            // 
            this.cbTeachers.FormattingEnabled = true;
            this.cbTeachers.Location = new System.Drawing.Point(242, 81);
            this.cbTeachers.Name = "cbTeachers";
            this.cbTeachers.Size = new System.Drawing.Size(204, 24);
            this.cbTeachers.TabIndex = 0;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(641, 67);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(142, 38);
            this.btnReport.TabIndex = 1;
            this.btnReport.Text = "Show report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtReports
            // 
            this.txtReports.Location = new System.Drawing.Point(50, 127);
            this.txtReports.Multiline = true;
            this.txtReports.Name = "txtReports";
            this.txtReports.Size = new System.Drawing.Size(595, 219);
            this.txtReports.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose mentor (teacher)";
            // 
            // FrmTeacherProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 379);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtReports);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.cbTeachers);
            this.Name = "FrmTeacherProjects";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTeachers;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.TextBox txtReports;
        private System.Windows.Forms.Label label1;
    }
}


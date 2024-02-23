namespace _1tj {
    partial class Registration {
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
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.groupBoxOpcije = new System.Windows.Forms.GroupBox();
            this.rbdmin = new System.Windows.Forms.RadioButton();
            this.rbGost = new System.Windows.Forms.RadioButton();
            this.rbEmployee = new System.Windows.Forms.RadioButton();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBoxOpcije.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(127, 394);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(180, 43);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(200, 67);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(180, 22);
            this.txtPassword.TabIndex = 5;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(200, 29);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(180, 22);
            this.txtUsername.TabIndex = 4;
            // 
            // groupBoxOpcije
            // 
            this.groupBoxOpcije.Controls.Add(this.rbdmin);
            this.groupBoxOpcije.Controls.Add(this.rbGost);
            this.groupBoxOpcije.Controls.Add(this.rbEmployee);
            this.groupBoxOpcije.Location = new System.Drawing.Point(36, 210);
            this.groupBoxOpcije.Name = "groupBoxOpcije";
            this.groupBoxOpcije.Size = new System.Drawing.Size(405, 170);
            this.groupBoxOpcije.TabIndex = 7;
            this.groupBoxOpcije.TabStop = false;
            this.groupBoxOpcije.Text = "User type";
            // 
            // rbdmin
            // 
            this.rbdmin.AutoSize = true;
            this.rbdmin.Location = new System.Drawing.Point(43, 130);
            this.rbdmin.Name = "rbdmin";
            this.rbdmin.Size = new System.Drawing.Size(66, 20);
            this.rbdmin.TabIndex = 2;
            this.rbdmin.TabStop = true;
            this.rbdmin.Text = "Admin";
            this.rbdmin.UseVisualStyleBackColor = true;
            // 
            // rbGost
            // 
            this.rbGost.AutoSize = true;
            this.rbGost.Location = new System.Drawing.Point(43, 86);
            this.rbGost.Name = "rbGost";
            this.rbGost.Size = new System.Drawing.Size(56, 20);
            this.rbGost.TabIndex = 1;
            this.rbGost.TabStop = true;
            this.rbGost.Text = "Gost";
            this.rbGost.UseVisualStyleBackColor = true;
            // 
            // rbEmployee
            // 
            this.rbEmployee.AutoSize = true;
            this.rbEmployee.Location = new System.Drawing.Point(43, 43);
            this.rbEmployee.Name = "rbEmployee";
            this.rbEmployee.Size = new System.Drawing.Size(90, 20);
            this.rbEmployee.TabIndex = 0;
            this.rbEmployee.TabStop = true;
            this.rbEmployee.Text = "Employee";
            this.rbEmployee.UseVisualStyleBackColor = true;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(200, 118);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(180, 22);
            this.txtFirstName.TabIndex = 8;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(200, 165);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(180, 22);
            this.txtLastName.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "First name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Last name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Username :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Password :";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(323, 394);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(180, 43);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.groupBoxOpcije);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Name = "Registration";
            this.Text = "Registration";
            this.groupBoxOpcije.ResumeLayout(false);
            this.groupBoxOpcije.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.GroupBox groupBoxOpcije;
        private System.Windows.Forms.RadioButton rbdmin;
        private System.Windows.Forms.RadioButton rbGost;
        private System.Windows.Forms.RadioButton rbEmployee;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancel;
    }
}
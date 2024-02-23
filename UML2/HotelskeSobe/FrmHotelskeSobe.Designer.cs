namespace HotelskeSobe {
    partial class FrmHotelskeSobe {
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dgvSlobodneSobe = new System.Windows.Forms.DataGridView();
            this.btnPrikaziSlobodne = new System.Windows.Forms.Button();
            this.btnRezerviraj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSlobodneSobe)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(81, 68);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dgvSlobodneSobe
            // 
            this.dgvSlobodneSobe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSlobodneSobe.Location = new System.Drawing.Point(81, 187);
            this.dgvSlobodneSobe.Name = "dgvSlobodneSobe";
            this.dgvSlobodneSobe.RowHeadersWidth = 51;
            this.dgvSlobodneSobe.RowTemplate.Height = 24;
            this.dgvSlobodneSobe.Size = new System.Drawing.Size(507, 154);
            this.dgvSlobodneSobe.TabIndex = 1;
            // 
            // btnPrikaziSlobodne
            // 
            this.btnPrikaziSlobodne.Location = new System.Drawing.Point(381, 64);
            this.btnPrikaziSlobodne.Name = "btnPrikaziSlobodne";
            this.btnPrikaziSlobodne.Size = new System.Drawing.Size(207, 35);
            this.btnPrikaziSlobodne.TabIndex = 2;
            this.btnPrikaziSlobodne.Text = "Prikaži slobodne sobe";
            this.btnPrikaziSlobodne.UseVisualStyleBackColor = true;
            this.btnPrikaziSlobodne.Click += new System.EventHandler(this.btnPrikaziSlobodne_Click);
            // 
            // btnRezerviraj
            // 
            this.btnRezerviraj.Location = new System.Drawing.Point(317, 358);
            this.btnRezerviraj.Name = "btnRezerviraj";
            this.btnRezerviraj.Size = new System.Drawing.Size(102, 35);
            this.btnRezerviraj.TabIndex = 3;
            this.btnRezerviraj.Text = "Rezerviraj";
            this.btnRezerviraj.UseVisualStyleBackColor = true;
            this.btnRezerviraj.Click += new System.EventHandler(this.btnRezerviraj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Datum rezervacije :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Slobodne sobe";
            // 
            // FrmHotelskeSobe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 443);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRezerviraj);
            this.Controls.Add(this.btnPrikaziSlobodne);
            this.Controls.Add(this.dgvSlobodneSobe);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "FrmHotelskeSobe";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSlobodneSobe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dgvSlobodneSobe;
        private System.Windows.Forms.Button btnPrikaziSlobodne;
        private System.Windows.Forms.Button Rezerviraj;
        private System.Windows.Forms.Button btnRezerviraj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


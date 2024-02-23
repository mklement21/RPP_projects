namespace UpravljackaPloca {
    partial class FrmUpravljackaPloca {
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
            this.btnZatvori = new System.Windows.Forms.Button();
            this.btnOtvori = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnOtvoriSve = new System.Windows.Forms.Button();
            this.btnZatvoriSve = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(198, 364);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(153, 36);
            this.btnZatvori.TabIndex = 5;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // btnOtvori
            // 
            this.btnOtvori.Location = new System.Drawing.Point(198, 297);
            this.btnOtvori.Name = "btnOtvori";
            this.btnOtvori.Size = new System.Drawing.Size(153, 37);
            this.btnOtvori.TabIndex = 4;
            this.btnOtvori.Text = "Otvori";
            this.btnOtvori.UseVisualStyleBackColor = true;
            this.btnOtvori.Click += new System.EventHandler(this.btnOtvori_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(73, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(619, 214);
            this.dataGridView1.TabIndex = 3;
            // 
            // btnOtvoriSve
            // 
            this.btnOtvoriSve.Location = new System.Drawing.Point(441, 298);
            this.btnOtvoriSve.Name = "btnOtvoriSve";
            this.btnOtvoriSve.Size = new System.Drawing.Size(153, 36);
            this.btnOtvoriSve.TabIndex = 6;
            this.btnOtvoriSve.Text = "Otvori Sve";
            this.btnOtvoriSve.UseVisualStyleBackColor = true;
            this.btnOtvoriSve.Click += new System.EventHandler(this.btnOtvoriSve_Click);
            // 
            // btnZatvoriSve
            // 
            this.btnZatvoriSve.Location = new System.Drawing.Point(441, 364);
            this.btnZatvoriSve.Name = "btnZatvoriSve";
            this.btnZatvoriSve.Size = new System.Drawing.Size(153, 36);
            this.btnZatvoriSve.TabIndex = 7;
            this.btnZatvoriSve.Text = "Zatvori sve";
            this.btnZatvoriSve.UseVisualStyleBackColor = true;
            this.btnZatvoriSve.Click += new System.EventHandler(this.btnZatvoriSve_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Popis otvora";
            // 
            // FrmUpravljackaPloca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 439);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnZatvoriSve);
            this.Controls.Add(this.btnOtvoriSve);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.btnOtvori);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmUpravljackaPloca";
            this.Text = "Upravljacka ploča";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Button btnOtvori;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnOtvoriSve;
        private System.Windows.Forms.Button btnZatvoriSve;
        private System.Windows.Forms.Label label1;
    }
}


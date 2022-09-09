namespace PRoje_Okul
{
    partial class FrmSınavNotlar
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbders = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtsınav1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtogrid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsınav2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsınav3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtortalama = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtproje = new System.Windows.Forms.TextBox();
            this.txtdurum = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnhesapla = new System.Windows.Forms.Button();
            this.Temizle = new System.Windows.Forms.Button();
            this.btnara = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 221);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(645, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // cmbders
            // 
            this.cmbders.FormattingEnabled = true;
            this.cmbders.Location = new System.Drawing.Point(115, 53);
            this.cmbders.Name = "cmbders";
            this.cmbders.Size = new System.Drawing.Size(196, 31);
            this.cmbders.TabIndex = 54;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 23);
            this.label7.TabIndex = 52;
            this.label7.Text = "Sınav1:";
            // 
            // txtsınav1
            // 
            this.txtsınav1.Location = new System.Drawing.Point(115, 94);
            this.txtsınav1.Name = "txtsınav1";
            this.txtsınav1.Size = new System.Drawing.Size(196, 31);
            this.txtsınav1.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 23);
            this.label5.TabIndex = 48;
            this.label5.Text = "Ders:";
            // 
            // txtogrid
            // 
            this.txtogrid.Location = new System.Drawing.Point(115, 7);
            this.txtogrid.Name = "txtogrid";
            this.txtogrid.Size = new System.Drawing.Size(196, 31);
            this.txtogrid.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 23);
            this.label4.TabIndex = 46;
            this.label4.Text = "Öğrenci İd:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(334, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 23);
            this.label1.TabIndex = 56;
            this.label1.Text = "Ortalama:";
            // 
            // txtsınav2
            // 
            this.txtsınav2.Location = new System.Drawing.Point(115, 131);
            this.txtsınav2.Name = "txtsınav2";
            this.txtsınav2.Size = new System.Drawing.Size(196, 31);
            this.txtsınav2.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 23);
            this.label2.TabIndex = 58;
            this.label2.Text = "Sınav2:";
            // 
            // txtsınav3
            // 
            this.txtsınav3.Location = new System.Drawing.Point(115, 178);
            this.txtsınav3.Name = "txtsınav3";
            this.txtsınav3.Size = new System.Drawing.Size(196, 31);
            this.txtsınav3.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 23);
            this.label3.TabIndex = 60;
            this.label3.Text = "Sınav3:";
            // 
            // txtortalama
            // 
            this.txtortalama.Location = new System.Drawing.Point(429, 53);
            this.txtortalama.Name = "txtortalama";
            this.txtortalama.Size = new System.Drawing.Size(196, 31);
            this.txtortalama.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(367, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 23);
            this.label6.TabIndex = 62;
            this.label6.Text = "Proje:";
            // 
            // txtproje
            // 
            this.txtproje.Location = new System.Drawing.Point(429, 7);
            this.txtproje.Name = "txtproje";
            this.txtproje.Size = new System.Drawing.Size(196, 31);
            this.txtproje.TabIndex = 61;
            // 
            // txtdurum
            // 
            this.txtdurum.Location = new System.Drawing.Point(429, 94);
            this.txtdurum.Name = "txtdurum";
            this.txtdurum.Size = new System.Drawing.Size(196, 31);
            this.txtdurum.TabIndex = 64;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(353, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 23);
            this.label8.TabIndex = 63;
            this.label8.Text = "Durum:";
            // 
            // btnhesapla
            // 
            this.btnhesapla.Location = new System.Drawing.Point(357, 131);
            this.btnhesapla.Name = "btnhesapla";
            this.btnhesapla.Size = new System.Drawing.Size(137, 32);
            this.btnhesapla.TabIndex = 65;
            this.btnhesapla.Text = "Hesapla";
            this.btnhesapla.UseVisualStyleBackColor = true;
            this.btnhesapla.Click += new System.EventHandler(this.brnhesapla_Click);
            // 
            // Temizle
            // 
            this.Temizle.Location = new System.Drawing.Point(357, 173);
            this.Temizle.Name = "Temizle";
            this.Temizle.Size = new System.Drawing.Size(137, 32);
            this.Temizle.TabIndex = 66;
            this.Temizle.Text = "Temizle";
            this.Temizle.UseVisualStyleBackColor = true;
            // 
            // btnara
            // 
            this.btnara.Location = new System.Drawing.Point(500, 131);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(137, 32);
            this.btnara.TabIndex = 68;
            this.btnara.Text = "Ara";
            this.btnara.UseVisualStyleBackColor = true;
            this.btnara.Click += new System.EventHandler(this.btnara_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(631, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 32);
            this.button1.TabIndex = 69;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmSınavNotlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(674, 374);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnara);
            this.Controls.Add(this.Temizle);
            this.Controls.Add(this.btnhesapla);
            this.Controls.Add(this.txtdurum);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtproje);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtortalama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtsınav3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsınav2);
            this.Controls.Add(this.cmbders);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtsınav1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtogrid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FrmSınavNotlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSınavNotlar";
            this.Load += new System.EventHandler(this.FrmSınavNotlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbders;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtsınav1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtogrid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsınav2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsınav3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtortalama;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtproje;
        private System.Windows.Forms.TextBox txtdurum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnhesapla;
        private System.Windows.Forms.Button Temizle;
        private System.Windows.Forms.Button btnara;
        private System.Windows.Forms.Button button1;
    }
}
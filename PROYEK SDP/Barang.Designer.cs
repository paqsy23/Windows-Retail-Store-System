﻿namespace PROYEK_SDP
{
    partial class Barang
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.valuetext = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.keysearch = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericjual = new System.Windows.Forms.NumericUpDown();
            this.numericbeli = new System.Windows.Forms.NumericUpDown();
            this.numericstock = new System.Windows.Forms.NumericUpDown();
            this.warnatext = new System.Windows.Forms.TextBox();
            this.Inset = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.combogudang = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboukuran = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.combojenis = new System.Windows.Forms.ComboBox();
            this.namatext = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.idtext = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericjual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericbeli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericstock)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(317, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(671, 576);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Value";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Key";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Controls.Add(this.valuetext);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.keysearch);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 139);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // valuetext
            // 
            this.valuetext.Location = new System.Drawing.Point(81, 52);
            this.valuetext.Name = "valuetext";
            this.valuetext.Size = new System.Drawing.Size(193, 20);
            this.valuetext.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(81, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // keysearch
            // 
            this.keysearch.FormattingEnabled = true;
            this.keysearch.Items.AddRange(new object[] {
            "ID_BARANG",
            "NAMA_BARANG",
            "WARNA_BARANG",
            "UKURAN"});
            this.keysearch.Location = new System.Drawing.Point(81, 22);
            this.keysearch.Name = "keysearch";
            this.keysearch.Size = new System.Drawing.Size(193, 21);
            this.keysearch.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Controls.Add(this.numericjual);
            this.groupBox2.Controls.Add(this.numericbeli);
            this.groupBox2.Controls.Add(this.numericstock);
            this.groupBox2.Controls.Add(this.warnatext);
            this.groupBox2.Controls.Add(this.Inset);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.combogudang);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.comboukuran);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.combojenis);
            this.groupBox2.Controls.Add(this.namatext);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.idtext);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(288, 314);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Input Barang";
            // 
            // numericjual
            // 
            this.numericjual.Location = new System.Drawing.Point(88, 248);
            this.numericjual.Name = "numericjual";
            this.numericjual.Size = new System.Drawing.Size(186, 20);
            this.numericjual.TabIndex = 23;
            // 
            // numericbeli
            // 
            this.numericbeli.Location = new System.Drawing.Point(88, 214);
            this.numericbeli.Name = "numericbeli";
            this.numericbeli.Size = new System.Drawing.Size(186, 20);
            this.numericbeli.TabIndex = 22;
            // 
            // numericstock
            // 
            this.numericstock.Location = new System.Drawing.Point(88, 153);
            this.numericstock.Name = "numericstock";
            this.numericstock.Size = new System.Drawing.Size(186, 20);
            this.numericstock.TabIndex = 21;
            // 
            // warnatext
            // 
            this.warnatext.Location = new System.Drawing.Point(88, 128);
            this.warnatext.Name = "warnatext";
            this.warnatext.Size = new System.Drawing.Size(186, 20);
            this.warnatext.TabIndex = 20;
            // 
            // Inset
            // 
            this.Inset.Location = new System.Drawing.Point(88, 285);
            this.Inset.Name = "Inset";
            this.Inset.Size = new System.Drawing.Size(75, 23);
            this.Inset.TabIndex = 19;
            this.Inset.Text = "Insert";
            this.Inset.UseVisualStyleBackColor = true;
            this.Inset.Click += new System.EventHandler(this.Inset_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 250);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Harga Jual";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 216);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Harga Beli";
            // 
            // combogudang
            // 
            this.combogudang.FormattingEnabled = true;
            this.combogudang.Location = new System.Drawing.Point(88, 181);
            this.combogudang.Name = "combogudang";
            this.combogudang.Size = new System.Drawing.Size(186, 21);
            this.combogudang.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 184);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Gudang";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Stock";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Warna";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Ukuruan";
            // 
            // comboukuran
            // 
            this.comboukuran.FormattingEnabled = true;
            this.comboukuran.Items.AddRange(new object[] {
            "S",
            "M",
            "L",
            "XL"});
            this.comboukuran.Location = new System.Drawing.Point(88, 101);
            this.comboukuran.Name = "comboukuran";
            this.comboukuran.Size = new System.Drawing.Size(186, 21);
            this.comboukuran.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Jenis";
            // 
            // combojenis
            // 
            this.combojenis.FormattingEnabled = true;
            this.combojenis.Location = new System.Drawing.Point(88, 74);
            this.combojenis.Name = "combojenis";
            this.combojenis.Size = new System.Drawing.Size(186, 21);
            this.combojenis.TabIndex = 4;
            // 
            // namatext
            // 
            this.namatext.Location = new System.Drawing.Point(88, 48);
            this.namatext.Name = "namatext";
            this.namatext.Size = new System.Drawing.Size(186, 20);
            this.namatext.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Nama";
            // 
            // idtext
            // 
            this.idtext.Location = new System.Drawing.Point(88, 19);
            this.idtext.Name = "idtext";
            this.idtext.Size = new System.Drawing.Size(186, 20);
            this.idtext.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "ID";
            // 
            // Barang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Barang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Barang";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Barang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericjual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericbeli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericstock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox keysearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox idtext;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox warnatext;
        private System.Windows.Forms.Button Inset;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox combogudang;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboukuran;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox combojenis;
        private System.Windows.Forms.TextBox namatext;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox valuetext;
        private System.Windows.Forms.NumericUpDown numericjual;
        private System.Windows.Forms.NumericUpDown numericbeli;
        private System.Windows.Forms.NumericUpDown numericstock;
    }
}
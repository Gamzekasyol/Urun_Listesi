namespace Ürün_Listesi
{
    partial class Form1
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
            this.data_alanı = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtÜrün = new System.Windows.Forms.TextBox();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btngüncelle = new System.Windows.Forms.Button();
            this.txtfiyatgüncelle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtstokgüncelle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtürüngüncelle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnsil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_alanı)).BeginInit();
            this.SuspendLayout();
            // 
            // data_alanı
            // 
            this.data_alanı.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_alanı.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.data_alanı.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_alanı.Location = new System.Drawing.Point(445, 26);
            this.data_alanı.Name = "data_alanı";
            this.data_alanı.RowHeadersWidth = 51;
            this.data_alanı.RowTemplate.Height = 24;
            this.data_alanı.Size = new System.Drawing.Size(420, 414);
            this.data_alanı.TabIndex = 0;
            this.data_alanı.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_alanı_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "İsim";
            // 
            // txtÜrün
            // 
            this.txtÜrün.Location = new System.Drawing.Point(98, 27);
            this.txtÜrün.Name = "txtÜrün";
            this.txtÜrün.Size = new System.Drawing.Size(137, 22);
            this.txtÜrün.TabIndex = 2;
            // 
            // txtStok
            // 
            this.txtStok.Location = new System.Drawing.Point(98, 75);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(137, 22);
            this.txtStok.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Stok";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(98, 124);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(137, 22);
            this.txtFiyat.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fiyat";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(149, 173);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(103, 28);
            this.btnEkle.TabIndex = 7;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btngüncelle
            // 
            this.btngüncelle.Location = new System.Drawing.Point(149, 373);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Size = new System.Drawing.Size(103, 28);
            this.btngüncelle.TabIndex = 14;
            this.btngüncelle.Text = "Güncelle";
            this.btngüncelle.UseVisualStyleBackColor = true;
            this.btngüncelle.Click += new System.EventHandler(this.btngüncelle_Click);
            // 
            // txtfiyatgüncelle
            // 
            this.txtfiyatgüncelle.Location = new System.Drawing.Point(98, 332);
            this.txtfiyatgüncelle.Name = "txtfiyatgüncelle";
            this.txtfiyatgüncelle.Size = new System.Drawing.Size(137, 22);
            this.txtfiyatgüncelle.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Güncelle Fiyat";
            // 
            // txtstokgüncelle
            // 
            this.txtstokgüncelle.Location = new System.Drawing.Point(98, 281);
            this.txtstokgüncelle.Name = "txtstokgüncelle";
            this.txtstokgüncelle.Size = new System.Drawing.Size(137, 22);
            this.txtstokgüncelle.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Güncelle stok";
            // 
            // txtürüngüncelle
            // 
            this.txtürüngüncelle.Location = new System.Drawing.Point(98, 223);
            this.txtürüngüncelle.Name = "txtürüngüncelle";
            this.txtürüngüncelle.Size = new System.Drawing.Size(137, 22);
            this.txtürüngüncelle.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Güncelle İsim";
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(263, 403);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(103, 28);
            this.btnsil.TabIndex = 15;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 452);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btngüncelle);
            this.Controls.Add(this.txtfiyatgüncelle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtstokgüncelle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtürüngüncelle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtStok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtÜrün);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.data_alanı);
            this.Name = "Form1";
            this.Text = "Ürün Listesi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_alanı)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_alanı;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtÜrün;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btngüncelle;
        private System.Windows.Forms.TextBox txtfiyatgüncelle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtstokgüncelle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtürüngüncelle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnsil;
    }
}


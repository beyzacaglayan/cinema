namespace Sinema2
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_SalonAdı = new System.Windows.Forms.TextBox();
            this.txt_KoltukSayısı = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button_Biletİade = new System.Windows.Forms.Button();
            this.button_BiletSatış = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button_Bakiye = new System.Windows.Forms.Button();
            this.button_KalanKoltuk = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_SalonAdı
            // 
            this.txt_SalonAdı.Location = new System.Drawing.Point(166, 28);
            this.txt_SalonAdı.Name = "txt_SalonAdı";
            this.txt_SalonAdı.Size = new System.Drawing.Size(100, 20);
            this.txt_SalonAdı.TabIndex = 0;
            // 
            // txt_KoltukSayısı
            // 
            this.txt_KoltukSayısı.Location = new System.Drawing.Point(166, 77);
            this.txt_KoltukSayısı.Name = "txt_KoltukSayısı";
            this.txt_KoltukSayısı.Size = new System.Drawing.Size(100, 20);
            this.txt_KoltukSayısı.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(50, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Salon Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(53, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Koltuk Sayısı :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(334, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 49);
            this.button1.TabIndex = 4;
            this.button1.Text = "Oluştur";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_Biletİade
            // 
            this.button_Biletİade.Enabled = false;
            this.button_Biletİade.Location = new System.Drawing.Point(53, 143);
            this.button_Biletİade.Name = "button_Biletİade";
            this.button_Biletİade.Size = new System.Drawing.Size(104, 80);
            this.button_Biletİade.TabIndex = 5;
            this.button_Biletİade.Text = "Bilet İade";
            this.button_Biletİade.UseVisualStyleBackColor = true;
            this.button_Biletİade.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_BiletSatış
            // 
            this.button_BiletSatış.Enabled = false;
            this.button_BiletSatış.Location = new System.Drawing.Point(211, 143);
            this.button_BiletSatış.Name = "button_BiletSatış";
            this.button_BiletSatış.Size = new System.Drawing.Size(121, 80);
            this.button_BiletSatış.TabIndex = 6;
            this.button_BiletSatış.Text = "Bilet Satış";
            this.button_BiletSatış.UseVisualStyleBackColor = true;
            this.button_BiletSatış.Click += new System.EventHandler(this.button_BiletSatış_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(66, 269);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(60, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "İndirimli";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button_Bakiye
            // 
            this.button_Bakiye.Enabled = false;
            this.button_Bakiye.Location = new System.Drawing.Point(373, 142);
            this.button_Bakiye.Name = "button_Bakiye";
            this.button_Bakiye.Size = new System.Drawing.Size(75, 23);
            this.button_Bakiye.TabIndex = 8;
            this.button_Bakiye.Text = "Bakiye";
            this.button_Bakiye.UseVisualStyleBackColor = true;
            this.button_Bakiye.Click += new System.EventHandler(this.button_Bakiye_Click);
            // 
            // button_KalanKoltuk
            // 
            this.button_KalanKoltuk.Enabled = false;
            this.button_KalanKoltuk.Location = new System.Drawing.Point(373, 200);
            this.button_KalanKoltuk.Name = "button_KalanKoltuk";
            this.button_KalanKoltuk.Size = new System.Drawing.Size(75, 23);
            this.button_KalanKoltuk.TabIndex = 9;
            this.button_KalanKoltuk.Text = "Kalan Koltuk";
            this.button_KalanKoltuk.UseVisualStyleBackColor = true;
            this.button_KalanKoltuk.Click += new System.EventHandler(this.button_KalanKoltuk_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(506, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_KalanKoltuk);
            this.Controls.Add(this.button_Bakiye);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button_BiletSatış);
            this.Controls.Add(this.button_Biletİade);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_KoltukSayısı);
            this.Controls.Add(this.txt_SalonAdı);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_SalonAdı;
        private System.Windows.Forms.TextBox txt_KoltukSayısı;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_Biletİade;
        private System.Windows.Forms.Button button_BiletSatış;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button_Bakiye;
        private System.Windows.Forms.Button button_KalanKoltuk;
        private System.Windows.Forms.Label label3;
    }
}


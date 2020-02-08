using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema2
{
    public partial class Form1 : Form
    {
        SinemaClass mySinema = null; //1.satırdaki kod sinema sınıfından nesne üretir ve içinde hiç bir şey yok (bunu gösteren kod)
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string SalonAdı = txt_SalonAdı.Text;
            int KoltukSayısı = 0;


            bool result = Int32.TryParse(txt_KoltukSayısı.Text, out KoltukSayısı); //B,r methoa gönderilen parametre metot tarafından doldurup geri gönderilir 
            if (!result)
            {
                MessageBox.Show("Lütfen Sayısal İfade Giriniz");

            }
            if (SalonAdı.Length>0 && KoltukSayısı>0) 
            {
                mySinema = new SinemaClass(SalonAdı, KoltukSayısı);
                MessageBox.Show("Salon Oluşturuldu");
                button1.Enabled = false;
                //enabled erişibilirlik demek sonra bu butona tekrar erişilemeyecek yani yeni bir sinema oluşturulmayacak 
                button_Bakiye.Enabled = true;
                button_BiletSatış.Enabled = true;
                button_Biletİade.Enabled = true;
                button_KalanKoltuk.Enabled=true;
            }
            else
            {
                MessageBox.Show("Hatalı Veri Girişi","Hatalı",MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (mySinema.BosKoltukSayısı < mySinema.ToplamKoltukSayısı)
            {
                mySinema.Biletİade(true);
             }
            else
            {
                mySinema.Biletİade(false);
            }
            label3.Text = "Bilet İade Edildi. Toplam Bakiye: " + mySinema.BakiyeÖğren();
        }
           
        

        private void button_BiletSatış_Click(object sender, EventArgs e)
        {
            if (mySinema.BosKoltukSayısı>0)
            {
                if (checkBox1.Checked)
                {
                    mySinema.BiletSatış(true);

                }
                else
                {
                    mySinema.BiletSatış(false);
                }

                label3.Text = "Bilet Satıldı . Bakiye :";
                mySinema.BakiyeÖğren();

            }
            else
            {
                MessageBox.Show("Koltuk Kalmadı", "Hatalı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

      
    }
       
        private void button_Bakiye_Click(object sender, EventArgs e)
        {
            double ToplamBakiye = mySinema.BakiyeÖğren();
            label3.Text = "Güncel Bakiye:" + ToplamBakiye.ToString();
        }

        private void button_KalanKoltuk_Click(object sender, EventArgs e)
        {
            int KalanKoltuk = mySinema.KalanKoltukSayısıÖğren();
            label3.Text = "Güncel Boş Koltuk Sayısı : " + KalanKoltuk.ToString();
        }
    }
}

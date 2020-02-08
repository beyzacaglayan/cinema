using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinema2
{
    class SinemaClass
    {
        #region Properties

        public string SalonAdı { get; set; }
        public double Bakiye { get; set; }
        public int ToplamKoltukSayısı { get; set; }
        public int BosKoltukSayısı { get; set; }

        public const double TamBiletFİyat = 15;
        public const double İndirimliBiletFiyatı = 10;

        #endregion
        #region Consturctor

        //Kurucu Metot
        public SinemaClass (string p_SalonAdı, int p_KoltukSayısı)
        {
            SalonAdı = p_SalonAdı;
            ToplamKoltukSayısı = p_KoltukSayısı;
            BosKoltukSayısı = p_KoltukSayısı;
        }



        #endregion
        #region Methods
        public void BiletSatış (bool p_indirim )
        {
            BosKoltukSayısı--;
            if (p_indirim)
            {
                Bakiye += İndirimliBiletFiyatı;
            }
            else
            {
                Bakiye += TamBiletFİyat;
            }

        }
        public void Biletİade(bool p_İndirim)
        {
            BosKoltukSayısı++;
            if (p_İndirim)
            {
                Bakiye -= İndirimliBiletFiyatı;
            }
            else
            {
                Bakiye -= TamBiletFİyat;

            }
        }
        public double BakiyeÖğren()
        {
            return Bakiye;
        }
        public int KalanKoltukSayısıÖğren()
        {
            return BosKoltukSayısı;
        }
        
        
        
        
        
        
        
        
        #endregion
    }

}

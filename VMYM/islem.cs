using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace varmısınyokmusun
{
    class islem
    {
        private int[] kutular=new int[24]{1,2,5,10,25,50,75,100,200,300,400,500,750,5000,10000,15000,25000,50000,75000,100000,150000,250000,500000,500000};
        private int[] rastgele_kutular = new int[24];
        public int indis;
        private int secilen_kutu;
        public islem()
        {
            //rastegele indis üretme
            for (int i = 0; i <kutular.Length; i++)
            {
                int[] indistutucu = new int[24];
                Random rnd = new Random();
                indis = rnd.Next(0,24);
                int kutu = kutular[indis];
                if (kutu == 0) 
                { 
                    i--; 
                    continue; 
                }
                if (kutu != 0) 
                { 
                    rastgele_kutular[i]=kutu ;
                    kutular[indis] = 0;
                }
             }

        }
        public int[] kutu_goster() 
        {
            return rastgele_kutular;
        }
        public int kutu_secimi(int secilen_kutu_indisi)
        {
            int alim = 0;
            if (rastgele_kutular[secilen_kutu_indisi] != 0)
            {
                secilen_kutu = rastgele_kutular[secilen_kutu_indisi];
                return rastgele_kutular[secilen_kutu_indisi];
            }
            else
            { 
                for(int i = 0; i<rastgele_kutular.Length;i++)
                {
                    if (rastgele_kutular[i] != 0)
                    {
                        alim = i;
                        break;
                    }
                }
                secilen_kutu = rastgele_kutular[alim];
                return rastgele_kutular[alim];
            }
        }
        public int kutu_acma(int acılan_kutu_indisi)
        {
            return rastgele_kutular[acılan_kutu_indisi];
        }
        public void acılan_kutuları_sıfırlama(int acılan_kutu_indisi)
        {
            rastgele_kutular[acılan_kutu_indisi] = 0;
        }
        public int teklif_ver()
        {
            int kutu_deger_toplamı = 0;
            for (int i = 0; i < rastgele_kutular.Length; i++)
            {
                kutu_deger_toplamı += rastgele_kutular[i];
            }
            int teklif =( kutu_deger_toplamı / (rastgele_kutular.Length + 20));
            return teklif;
        }
        public void acılan_kutular(int p)
        {

            if (rastgele_kutular[p] == 0)
            {
                Console.Write("-");
                Console.Write(p+1);
                Console.Write("-");
            }
            
        }  
    }
}

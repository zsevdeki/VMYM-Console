using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace varmısınyokmusun
{
    class Program
    {
        static void Main(string[] args)
        {
            islem oyun = new islem();
            // menü oluşturalım
            Console.WriteLine(" _________   _________   _________   _________   _________");
            Console.WriteLine(" |   1   |   |   2   |   |   3   |   |   4   |   |   5   |");
            Console.WriteLine(" _________   _________   _________   _________   _________");
            Console.WriteLine(" |   6   |   |   7   |   |   8   |   |   9   |   |  10   |");
            Console.WriteLine(" _________   _________   _________   _________   _________");
            Console.WriteLine(" |  11   |   |  12   |   |  13   |   |  14   |   |  15   |");
            Console.WriteLine(" _________   _________   _________   _________   _________");
            Console.WriteLine(" |  16   |   |  17   |   |  18   |   |  19   |   |  20   |");
            Console.WriteLine(" _________   _________   _________   _________   ");
            Console.WriteLine(" |  21   |   |  22   |   |  23   |   |  24   |   ");
            // kutu seçimi
            Console.WriteLine("                                                          ");
            Console.WriteLine("            KENDİ KUTUNUZU SEÇİNİZ: (Kendi Kutunuzu ancak son seçimde açabilirsiniz.) ");                     
            int a = Convert.ToInt32(Console.ReadLine());
            oyun.kutu_secimi(a - 1);
            Console.Clear();
            Console.WriteLine("                      __________                           ");
            Console.WriteLine("                      |   {0}   |                          ",a);
            Console.WriteLine("                    SEÇTİĞİNİZ KUTU                        ");
            Console.ReadLine();
            Console.Clear();
            // kutu seçimi
            for (int i = 0; i < 7; i++)
            {
                if (i == 0)
                {
                    for (int z = 0; z < 8; z++)
                    {
                        int x = 8;
                        Console.WriteLine(" _________   _________   _________   _________   _________");
                        Console.WriteLine(" |   1   |   |   2   |   |   3   |   |   4   |   |   5   |");
                        Console.WriteLine(" _________   _________   _________   _________   _________");
                        Console.WriteLine(" |   6   |   |   7   |   |   8   |   |   9   |   |  10   |");
                        Console.WriteLine(" _________   _________   _________   _________   _________");
                        Console.WriteLine(" |  11   |   |  12   |   |  13   |   |  14   |   |  15   |");
                        Console.WriteLine(" _________   _________   _________   _________   _________");
                        Console.WriteLine(" |  16   |   |  17   |   |  18   |   |  19   |   |  20   |");
            Console.WriteLine(" _________   _________   _________   _________   ");
            Console.WriteLine(" |  21   |   |  22   |   |  23   |   |  24   |   ");
                        Console.WriteLine("");
                        Console.WriteLine("Kendi Kutunuzu ancak son seçimde açabilirsiniz.");
                        Console.WriteLine("Daha önce açtığınız kutular:");
                        for (int g = 0; g <24; g++)
                        {
                            oyun.acılan_kutular(g);
                        }
                        Console.WriteLine("");
                        Console.WriteLine("              {0} Kutu açmamız gerekiyor.       ", x);
                        x--;
                        int b = Convert.ToInt32(Console.ReadLine());
                        //kutu açma 
                        int c = oyun.kutu_acma(b - 1);
                        oyun.acılan_kutuları_sıfırlama(b - 1);
                        Console.Clear();
                        Console.WriteLine("                      __________                          ");
                        Console.WriteLine("                      |   {0}   |                         ", c);
                        Console.WriteLine("                      AÇILAN KUTU                         ");
                        Console.WriteLine("Enter tuşuna basınız.");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                    else if (i==1)
                    {
                    for (int k = 0; k < 7;k++)
                    {
                        int y = 7;
                        Console.WriteLine(" _________   _________   _________   _________   _________");
                        Console.WriteLine(" |   1   |   |   2   |   |   3   |   |   4   |   |   5   |");
                        Console.WriteLine(" _________   _________   _________   _________   _________");
                        Console.WriteLine(" |   6   |   |   7   |   |   8   |   |   9   |   |  10   |");
                        Console.WriteLine(" _________   _________   _________   _________   _________");
                        Console.WriteLine(" |  11   |   |  12   |   |  13   |   |  14   |   |  15   |");
                        Console.WriteLine(" _________   _________   _________   _________   _________");
                         Console.WriteLine(" |  16   |   |  17   |   |  18   |   |  19   |   |  20   |");
            Console.WriteLine(" _________   _________   _________   _________   ");
            Console.WriteLine(" |  21   |   |  22   |   |  23   |   |  24   |   ");
                        Console.WriteLine("");
                        Console.WriteLine("Daha önce açtığınız kutular:");
                        for (int g = 0; g < 24; g++)
                        {
                            
                            oyun.acılan_kutular(g);
                        }
                        Console.WriteLine("");
                        Console.WriteLine("              {0} Kutu açmamız gerekiyor.        ", y);
                        y--;
                        int b = Convert.ToInt32(Console.ReadLine());
                        //kutu açma 
                        int c = oyun.kutu_acma(b - 1);
                        oyun.acılan_kutuları_sıfırlama(b - 1);
                        Console.Clear();
                        Console.WriteLine("                      __________                          ");
                        Console.WriteLine("                      |   {0}   |                         ", c);
                        Console.WriteLine("                      AÇILAN KUTU                         ");
                        Console.WriteLine("Enter tuşuna basınız.");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    }
                 else if(i==2)
                    {
                    for (int k = 0; k < 6;k++)
                    {
                        int p = 6;
                        Console.WriteLine(" _________   _________   _________   _________   _________");
                        Console.WriteLine(" |   1   |   |   2   |   |   3   |   |   4   |   |   5   |");
                        Console.WriteLine(" _________   _________   _________   _________   _________");
                        Console.WriteLine(" |   6   |   |   7   |   |   8   |   |   9   |   |  10   |");
                        Console.WriteLine(" _________   _________   _________   _________   _________");
                        Console.WriteLine(" |  11   |   |  12   |   |  13   |   |  14   |   |  15   |");
                        Console.WriteLine(" _________   _________   _________   _________   _________");
                        Console.WriteLine(" |  16   |   |  17   |   |  18   |   |  19   |   |  20   |");
            Console.WriteLine(" _________   _________   _________   _________   ");
            Console.WriteLine(" |  21   |   |  22   |   |  23   |   |  24   |   ");
                        Console.WriteLine("");
                        Console.WriteLine("Daha önce açtığınız kutular:");
                        for (int g = 0; g < 24; g++)
                        {
                            
                            oyun.acılan_kutular(g);
                        }
                        Console.WriteLine("");
                        Console.WriteLine("              {0} Kutu açmamız gerekiyor        ", p);
                        p--;
                        int b = Convert.ToInt32(Console.ReadLine());
                        //kutu açma 
                        int c = oyun.kutu_acma(b - 1);
                        oyun.acılan_kutuları_sıfırlama(b - 1);
                        Console.Clear();
                        Console.WriteLine("                      __________                          ");
                        Console.WriteLine("                      |   {0}   |                         ", c);
                        Console.WriteLine("                      AÇILAN KUTU                         ");
                        Console.WriteLine("Enter tuşuna basınız.");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    }
                else if(i==3)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        int r = 3;
                        Console.WriteLine(" _________   _________   _________   _________   _________");
                        Console.WriteLine(" |   1   |   |   2   |   |   3   |   |   4   |   |   5   |");
                        Console.WriteLine(" _________   _________   _________   _________   _________");
                        Console.WriteLine(" |   6   |   |   7   |   |   8   |   |   9   |   |  10   |");
                        Console.WriteLine(" _________   _________   _________   _________   _________");
                        Console.WriteLine(" |  11   |   |  12   |   |  13   |   |  14   |   |  15   |");
                        Console.WriteLine(" _________   _________   _________   _________   _________");
                        Console.WriteLine(" |  16   |   |  17   |   |  18   |   |  19   |   |  20   |");
            Console.WriteLine(" _________   _________   _________   _________   ");
            Console.WriteLine(" |  21   |   |  22   |   |  23   |   |  24   |   ");
                        Console.WriteLine("");
                        Console.WriteLine("Daha önce açtığınız kutular:");
                        for (int g = 0; g < 248; g++)
                        {

                            oyun.acılan_kutular(g);
                        }
                        Console.WriteLine("");
                        Console.WriteLine("              {0} Kutu açmamız gerekiyor        ", r);
                        r--;
                        int b = Convert.ToInt32(Console.ReadLine());
                        //kutu açma 
                        int c = oyun.kutu_acma(b - 1);
                        oyun.acılan_kutuları_sıfırlama(b - 1);
                        Console.Clear();
                        Console.WriteLine("                      __________                          ");
                        Console.WriteLine("                      |   {0}   |                         ", c);
                        Console.WriteLine("                      AÇILAN KUTU                         ");
                        Console.WriteLine("Enter tuşuna basınız.");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                



                //teklif verme 
                Console.WriteLine("               HAMDİ BEY ARIYOR...");
                Console.WriteLine("             -HAMDİ BEY'İN TEKLİFİ-");
                int d = oyun.teklif_ver();
                Console.WriteLine("                   {0}         TL", d);
                Console.WriteLine("Hamdi Bey'in {0}'tl teklifine var mısın yok musun?", d);
                Console.WriteLine("(Varım:1  Yokum:-1)");
                string vy = Console.ReadLine();
                if (vy == "1")
                {
                    Console.WriteLine("Varım diyor!!! ve {0} tl kazanıyor.", d);
                    break;
                }
                else if (vy =="-1")
                { 
                    Console.WriteLine("Yokum diyor!!! Yarşmaya devam ediyor.");
                }
                Console.ReadLine();
                Console.Clear();
            }
            Console.WriteLine("Başka Seçim Hakkınız Kalmadı.");
            Console.WriteLine("Oyun Bitti.");
            Console.ReadLine();

        }
    }
}

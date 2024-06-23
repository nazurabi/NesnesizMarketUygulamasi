using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesnesizMarketUygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ürün Tanımlama

            string[] isimler = new string[8];
            double[] fiyatlar = new double[8];
            string[] birim = new string[8];
            int[] kdv = new int[8];
            isimler[0] = "Domates  "; fiyatlar[0] = 10; birim[0] = "Kg  "; kdv[0] = 1;
            isimler[1] = "Salatalık"; fiyatlar[1] = 8.5; birim[1] = "Kg  "; kdv[1] = 2;
            isimler[2] = "Biber    "; fiyatlar[2] = 15; birim[2] = "Kg  "; kdv[2] = 2;
            isimler[3] = "Patlıcan "; fiyatlar[3] = 20; birim[3] = "Kg  "; kdv[3] = 2;
            isimler[4] = "Karpuz   "; fiyatlar[4] = 25; birim[4] = "Kg  "; kdv[4] = 2;
            isimler[5] = "Ekmek    "; fiyatlar[5] = 7.5; birim[5] = "Adet"; kdv[5] = 4;
            isimler[6] = "Kola     "; fiyatlar[6] = 35.40; birim[6] = "Şişe"; kdv[6] = 8;
            isimler[7] = "Yumurta  "; fiyatlar[7] = 4; birim[7] = "Adet"; kdv[7] = 1;

            #endregion

            #region Ürün Listeleme

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("      Morpheus Markete Hoşgeldiniz");
            Console.WriteLine("*-*-*-*-*-*-*-*-* MENÜ *-*-*-*-*-*-*-*-*");
            Console.ResetColor();
            Console.WriteLine("No" + "   " + "İsim     " + "   " + "Fiyat" + "   " + "Dağt.Brm.");
            for (int i = 0; i < isimler.Length; i++)
            {
                Console.WriteLine((i + 1) + ".)  " + isimler[i] + "   " + fiyatlar[i] + "\t " + birim[i]);
            }
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");

            #endregion

            #region Ürün Satın Aldırma

            string[] fisisim = new string[0];
            double[] fisfiyat = new double[0];
            byte[] fismiktar = new byte[0];
            string[] fisbirim = new string[0];
            int[] fiskdv = new int[0];

            Console.Write("Kaç Adet Ürün Satın Almak İstiyorsunuz?= ");
            Console.ForegroundColor = ConsoleColor.Green;
            byte urunmiktari = Convert.ToByte(Console.ReadLine());
            Console.ResetColor();
            Console.Clear();


            for (int i = 0; i < urunmiktari; i++)
            {
                #region Alım İçinde Tekrar Menü Listeleme
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("      Morpheus Markete Hoşgeldiniz");
                Console.WriteLine("*-*-*-*-*-*-*-*-* MENÜ *-*-*-*-*-*-*-*-*");
                Console.ResetColor();
                Console.WriteLine("No" + "   " + "İsim     " + "   " + "Fiyat" + "   " + "Dağt.Brm.");
                for (int j = 0; j < isimler.Length; j++)
                {
                    Console.WriteLine((j + 1) + ".)  " + isimler[j] + "   " + fiyatlar[j] + "\t " + birim[j]);
                }
                Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");

                #endregion

                byte secim = 0;
                byte miktar = 0;
                while (true)
                {
                    Console.Write("Lütfen Almak İstediğiniz Ürünün Sıra Numarasını Giriniz= ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    secim = Convert.ToByte(Console.ReadLine());
                    Console.ResetColor();
                    if (secim >= 1 && secim <= 8)
                    {
                        Console.Write($"Kaç {birim[secim - 1]} {isimler[secim - 1]} almak istiyorsunuz?= ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        miktar = Convert.ToByte(Console.ReadLine());
                        Console.ResetColor();
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Hatalı Bir Giriş Yaptınız Lütfen Listedeki Ürünlerden Birini Seçiniz.");
                        Console.ResetColor();
                    }

                }
                Console.Clear();
                string[] gecicifisisim = new string[fisisim.Length + 1];
                double[] gecicifisfiyat = new double[fisfiyat.Length + 1];
                byte[] gecicifismiktar = new byte[fismiktar.Length + 1];
                string[] gecicifisbirim = new string[fisbirim.Length + 1];
                int[] gecicifiskdv = new int[fiskdv.Length + 1];

                Array.Copy(fisisim, gecicifisisim, fisisim.Length);
                Array.Copy(fisfiyat, gecicifisfiyat, fisfiyat.Length);
                Array.Copy(fismiktar, gecicifismiktar, fismiktar.Length);
                Array.Copy(fisbirim, gecicifisbirim, fisbirim.Length);
                Array.Copy(fiskdv, gecicifiskdv, fiskdv.Length);

                //for (int j = 0; j < fisisim.Length; j++)
                //{
                //    gecicifisisim[j] = fisisim[j];
                //    gecicifisfiyat[j] = fisfiyat[j];
                //    gecicifismiktar[j] = fismiktar[j];
                //    gecicifisbirim[j] = fisbirim[j];
                //    gecicifiskdv[j] = fiskdv[j];
                //}

                gecicifisisim[gecicifisisim.Length - 1] = isimler[secim - 1];
                gecicifisfiyat[gecicifisfiyat.Length - 1] = fiyatlar[secim - 1];
                gecicifismiktar[gecicifismiktar.Length - 1] = miktar;
                gecicifisbirim[gecicifisbirim.Length - 1] = birim[secim - 1];
                gecicifiskdv[gecicifiskdv.Length - 1] = kdv[secim - 1];

                fisisim = gecicifisisim;
                fisfiyat = gecicifisfiyat;
                fismiktar = gecicifismiktar;
                fisbirim = gecicifisbirim;
                fiskdv = gecicifiskdv;
            }

            #endregion

            #region Fiş

            double toplam = 0;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Morpheus Marketten Aldığınız Ürünler");
            Console.WriteLine("*-*-*-*-*-*-*-*-* MENÜ *-*-*-*-*-*-*-*-*");
            Console.ResetColor();

            for (int i = 0; i < fisisim.Length; i++)
            {
                double kdvlitoplam = (fisfiyat[i] * fismiktar[i]) + ((fisfiyat[i] * fismiktar[i] * fiskdv[i]) / 100);
                double aratoplam = fisfiyat[i] * fismiktar[i];
                Console.WriteLine((i + 1) + ".) " + fisisim[i] + " --- " + fismiktar[i] + " " + fisbirim[i] + " --- " + "Kdv % " + fiskdv[i] + " --- " + "Birim Fiyatı= " + fisfiyat[i] + " --- " + "Ara Toplam = " + aratoplam + " --- " + "Kdvli.Top = " + kdvlitoplam);
                toplam += kdvlitoplam;
            }
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
            Console.Write("Toplam= ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(toplam);
            Console.ResetColor();

            #endregion

        }
    }
}

using System;
using System.Collections;

namespace Koleksiyonlar_Soru2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] sayilar = new int[20];
            int girdi;
            Console.WriteLine("20 adet sayı giriniz:");
           for (int i = 0; i<20; i++)
           {
                while (true)
                {
                    Console.WriteLine($"Sayı {i+1}: ");
                    if(int.TryParse(Console.ReadLine(), out sayilar[i]))
                        break; //geçerli
                    else
                        Console.WriteLine("Lütfen sayı girin...");
                }
           }
            Array.Sort(sayilar);
            Console.WriteLine("En küçük 3 sayının Ortalama Toplamı: " + (sayilar[0]+sayilar[1]+sayilar[2]));
            Console.WriteLine("En küçük 3 sayının Ortalaması: " + (sayilar[0]+sayilar[1]+sayilar[2])/3.0);
            
            Console.WriteLine("En büyük 3 sayının Ortalama Toplamı: " + (sayilar[17]+sayilar[18]+sayilar[19]));
            Console.WriteLine("En büyük 3 sayının Ortalaması: " + (sayilar[17]+sayilar[18]+sayilar[19])/3.0);
            
            
            
        }

    }
}

using System;
using System.ComponentModel.DataAnnotations;

namespace dongu_for // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ekrandan girilen sayıya kadar olan tek sayılarını ekrana yazdır
            // Console.WriteLine("Bir sayı giriniz:");
            // int sayac= int.Parse(Console.ReadLine());
            // for(int i=1; i<=sayac; i++)
            // {
            //     if(i%2==1)
            //     Console.WriteLine(i);

            // }

            // //1 ile 1000 arasındaki tek ve çift sayıların toplamı
            // int tekToplam=0;
            // int ciftToplam=0;

            // for (int i = 1; i <= 1000; i++)
            // {
            //     if (i%2 == 1)
            //         tekToplam += i;
            //     else
            //         ciftToplam += i;
            // }

            // Console.WriteLine("Tek Toplam: "+ tekToplam);
            // Console.WriteLine("Çift Toplam: "+ ciftToplam);

            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                    break;
                Console.WriteLine(i);

            }
            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                    continue;
                Console.WriteLine(i);
                
            }
        }
    }
}
using System;

namespace while_foreach // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            //while
            // Birden başlayarak console dan girilen sayıya kadar (sayı dahil) ortalama hesaplıyıp console a yazdıran program.
            // Console.WriteLine("Lütfen bir sayı giriniz:");
            // int sayi = int.Parse(Console.ReadLine());
            // int sayac = 1;
            // int toplam = 0;
            // while (sayac <= sayi)
            // {
            //     toplam += sayac;
            //     sayac ++;
            // }
            // Console.WriteLine(toplam/sayi);

            // 'a' dan 'z' ye kadar tüm harfleri console a yazdır
            // char character = 'a';
            // while (character < 'z')
            // {
            //     Console.WriteLine(character);
            //     character ++;

            // }
            Console.WriteLine("****** For Each *******");
            string[] arabalar = { "BMV", "Ford", "Toyota", "Nissan"};

            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
}
    }
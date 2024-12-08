using System;

namespace diziler // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            //dizi tanımlama
            string[] renkler = new string[5];

            string[] hayvanlar = { "Kedi", "Köpek", "Kuş", "Maymun"};

            int[] dizi;
            dizi= new int [5];

            //Dizilere değer atama ve Erişim
            renkler[0]="Mavi";

            dizi[3]=10;

            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            //Döngüler ile dizi
            //Klavyeden girilen n tane sayının ortalaması

            Console.WriteLine("Lütfen dizinin eleman sayısını girin:");
            int diziLenght= int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[diziLenght];

            for (int i = 0; i < diziLenght; i++)
            {
                Console.WriteLine($"Lütfen {(i + 1)}. sayısını giriniz:");
                sayiDizisi[i] =int.Parse(Console.ReadLine());
            }
            
            int toplam =0;
            foreach (var sayi in sayiDizisi)
            {
                toplam += sayi;
            }
            Console.WriteLine("Ortalama: " + toplam/diziLenght);
            
        }
    }
}
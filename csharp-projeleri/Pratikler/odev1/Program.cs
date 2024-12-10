using System;

namespace odev1 // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {

// 1) Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.


        //     Console.WriteLine("Pozitif bir sayı giriniz (n): ");
        //     int n = Convert.ToInt32(Console.ReadLine());

        //     int[] sayilar =new int[n];

        //     for (int i = 0; i< n ; i++)
        //     {
        //         int sayi;
        //         do
        //         {
        //             Console.WriteLine($"Lütfen {i+1}. pozitif sayıyı girin: ");
        //         sayi =Convert.ToInt32(Console.ReadLine());
        //             if(sayi<=0)
        //                 Console.WriteLine("Lütfen pozitif sayı girin.");
        //         } while(sayi<=0);
        //         sayilar[i]=sayi;
                
        //     }

        //     Console.WriteLine("Girdiğiniz çift sayılar:");
        //     foreach (int sayi in sayilar)
        //     {
        //         if(sayi%2==0)
        //             Console.WriteLine(sayi);
        //     }
//----------------------------------------------------------------------------------------------------------------------------------

// 2) Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

            // Console.WriteLine("Bir sayı giriniz: (m) ");
            // int m = Convert.ToInt32(Console.ReadLine());

            // Console.WriteLine("kaç adet pozitif bir sayı gireceksiniz (n): ");
            // int n = Convert.ToInt32(Console.ReadLine());
            
            // int[] sayilar =new int[n];
            // for (int i = 0; i < n ; i++)
            // {
            //     int sayi;
            //     do
            //     {
            //         Console.WriteLine($"Lütfen {i+1}. pozitif sayıyı girin: ");
            //         sayi =Convert.ToInt32(Console.ReadLine());
            //         if(sayi<=0)
            //             Console.WriteLine("Lütfen pozitif sayı girin.");
            //     } while(sayi<=0);
            //     sayilar[i]=sayi;
            // }
            // Console.WriteLine($"{m} sayısına eşit olanlar ve tam bölünenler ");
            // bool found=false;
            // foreach (int sayi in sayilar)
            // {
            //     if(sayi==m || sayi%m==0)
            //     {
            //         Console.WriteLine(sayi);
            //         found=true;
            //     }
                
            // }
            // if (!found)
            // {
            //     Console.WriteLine("Eşit veya tam bölünen sayı yok.");
            // }

//-------------------------------------------------------------------------------------------------------------------------------------------
// 3) Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
            // Console.WriteLine("Bir pozitif sayı giriniz: (n) ");
            // int n = Convert.ToInt32(Console.ReadLine());

            
            // string[] kelimeler =new string[n];
            // for (int i = 0; i < n ; i++)
            // {
            //     string kelime="";
            //     do
            //     {
            //         Console.WriteLine($"Lütfen {i+1}. kelimeyi girin: ");
            //         kelime =Convert.ToString(Console.ReadLine());
            //         if(kelime ==" " || kelime == null)
            //             Console.WriteLine("Lütfen kelime girin.");
            //     } while(kelime==" ");
            //     kelimeler[i] = kelime;
            // }
            // Console.WriteLine($"Girdiğiniz {n} kelime şunlardı...");
            // foreach (string item in kelimeler)
            // {
            //     Console.Write(item + " ");
            // }
//----------------------------------------------------------------------------------------------------------------------------------------

//Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

            Console.WriteLine("Bir cümle yazınız... ");
            string cumle = Convert.ToString(Console.ReadLine());
            
            Console.WriteLine("Cümlenizdeki Harf sayısı "+ cumle.Length);

            string[] kelimeler = cumle.Split(" ");

            int kelimeAdet=0;
            foreach (string kelime in kelimeler)
            {
                    kelimeAdet++;
            }
            Console.WriteLine("Kelime sayınız: " + kelimeAdet);

        }
    }
}
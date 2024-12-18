using System;
using System.Collections.Generic;


namespace enum_yapisi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)Gunler.Cumartesi);
                
            int sıcaklık =32;
            if(sıcaklık<=(int)HavaDurumu.Normal)
                Console.WriteLine("Dışarı çıkmak için soğuk");
            else if(sıcaklık>=(int)HavaDurumu.Sıcak)
                Console.WriteLine("Dışarıya çıkmak için çok sıcak");
            else if(sıcaklık>=(int)HavaDurumu.Normal && sıcaklık<(int)HavaDurumu.ÇokSıcak)
                Console.WriteLine("Hadii dışarıya çıkalım");
        }


        enum Gunler
        {
            Pazartesi,
            Salı,
            Çarşamba,
            Perşembe,
            Cuma,
            Cumartesi,
            Pazar
        }
        enum HavaDurumu
        {
            Soguk=5,
            Normal=15,
            Sıcak=25,
            ÇokSıcak=30
        }
        
    }
}

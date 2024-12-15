using System;
using System.Collections.Generic;

namespace Koleksiyonlar_Soru3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string cumle;
            
            Console.WriteLine("Bir cümle giriniz...");
            do
            {
                cumle =Console.ReadLine();
                if(string.IsNullOrWhiteSpace(cumle))
                    Console.WriteLine("Lütfen geçerli bir cümle girin.");
                
            }while(string.IsNullOrWhiteSpace(cumle));
            char[] sesliHarfler=new char []{'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü'};
            char[] harfler=cumle.ToCharArray();
            List<char> cumleSesli =new List<char>();

            foreach (char harf in cumle)
            {
                // Sesli harfleri kontrol et
                foreach (char sesli in sesliHarfler)
                {
                    if (harf == sesli)
                    {
                        cumleSesli.Add(harf);
                        break; // Sesli harf bulundu, iç döngüden çık
                    }
                }
            }
            cumleSesli.Sort();
            Console.WriteLine("Cümledeki sesli harfler (sıralı): ");
            foreach (char sesliHarf in cumleSesli)
            {
                Console.Write(sesliHarf + " ,");
            }
            




        }
    }
}

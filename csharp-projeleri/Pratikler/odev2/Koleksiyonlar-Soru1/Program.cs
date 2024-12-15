using System;
using System.Collections;

namespace Koleksiyonlar_Soru1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> primes = new List<int>();
            List<int> nonPrimes = new List<int>();
            Console.WriteLine("20 adet sayı giriniz:");
            
            for (int i = 0; i<20 ; i++)
            {
                int girdi;
                while(true)
                {
                    Console.WriteLine($"Sayı {i+1}: ");
                    if(int.TryParse(Console.ReadLine(), out girdi) && girdi >= 0)
                        break; //geçerli
                    else
                        Console.WriteLine("Lütfen pozitif bir sayı girin...");
                }
                
                if (IsPrime(girdi))
                {
                    primes.Add(girdi);
                }
                else
                    nonPrimes.Add(girdi);
            }
                primes.Sort();
                primes.Reverse();
                nonPrimes.Sort();
                nonPrimes.Reverse();

                int toplamPrime=0;
                int toplamnonPrime=0;
                Console.WriteLine("Asal Sayılar:");
                foreach(int prime in primes)
                {
                    Console.WriteLine(prime);
                    toplamPrime+=prime;
                }

                Console.WriteLine("Asal Olmayan Sayılar:");
                foreach(int nonprime in nonPrimes)
                {
                    Console.WriteLine(nonprime);
                    toplamnonPrime+=nonprime;
                }
                double ortalama =(toplamPrime+toplamnonPrime)/20.0;
                Console.WriteLine($"\nOrtalama: {ortalama}");
            
        }
        public static bool IsPrime(int number)
        {
            if(number <=1) return false;
            for(int i = 2; i<=Math.Sqrt(number);i++)
            {
                if(number% i==0) return false;
            }
            return true; //ASal
        }

       
    }
}

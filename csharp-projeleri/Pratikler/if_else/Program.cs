using System;

namespace if_else // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;
            Console.WriteLine("Saat " + time);

            if (time>=6 && time <11)
                Console.WriteLine("Günaydın!");
            else if (time>11 && time <= 18)
                Console.WriteLine("İyi Günler");
            else
                Console.WriteLine("İyi Geceler");


                string sonuc =time<=18 ? "İyi Günler" : "İyi Geceler";

                sonuc = time>=6 && time<11 ? "Günaydın" : time>=11 && time<=18 ? "İyi Günler!" : "İyi GEceler";
                Console.WriteLine(sonuc);
        
        }
    }
}
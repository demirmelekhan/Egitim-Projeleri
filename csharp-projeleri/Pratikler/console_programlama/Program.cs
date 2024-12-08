using System;

    namespace console_programlama
    {
        class Program
        {
            public static void Main(string[] args)
            {
                Console.WriteLine("Merhaba Dunya!");
                Console.WriteLine("İsminizi girin:");
                string? name = Console.ReadLine();
                Console.WriteLine("Soyadınızı Girin:");
                string? surname = Console.ReadLine();

                Console.WriteLine("Merhaba " + name + " " + surname);

            }
        }
    }

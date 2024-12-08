using System;

namespace dizi_array // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sort
            int[] sayiDizisi = { 1, 2, 3, 25, 87, 72, 11, 17};

            Console.WriteLine("Sırasız Dizi");
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);
            
            Console.WriteLine("sıralı dizi");
            Array.Sort(sayiDizisi);

            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);


            //Clear
            Console.WriteLine("Array clear");
            Array.Clear(sayiDizisi,2,2);

            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            //REverse
            Console.WriteLine("Array Reverse");
            Array.Reverse(sayiDizisi);
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            //IndexOF
            Console.WriteLine("Index of");
            Console.WriteLine(Array.IndexOf(sayiDizisi, 17));


            //REsize
            Console.WriteLine("ReSize");

            Array.Resize<int>(ref sayiDizisi,9);
            sayiDizisi[8] =45;

            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

        }
    }
}
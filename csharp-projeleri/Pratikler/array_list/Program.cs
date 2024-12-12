using System;
using System.Collections;

namespace array_list
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Collections namespace

            ArrayList liste =new ArrayList();
/*             liste.Add("Melek");
            liste.Add(31);
            liste.Add(true);
            liste.Add('D'); */

            // Console.WriteLine(liste[1]);

            // foreach (var item in liste)
            // {
            //     Console.WriteLine(item);

            // }
            Console.WriteLine("--------------Add Range------------");
            
            // string[] renkler = { "turuncu", "mavi", "mor",};
            List<int> sayilar = new List<int>{5,6,9,74,31,65};
            // liste.AddRange(renkler);
            liste.AddRange(sayilar);

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------Sort------------");
                        
            liste.Sort();
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            //Binary search
            Console.WriteLine("-------------------Binary Search---------------");
            Console.WriteLine(liste.BinarySearch(31));

            //REVERSE
            Console.WriteLine("------------Reverse-----------");
            liste.Reverse();
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            //Clear
            liste.Clear();
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }
        }
    }
}
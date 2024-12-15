using System;
using System.Collections;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> kullanicilar =new Dictionary<int,string>();

                kullanicilar.Add(31,"Melek Demirhan");
                kullanicilar.Add(26,"Sarocha Chankimha");
                kullanicilar.Add(22,"Rebecca Patricia Armstrong");
                kullanicilar.Add(30,"Faye Malisorn");
                //Aynı elemanı girerken editör hata vermiyor ama build ederken sorun yaşayacağız.
                //kullanicilar.Add(30,"Faye Malisorn");

                Console.WriteLine("-----------Elemanlara erişim ------------");
                Console.WriteLine(kullanicilar[26]);

                foreach (var item in kullanicilar)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine(kullanicilar.Count);
            //Contains: Girilen değerlerde eleman varmı diye soruyoruz demek oluyor

            Console.WriteLine(kullanicilar.ContainsKey(30));
                Console.WriteLine(kullanicilar.ContainsValue("Peraya Faye Malisorn"));

                Console.WriteLine("-------Keyss---------");
                foreach (var item in kullanicilar.Keys)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("-------Valuess---------");
                foreach (var item in kullanicilar.Values)
                {
                    Console.WriteLine(item);
                }
        }
    }
}
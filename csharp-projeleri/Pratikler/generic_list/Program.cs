using System;

namespace generic_list // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<T> class
            //System.Collections.Generic
            //T->object türündedir

            List<int> sayiListesi = new List<int>();

            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);
            
            List<string> renkListesi = new List<string>();
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");

            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);

            foreach (var sayi in sayiListesi)
            {
                Console.WriteLine(sayi);
            }
            
            foreach (var renk in renkListesi)
            {
                Console.WriteLine(renk);
            }


            sayiListesi.Remove(4);
            renkListesi.Remove("Yeşil");

            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk=> Console.WriteLine(renk));

            //Liste içinde arama
            if (sayiListesi.Contains(10))
                Console.WriteLine("10 liste içerisinde bulundu");

            //Eleman ile index'e erişim
            Console.WriteLine(renkListesi.BinarySearch("Turuncu"));

            //Diziyi liste'e çevirme
            string[] hayvanlar = {"Kedi","Köpek","Zürafa","Fil","Kaplan"};
            List<string> hayvanListesi =new List<string>(hayvanlar);

            //Liste nasıl temizleriz
            hayvanListesi.Clear();

            //List içerisinde nesne tutma
            List<Kullanicilar> kulListesi =new List<Kullanicilar>();
            Kullanicilar kul1 =new Kullanicilar();
            
            kul1.Isim="Ayşe";
            kul1.Soyisim="Yılmaz";
            kul1.Yas=26;
            kulListesi.Add(kul1);

            Kullanicilar kul2 =new Kullanicilar();
            kul2.Isim="Melek";
            kul2.Soyisim="Demirhan";
            kul2.Yas=31;
            kulListesi.Add(kul2);

            List<Kullanicilar> yeniListe =new List<Kullanicilar>();
            yeniListe.Add(new Kullanicilar(){
                Isim="Gizem Melike",
                Soyisim="Demirhan",
                Yas=24,
            });

            foreach (Kullanicilar kull in kulListesi)
            {
                Console.WriteLine("Kullanıcı Adı:" + kull.Isim);
                Console.WriteLine("Kullanıcı Soyadı:" + kull.Soyisim);
                Console.WriteLine("Kullanıcı Yaşı:" + kull.Yas);
            }
            yeniListe.Clear();


        }
        
    }
    public class Kullanicilar
    {
        private string isim =string.Empty;

        private string soyisim =string.Empty;

        private int yas;

        public string Isim {get => isim; set => isim = value;}

        public string Soyisim {get => soyisim; set => soyisim = value;}

        public int Yas {get => yas; set => yas = value;}
    }
}
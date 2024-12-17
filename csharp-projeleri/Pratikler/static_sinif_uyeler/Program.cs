using System;
using System.Collections.Generic;


namespace static_sinif_uyeler
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Çalışan SAyısı: {0}", Calisan.CalisanSayisi);
            Calisan calisan=new Calisan("Melek","Demirhan","Yazılım Geliştirme");
            Calisan calisan1= new Calisan("Minel","Kümler","Sosyal Medya");
            Calisan calisan2=new Calisan("Çağdaş","Albay","Görüntü İşleme");

            Console.WriteLine("Çalışan Sayısı: {0}", Calisan.CalisanSayisi);

            Console.WriteLine("Toplama işlemi osnucu {0}",Islemler.Topla(100,200));
            Console.WriteLine("Çıkarma işlemi osnucu {0}",Islemler.Cikar(400,50));
        }

        class Calisan
        {
            private static int calisanSayisi;

            public static int CalisanSayisi { get => calisanSayisi; set => calisanSayisi = value; }

            private string Ad;
            private string Soyad;
            private string Departman;
            static Calisan(){
                calisanSayisi=0;

            }
            public Calisan(string ad, string soyad, string departman)
            {
                Ad = ad;
                Soyad = soyad;
                Departman = departman;
                calisanSayisi ++;
            }
        
        }
        static class Islemler
        {
            public static long Topla (int sayi1 ,int sayi2)
            {
                return sayi1+sayi2;
            }
            public static long Cikar (int sayi1 ,int sayi2)
            {
                return sayi1-sayi2;
            }
        }
        
    }
}

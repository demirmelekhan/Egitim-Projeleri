using System;
using System.Collections.Generic;

namespace sinif_kavrami
{
    public class Program
    {
        static void Main(string[] args)
        {
           Calisan calisan1=new Calisan();
           calisan1.Ad="Melek";
           calisan1.Soyad="Demirhan";
           calisan1.No=0001;
           calisan1.Departman="Yazılım Geliştirme";

            calisan1.CalisanBilgileri();

            Calisan calisan2=new Calisan();
           calisan2.Ad="Minel";
           calisan2.Soyad="Kümeler";
           calisan2.No=0002;
           calisan2.Departman="Sosyal Medya";

           calisan2.CalisanBilgileri();
        }   
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışanın Adı: {0}", Ad);
            Console.WriteLine("Çalışanın Soyadı: {0}", Soyad);
            Console.WriteLine("Çalışanın Numarası: {0}", No);
            Console.WriteLine("Çalışanın Departmanı: {0}", Departman);
        }

    }

}

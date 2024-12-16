using System;

namespace kurucu_metotlar // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            Calisan calisan1=new Calisan("Melek","Demirhan",31,"Yazılım Geliştirme");
            calisan1.CalisanBilgileri();

            Calisan calisan2=new Calisan("Minel","Kümeler", 32 ,"Sosyal Medya");
            calisan2.CalisanBilgileri();

            Calisan calisan3 = new Calisan("Burak","Yeter");
            calisan3.CalisanBilgileri();
        }
    }
    
    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public Calisan(string ad, string soyad, int no, string departman)
        {
            this.Ad=ad;
            this.Soyad=soyad;
            this.No=no;
            this.Departman=departman;
        }
        public Calisan(string ad, string soyad)
        {
            this.Ad=ad;
            this.Soyad=soyad;
        }

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışanın Adı: {0}", Ad);
            Console.WriteLine("Çalışanın Soyadı: {0}", Soyad);
            Console.WriteLine("Çalışanın Numarası: {0}", No);
            Console.WriteLine("Çalışanın Departmanı: {0}", Departman);
        }
    }
    
    
}
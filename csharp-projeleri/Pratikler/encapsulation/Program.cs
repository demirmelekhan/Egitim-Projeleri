using System;
using System.Collections.Generic;

namespace encapsulation
{
    class Program
    {
        public static void Main(string[] args)
        {
            Ogrenci ogrenci= new Ogrenci();
            ogrenci.Isim="Melek";
            ogrenci.Soyisim="Demirhan";
            ogrenci.OgrenciNo=10631;
            ogrenci.Sinif=3;

            ogrenci.OgrenciBilgileriniGetir();

            ogrenci.SinifAtlat();
            ogrenci.OgrenciBilgileriniGetir();

            Ogrenci ogrenci1 = new Ogrenci("Minel","Kümeler",32,1);
            ogrenci1.SinifDusur();
            ogrenci1.SinifDusur();
            ogrenci1.OgrenciBilgileriniGetir(); 
        }

    }
    class Ogrenci
    {
        private string _isim;
        private string _soyisim;
        private int _ogrenciNo;
        private int _sinif;

        public string Isim 
        { 
            get => _isim;  //get{return _isim;}
            set => _isim = value; //set {_isim = value; }
        }
        public string Soyisim { get => _soyisim; set => _soyisim = value; }
        public int OgrenciNo { get => _ogrenciNo; set => _ogrenciNo = value; }
        public int Sinif 
        { 
            get => _sinif; 
            set
            {
                if(value<1)
                {
                    Console.WriteLine("Sınıf en az 1 olabilir.");
                    Sinif=1;
                }
                else
                    _sinif = value;
            }  
            
        }

        public Ogrenci(string isim, string soyisim, int ogrenciNo, int sinif)
        {
            Isim = isim;
            Soyisim = soyisim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }
        public Ogrenci(){}

        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("Öğrenci Bilgileri");
            Console.WriteLine("Öğrenci Adı :{0}",this.Isim);
            Console.WriteLine("Öğrenci Soyadı :{0}",this.Soyisim);
            Console.WriteLine("Öğrenci Ogrenci No :{0}",this.OgrenciNo);
            Console.WriteLine("Öğrenci Sınıfı :{0}",this.Sinif);
        }

        public void SinifAtlat()
        {
            this.Sinif =this.Sinif +1;
        }
        public void SinifDusur()
        {
            this.Sinif=this.Sinif-1;
        }

    }

}

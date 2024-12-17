using System;
using System.Collections.Generic;


namespace struct_kavrami
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dikdortgen dikdortgen= new Dikdortgen();
            dikdortgen.KisaKenar=3;
            dikdortgen.UzunKenar=4;
            Console.WriteLine("Class alan hesabı: {0}",dikdortgen.AlanHesapla());
            
            Dikdortgen_Struct dikdortge_struct= new Dikdortgen_Struct();
            dikdortgen.KisaKenar=3;
            dikdortgen.UzunKenar=4;
            Console.WriteLine("Struct alan hesabı: {0}",dikdortge_struct.AlanHesapla());
        }

        class Dikdortgen
        {
            public int KisaKenar;
            public int UzunKenar;
            public long AlanHesapla()
            {
                return this.KisaKenar*this.UzunKenar;
            }
        }
        struct Dikdortgen_Struct
        {
            public int KisaKenar;
            public int UzunKenar;
            public long AlanHesapla()
            {
                return this.KisaKenar*this.UzunKenar;
            }
        }


        
    }
}

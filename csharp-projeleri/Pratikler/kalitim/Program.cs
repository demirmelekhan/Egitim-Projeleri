using System;
using System.Collections.Generic;


namespace kalitim
{
    class Program
    {
        public static void Main(string[] args)
        {
            TohumluBitkiler tohumluBitki =new TohumluBitkiler();
            
            tohumluBitki.TohumlaCogalma();

            Kuslar martı=new Kuslar();
            martı.UcarakHareketEder();
        }

    }
}

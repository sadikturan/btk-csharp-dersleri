using System;
using System.Collections.Generic;

namespace ConsoleApp {

    class Program {

        static void Main(string[] args) 
        {
            // Exception
            // System.FormatException
            // System.DivideByZeroException
            // System.NullReferenceException

            Console.Write("1. sayı: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("2. sayı: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            var sonuc = sayi1 / sayi2;

            Urun urun = null;
            Console.WriteLine(urun.UrunAdi);
            
            // Exception Handling
        }
    }

    class Urun
    {
        public string UrunAdi { get; set; }
    } 
    
}


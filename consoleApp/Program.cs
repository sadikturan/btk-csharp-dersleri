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

            try {
                Console.Write("1. sayı: ");
                int sayi1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("2. sayı: ");
                int sayi2 = Convert.ToInt32(Console.ReadLine()); // TryParse

                var sonuc = sayi1 / sayi2;

                Console.WriteLine(sonuc);
            }
            catch(FormatException) {
                Console.WriteLine("sayısal bilgileri düzgün giriniz");
            }
            catch(DivideByZeroException) {
                Console.WriteLine("sayı 2 sıfır olmamalıdır.");
            }
            catch(Exception ex)
            {
                Console.WriteLine("bir hata oluştu");
                Console.WriteLine(ex.Message);
            }
            // Exception Handling
        }
    }
    
}


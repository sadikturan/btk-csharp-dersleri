using System;

namespace ConsoleApp {

    class Program {

        static void Main(string[] args) {

            Ogrenci ogr1 = new Ogrenci() { OgrenciNo = "100", AdSoyad = "Ada Bilgi", Sube = "6/A" };
            Ogrenci ogr2 = new Ogrenci() { OgrenciNo = "200", AdSoyad = "Yiğit Bilgi", Sube = "7/A" };
            Ogrenci ogr3 = new Ogrenci() { OgrenciNo = "300", AdSoyad = "Çınar Turan", Sube = "1/A" };
            Ogrenci ogr4 = new Ogrenci() { OgrenciNo = "400", AdSoyad = "Ahmet Turan", Sube = "1/A" };

            Ogrenci[] ogrenciler = new Ogrenci[4] { ogr1, ogr2, ogr3, ogr4 };

            foreach(var ogrenci in ogrenciler) {
                Console.WriteLine(ogrenci.BilgileriYazdir());
            }
        }
    }

    class Ogrenci {
        // property 
        public string OgrenciNo { get; set; }
        public string AdSoyad { get; set; }
        public string Sube { get; set; }

        // methods
        public string BilgileriYazdir() 
        {
            return $"{this.OgrenciNo} numaralı öğrencinin adı {this.AdSoyad} ve şubesi {this.Sube}";
        }
    }

}


using System;

namespace ConsoleApp {

    class Program {

        static void Main(string[] args) {

            // class => object (ogr1, ogr2)
            Ogrenci ogr1 = new Ogrenci();
            ogr1.OgrenciNo = "100";
            ogr1.AdSoyad = "Ada Bilgi";
            ogr1.Sube = "6/A";

            Ogrenci ogr2 = new Ogrenci();
            ogr2.OgrenciNo = "200";
            ogr2.AdSoyad = "Yiğit Bilgi";
            ogr2.Sube = "7/A";

            Ogrenci ogr3 = new Ogrenci();
            ogr3.OgrenciNo = "300";
            ogr3.AdSoyad = "Çınar Turan";
            ogr3.Sube = "1/A";

            Ogrenci[] ogrenciler = new Ogrenci[3];

            ogrenciler[0] = ogr1;
            ogrenciler[1] = ogr2;
            ogrenciler[2] = ogr3;

            foreach(var ogrenci in ogrenciler) {
                Console.WriteLine($"{ogrenci.OgrenciNo} numaralı öğrencinin adı {ogrenci.AdSoyad} ve şubesi {ogrenci.Sube}");
            }
        }
    }

    class Ogrenci {
        // property 
        public string OgrenciNo { get; set; }
        public string AdSoyad { get; set; }
        public string Sube { get; set; }
    }

}

// ConsoleApp => Program, Ogrenci
// System => Console
// System.IO => File, Directory, Path

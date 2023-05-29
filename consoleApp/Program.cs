using System;

namespace ConsoleApp {

    class Program {

        static void Main(string[] args) 
        {
            var soru1 = new Soru() { 
                SoruMetni = "Hangisi programlama dili değildir?",
                Secenekler = new string[4] { "Python", "C#", "Java", "Html" },
                Cevap = "Html" 
            };

            var soru2 = new Soru() { 
                SoruMetni = "Hangisi en popüler programlama dilidir ?",
                Secenekler = new string[4] { "Python", "C#", "Java", "Html" },
                Cevap = "C#" 
            };

            var soru3 = new Soru() { 
                SoruMetni = "Hangisi web programlama platformu değildir ?",
                Secenekler = new string[4] { "Django", "Asp.net", "Spring", "Python" },
                Cevap = "Python" 
            };

            var sorular = new Soru[] { soru1, soru2, soru3 };

            foreach (var soru in sorular)
            {
                Console.WriteLine(soru.SoruMetni);
                foreach(var secenek in soru.Secenekler) {
                    Console.WriteLine(secenek);
                }

                // kullanıcıdan cevap alalım.
                Console.Write("cevabınız: ");
                var cevap =  Console.ReadLine();

                if(soru.cevapKontrol(cevap)) {
                    Console.WriteLine("doğru");
                } else {
                    Console.WriteLine("yanlış");
                }
            }
        }
    }

    class Soru {
        // properties
        public string SoruMetni { get; set; }
        public string[] Secenekler { get; set; }
        public string Cevap { get; set; }
        
        // methods
        public bool cevapKontrol(string cevap) 
        {
            return this.Cevap.ToLower() == cevap.ToLower();
        }
    }

}


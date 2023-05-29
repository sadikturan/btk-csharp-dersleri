using System;

namespace ConsoleApp {

    class Program {

        static void Main(string[] args) 
        {
            var soru1 = new Soru(1, "Hangisi programlama dili değildir?", new string[4] { "Python", "C#", "Java", "Html" }, "Html");
            var soru2 = new Soru(2, "Hangisi en popüler programlama dilidir?", new string[4] { "Python", "C#", "Java", "Html" }, "C#");
            var soru3 = new Soru(3, "Hangisi web programlama platformu değildir ?", new string[4] { "Django", "Asp.net", "Spring", "Python" }, "Python");

        }
    }

    class Soru {
        public Soru(int soruId, string soruMetni, string[] secenekler, string cevap)
        {
            this.SoruId = soruId;
            this.SoruMetni = soruMetni;
            this.Secenekler = secenekler;
            this.Cevap = cevap;
        }
        public int SoruId { get; set; }
        public string SoruMetni { get; set; }
        public string[] Secenekler { get; set; }
        public string Cevap { get; set; }
        
        public bool cevapKontrol(string cevap) 
        {
            return this.Cevap.ToLower() == cevap.ToLower();
        }
    }

}


/*
    String Uygulamaları
*/

string kursAdi = ".NET 7 ile C# Programlama Dili";

// 1- Kaç karaktere sahiptir ?
// 2- Hepsini küçük harf yapınız.
// 3- '.' ile mi başlamaktadır?
// 4- C# bilgisi hangi konumda bulunmaktadır?
// 5- String 'C#' bilgisini içeriyor mu?
// 6- 'Dili' kelimesi yerine 'Dersleri' yazınız. (replace)
 
 var karakterSayisi = kursAdi.Length;
 Console.WriteLine(karakterSayisi); // 30

 var kucukHarf = kursAdi.ToLower();
 Console.WriteLine(kucukHarf);

 var nokta = kursAdi.StartsWith('.');
 Console.WriteLine("string . ile başlıyor: " + nokta);

 var konum = kursAdi.IndexOf("C#");
 Console.WriteLine("konum " + konum);

 var iceriyormu = kursAdi.Contains("C#");
 Console.WriteLine("C# içeriyor mu: " + iceriyormu);

 var guncellenenString = kursAdi.Replace("Dili","Dersleri");
Console.WriteLine(guncellenenString);
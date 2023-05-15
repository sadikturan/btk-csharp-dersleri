// Karşılaştırma Operatör Uygulamaları

// Klavyeden girilen yaş bilgisine göre oy kullanabilme durumunu inceleyiniz.

// Console.Write("yaşınız: ");
// var yas = Convert.ToInt32(Console.ReadLine());
// var sonuc = (yas >= 18) ? "ehliyet alabilirsiniz.":"ehliyet için yaşınız tutmuyor.";
// Console.WriteLine(sonuc);


// Girilen bir sayının işaretini kontrol ediniz.

// Console.Write("sayı: ");
// var sayi = Convert.ToInt32(Console.ReadLine());
// var sonuc = (sayi > 0) ? "sayı pozitif":"sayı negatif";
// Console.WriteLine(sonuc);

// Girilen bir sayının tek/çift durumunu kontrol ediniz.

Console.Write("sayı: ");
var sayi = Convert.ToInt32(Console.ReadLine());
var sonuc = (sayi % 2 == 1) ? "sayı tek": "sayı çift";
Console.WriteLine(sonuc);

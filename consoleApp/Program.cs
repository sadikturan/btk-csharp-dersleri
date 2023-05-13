// Aritmetik Operatör Uygulamaları

// a = 10, b = 5, c = 20 ise c - a farkının b katı kaçtır?

// int? a = 50; int b = 20; ise a + b değerini hesaplayınız. (eğer a null ise sonuç nedir?)

// a=10 b=20 ise a=b--; atamasından sonra a ve b değerleri ne olur?

// Klavyeden girilen bir sayının tek / çift kontrolünü yapınız.

// int a = 10;
// int b = 5;
// int c = 20;
// var sonuc = (c - a) * b;

// int? a = null;
// int b = 20;

// var sonuc = (a ?? 0) + b;
// Console.WriteLine(sonuc);

// int a = 10;
// int b = 20;
// a = b--;

// Console.WriteLine(a);
// Console.WriteLine(b);

Console.Write("sayı: ");
int sayi = int.Parse(Console.ReadLine() ?? "0");
var sonuc = sayi % 2;

Console.WriteLine(sonuc); // 1 ise satı tek, 0 ise sayı çift

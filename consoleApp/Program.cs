// if/else Uygulamaları

// 1- Kullanıcıya sunulan bir menü içinden seçilecek olan 4 işlem tipine göre hesaplama yapınız.

// Console.Write("1.sayı: ");
// var sayi1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("2.sayı: ");
// var sayi2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Toplama için: +");
// Console.WriteLine("Çıkarma için: -");
// Console.WriteLine("Çarpma için:  *");
// Console.WriteLine("Bölme için:   /");

// Console.Write("Seçiminiz: ");
// var secim = Console.ReadLine();

// double sonuc = 0;
// bool ok = true;

// if(secim == "+") {
//     sonuc = sayi1 + sayi2;
// } else if(secim == "-") {
//     sonuc = sayi1 - sayi2;
// } else if(secim == "*") {
//     sonuc = sayi1 * sayi2;
// } else if(secim == "/") {
    
//     if(sayi2 == 0) {
//         ok = false;
//         Console.WriteLine("bölen 0 olamaz.");
//     } else {
//         sonuc = sayi1 / sayi2;
//     }

// } else {
//     ok = false;
//     Console.WriteLine("yanlış seçim");
// }
// if(ok) {
//  Console.WriteLine($"işlem sonucu: {sayi1} {secim} {sayi2} = {sonuc}");
// }

// 2- Bir öğrencinin 2 yazılı 1 sözlü notunu alıp hesaplanan ortalamaya göre not aralığına karşılık gelen not bilgisini yazınız.

    // 0  -  24  => 0
    // 25 -  44  => 1
    // 45 -  54  => 2
    // 55 -  69  => 3
    // 70 -  84  => 4
    // 85 -  100 => 5

// Console.Write("1.yazılı: ");
// int not1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("2.yazılı: ");
// int not2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Sözlü: ");
// int sozlu = Convert.ToInt32(Console.ReadLine());

// var ortalama = (not1 + not2 + sozlu) / 3;
// int not = -1;
// bool ok = true;

// if(ortalama >= 0 && ortalama < 25) {
//     not = 0;
// } else if(ortalama >= 25 && ortalama < 45) {
//     not = 1;
// } else if(ortalama >= 45 && ortalama < 55) {
//     not = 2;
// } else if(ortalama >= 55 && ortalama < 70) {
//     not = 3;
// } else if(ortalama >= 70 && ortalama < 85) {
//     not = 4;
// }
// else if(ortalama >= 85 && ortalama <= 100) {
//     not = 5;
// } else {
//     ok = false;
//     Console.WriteLine("yanlış not girdiniz");
// }

// if(ok) {
//     Console.WriteLine($"not ortalamanız: {ortalama} ve notunuz: {not}");
// }

// 3- Girilen 3 sayıdan en büyüğünü bulunuz.

Console.Write("a: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("b: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("c: ");
int c = Convert.ToInt32(Console.ReadLine());

int enbuyuk = 0;

if(a > b && a > c) {
    enbuyuk = a;
} else if(b > a && b > c) {
    enbuyuk = b;
} else {
    enbuyuk = c;
}

Console.WriteLine("en büyük: " + enbuyuk);
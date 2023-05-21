// For Döngüsü Uygulamaları

// 1- "1-100" arasındaki sayıların toplamını hesaplayınız.

// var toplam = 0;

// for(var i = 1; i <= 100; i++ ) {
//     if(i % 2 == 1) {
//         toplam += i;
//     }
// }

// Console.WriteLine(toplam);

// 2- Klavyeden girilen başlangıç ve bitiş değerleri arasındaki tüm sayıların toplamını hesaplayınız.
// Console.Write("başlangıç: ");
// var baslangic = Convert.ToInt32(Console.ReadLine());

// Console.Write("bitiş: ");
// var bitis = Convert.ToInt32(Console.ReadLine());

// Console.Write("artış: ");
// var artis = Convert.ToInt32(Console.ReadLine());

// var toplam = 0;
// for(var i = baslangic; i < bitis; i = i + artis) {
//     toplam += i;
// }
// Console.WriteLine(toplam);

// 3- {"ali","ahmet","can","yelda","seda"} dizindeki tüm elemanları ekrana yazdırın.

// string[] isimler = {"ali","ahmet","yelda","seda","emel"};

// for(var i = 0; i < isimler.Length; i++) {
//     Console.WriteLine(isimler[i]);
// }

// 4- {1,3,4,34,41,56,89} dizisindeki sayılardan hangisileri 3' ün katıdır?

int[] sayilar = {1,3,4,36,41,56,89,100};

for(var i = 0; i < sayilar.Length; i++) {
    if(sayilar[i] % 3 == 0) {
        Console.WriteLine(sayilar[i]);
    }
}

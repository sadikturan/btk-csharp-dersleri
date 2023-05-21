// While Döngüsü

// for(var i = 0; i < 10; i++) {
//     Console.WriteLine(i);
// }

// var i = 0;

// while(i < 10) {
//     Console.WriteLine(i);
//     i++;
// }

// string[] isimler = {"ali","ahmet","canan"};

// var i = 0;
// while(i < isimler.Length) {
//     Console.WriteLine(isimler[i]);
//     i++;
// }

var secim = "e";
var sayac = 1;
var toplam = 0;

while(secim == "e") {
    Console.Write($"{sayac}. sayı: ");
    toplam += Convert.ToInt32(Console.ReadLine());

    Console.Write("devam etmek istiyor musunuz? (e/h)");
    secim = Console.ReadLine();

    sayac++;
}

Console.WriteLine($"{sayac-1} adet sayının toplamı: {toplam}");

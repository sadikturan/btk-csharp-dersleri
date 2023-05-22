// forEach

string ad = "Ahmet";

// for(var i = 0; i < ad.Length; i++) {
//     Console.WriteLine(ad[i]);
// }

foreach(var harf in ad) {
    Console.WriteLine(harf);
}

int[] sayilar = {10,20,40,45,50};

foreach(var sayi in sayilar) {
    if(sayi == 20)
        break;
    Console.WriteLine(sayi);
}
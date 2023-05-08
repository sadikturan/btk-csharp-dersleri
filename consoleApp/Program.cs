/*
    Strings: Karakter dizileri - reference => null
*/

Console.Write("adı: ");
var ad = Console.ReadLine();

Console.Write("soyad: ");
var soyad = Console.ReadLine();

Console.Write("yaş: ");
var yas = Console.ReadLine();

// string concat
// string mesaj = ad +" "+ soyad + " isimli kişi "+ yas + " yaşındadır.";

// string interpolation
string mesaj = $"{ad} {soyad} isimli kişi {yas} yaşındadır.";

Console.WriteLine(mesaj);
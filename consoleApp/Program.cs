// Çok Boyutlu Diziler

// Ali   => 50, 60, 70
// Ahmet => 60, 80, 90
// Canan => 50, 70, 30

// Her öğrencinin not ortalamasını hesaplayınız.

string[] ogrenciler = {"Ali","Ahmet","Canan"};
int[,] notlar = new int[3,3];

// ali
notlar[0,0] = 50;
notlar[0,1] = 60;
notlar[0,2] = 70;

// ahmet
notlar[1,0] = 60;
notlar[1,1] = 80;
notlar[1,2] = 90;

// canan
notlar[2,0] = 50;
notlar[2,1] = 70;
notlar[2,2] = 30;

var ortalama_1 = (notlar[0,0] + notlar[0,1] + notlar[0,2]) / 3;
var ortalama_2 = (notlar[1,0] + notlar[1,1] + notlar[1,2]) / 3;
var ortalama_3 = (notlar[2,0] + notlar[2,1] + notlar[2,2]) / 3;

Console.WriteLine($"{ogrenciler[0]} isimli öğrencinin not ortalaması: {ortalama_1}");
Console.WriteLine($"{ogrenciler[1]} isimli öğrencinin not ortalaması: {ortalama_2}");
Console.WriteLine($"{ogrenciler[2]} isimli öğrencinin not ortalaması: {ortalama_3}");
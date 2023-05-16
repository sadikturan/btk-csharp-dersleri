// Mantıksal Operatörler Uygulamaları

// 1- Yaşı 18' den büyük ya da veli izni varsa bir işte çalışabilir durumunu kontrol ediniz.

// int yas = 17;
// bool veli_izni = false;
// var sonuc = (yas >= 18 || veli_izni) ? "çalışabilir": "çalışamaz";
// Console.WriteLine(sonuc);

// 2- Ders notu 50-100 arasındaysa geçti değilse kalsın bilgisini yazdırınız.

// int not = 40;
// var sonuc = (not >= 50 && not <= 100) ? "geçti":"kaldı";
// Console.WriteLine(sonuc);

// 3- Ders ortalaması en az 70 puan ve zayıfı yoksa teşekkür belgesi alabilme durumunu kontrol ediniz.

// int ortalama = 65;
// int zayif = 0;

// var sonuc = (ortalama >= 70) ? 
//                 ((zayif == 0) ? "teşekkür alabilir":"zayıfınız olmaması gerekiyor.") :
//                 "notunuz en az 70 olmalıdır.";

// Console.WriteLine(sonuc);

// 4- İşe girmek için en az önlisans ya da lisans mezunu olma durumunu kontrol ediniz. Sigara kullanmama koşulu.

// string egitim = "lise";
// bool sigara_icme = false;
// var sonuc = ((egitim == "lisans" || egitim == "önlisans") && (!sigara_icme)) ? "işe girebilir": "işe giremez";
// Console.WriteLine(sonuc);

// 5- Uygulamaya giriş kontrolünü username ya da parola için yapalım.

string email = "info@sadikturan.com";
string username = "sadikturan";
string password = "12345";

var sonuc = ((email == "info@sadikturan" || username=="sadikturan2") && (password == "12345")) ? "başarılı":"başarısız";
Console.WriteLine(sonuc);


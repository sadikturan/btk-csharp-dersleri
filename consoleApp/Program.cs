// Dizi Uygulama

// ogrenciler ve notlar isminde 2 tane dizi oluşturunuz ve dizi elemanlarını kullanıcıdan aldığınız değerlerle doldurunuz. (3 öğrenci)

// ogrenciler dizisi kaç elemanlıdır, yazdırınız.
// ilk 2 öğrencinin ad ve not bilgisini yazdırınız.
// tüm öğrencilerin not ortalaması nedir? 

var ogrenciler = new string[3];
var notlar = new int[3];

Console.Write("1.öğrenci adı: ");
ogrenciler[0] = Console.ReadLine() ?? "";

Console.Write("1.öğrenci notu: ");
notlar[0] = Convert.ToInt32(Console.ReadLine());

Console.Write("2.öğrenci adı: ");
ogrenciler[1] = Console.ReadLine() ?? "";

Console.Write("2.öğrenci notu: ");
notlar[1] = Convert.ToInt32(Console.ReadLine());

Console.Write("3.öğrenci adı: ");
ogrenciler[2] = Console.ReadLine() ?? "";

Console.Write("1.öğrenci notu: ");
notlar[2] = Convert.ToInt32(Console.ReadLine());

foreach(var ogrenci in ogrenciler[..2]) {
    Console.WriteLine(ogrenci);
}

foreach(var not in notlar[..2]) {
    Console.WriteLine(not);
}

Console.WriteLine("öğrenciler dizisinin eleman sayısı: " + ogrenciler.Length);

var not1 = notlar[0];
var not2 = notlar[1];
var not3 = notlar[2];

var ortalama = (not1 + not2 + not3) / 3;

Console.WriteLine("öğrencilerin not ortalaması: " + ortalama);
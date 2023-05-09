/*
    String Methods
*/

string mesaj = "Ahmet Turan isimli kişi 20 yaşındadır.";

// var sonuc = mesaj.Length;
// var sonuc = mesaj.ToLower();
// var sonuc = mesaj.ToUpper();
// var sonuc = mesaj.Trim();
// var sonuc = mesaj.Split(" ")[0];
// var sonuc = mesaj[0];
// var sonuc = mesaj.StartsWith("B");
// var sonuc = mesaj.EndsWith(".");
// var sonuc = mesaj.Contains("Ali");
// var sonuc = mesaj.IndexOf("abc");
var sonuc = mesaj.Substring(6, 5);

Console.WriteLine(sonuc);
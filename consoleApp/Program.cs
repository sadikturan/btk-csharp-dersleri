// Mantıksal Operatörler

var a = true;
var b = true;
var c = false;
var d = false;

// 1- Ve - &&
var sonuc = (a && b); 
sonuc = (a && c);
sonuc = (c && d);

// 2- Veya - ||
sonuc = (a || b);
sonuc = (c || b);
sonuc = (c || d);

// 3- Değil - !
sonuc = !c;
Console.WriteLine(sonuc);   



// Karşılaştırma Operatörleri

int a = 5, b = 5, c = 10, d = 3;
string username = "sadikturan";
string password = "1234";

var sonuc = (a == b); // true
sonuc = (c == d);
sonuc = (username == "sadikturan"); // true
sonuc = (password == "12345");      // false

sonuc = (a != b);
sonuc = (a > c);
sonuc = (a < c);
sonuc = (a >= b);

// ternary
var sonuc2 = (a > b) ? "a büyük": (a == b) ? "a b eşit": "b büyük";

Console.WriteLine(sonuc2);
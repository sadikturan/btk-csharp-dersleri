// Random

string[] takimlar = {"Beşiktaş","Galatasaray","Fenerbahçe","Trabzon"};

var rnd = new Random();

int sayi = rnd.Next(0,4);

Console.WriteLine(sayi);

Console.WriteLine(takimlar[sayi]);
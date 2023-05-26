// StreamReader sr = File.OpenText("deneme.txt");

// var s = "";

// while((s = sr.ReadLine()) != null) {
//     Console.WriteLine(s);
// }


// string sonuc = File.ReadAllText("deneme.txt");
string[] sonuc = File.ReadAllLines("deneme.txt");

Console.WriteLine(sonuc[0]);
Console.WriteLine(sonuc[2]);
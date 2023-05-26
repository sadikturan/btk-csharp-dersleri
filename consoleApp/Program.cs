// using(StreamWriter sw = File.CreateText("deneme.txt")) {
//     sw.WriteLine("Merhaba");
//     sw.WriteLine("BTK");
//     sw.WriteLine("Akademi");
// }

// using(StreamWriter sw = File.AppendText("deneme.txt")) {
//     sw.WriteLine("Selam");
//     sw.WriteLine("BTK");
//     sw.WriteLine("Akademi");
// }

File.WriteAllText("deneme.txt", "merhaba");
File.AppendAllText("deneme.txt", "merhaba");

using(StreamReader sr = File.OpenText("deneme.txt")) {
    var s = "";

    while((s = sr.ReadLine()) != null) {
        Console.WriteLine(s);
    }
}


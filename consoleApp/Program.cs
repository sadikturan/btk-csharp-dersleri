// Directory.CreateDirectory("temp");
// Directory.CreateDirectory("temp/deneme");
// Directory.CreateDirectory("temp/deneme2");

// if(Directory.Exists("temp/deneme2")) {
//     Directory.Delete("temp/deneme2");
// } else {
//     Console.WriteLine("silmek istediğiniz klasör yok");
// }


// string path = @"C:\temp";
// string path = "/Users/sadikturan/Desktop/temp/deneme";
string path = Directory.GetCurrentDirectory() + "/temp";

Console.WriteLine(path);

Directory.CreateDirectory(path);
